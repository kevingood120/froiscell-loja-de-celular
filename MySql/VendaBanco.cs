using Modelo;
using Modelo.Enums;
using System;
using System.Data;

namespace MySql
{
    public class VendaBanco
    {
        MySqlController controleBanco = new MySqlController();

        public void InserirVenda(Venda venda)
        {
            try
            {
                controleBanco.LimpaParametros();
                controleBanco.AdicionaParametro("@codigoCliente", venda.ClienteSelecionado.Cod_cliente);
                controleBanco.AdicionaParametro("@totalVenda", venda.Total_venda);
                controleBanco.AdicionaParametro("@observacao", venda.Obs_venda);
                string comando = "INSERT INTO tb_vendas VALUES(NULL,criarcaixa(),@codigoCliente,NOW(),@totalVenda,@observacao)";
                venda.Cod_venda = controleBanco.ExecuteNonQuery(comando);
                InserirItensVenda(venda);
                InserirPagamentosVenda(venda);
                controleBanco.Commit();
            }
            catch
            {
                controleBanco.Rollback();
                throw;
            }
            finally
            {
                controleBanco.FechaConexaoTransacao();
            }
        }

        private void InserirItensVenda(Venda venda)
        {
            foreach (ItemVenda item in venda.Itens)
            {
                controleBanco.LimpaParametros();
                controleBanco.AdicionaParametro("@codigoVenda", venda.Cod_venda);
                controleBanco.AdicionaParametro("@codigoProduto", item.ProdutoSelecionado.Cod_produto);
                controleBanco.AdicionaParametro("@quantidade", item.Quantidade);
                controleBanco.AdicionaParametro("@subtotal", item.Subtotal);
                string comando = "INSERT INTO tb_itens_venda VALUES(@codigoVenda, @codigoProduto, @quantidade, @subtotal)";
                controleBanco.ExecuteNonQuery(comando);
            }
        }

        private void InserirPagamentosVenda(Venda venda)
        {
            foreach (Pagamento pgto in venda.PagamentoColecao)
            {
                controleBanco.LimpaParametros();
                controleBanco.AdicionaParametro("@codigo", venda.Cod_venda);
                controleBanco.AdicionaParametro("@pagamento", pgto.PagamentoSelecionado);
                controleBanco.AdicionaParametro("@valor", pgto.Valor);
                controleBanco.AdicionaParametro("@vezes", pgto.Vezes);
                string comando = "INSERT INTO tb_pagamento_venda VALUES(@codigo,@pagamento,@valor,@vezes)";
                controleBanco.ExecuteNonQuery(comando);
            }
        }

        public ItemVendaColecao PegarItensVenda(uint codigo)
        {
            controleBanco.LimpaParametros();
            ItemVendaColecao colecao = new ItemVendaColecao();
            controleBanco.AdicionaParametro("@codigo", codigo);
            string comando = "SELECT i.cod_produto,i.quantidade,i.subtotal,g.nome_grupo,p.preco_produto,p.desc_produto " +
                "FROM tb_itens_venda AS i " +
                "INNER JOIN tb_produtos AS p ON i.cod_produto = p.cod_produto " +
                "INNER JOIN tb_grupo AS g ON p.cod_grupo = g.cod_grupo " +
                "WHERE i.cod_venda = @codigo";
            DataTable dt = controleBanco.ExecuteReader(comando);
            foreach (DataRow row in dt.Rows)
            {
                ItemVenda item = new ItemVenda();
                item.ProdutoSelecionado.Cod_produto = Convert.ToUInt32(row["cod_produto"]);
                item.ProdutoSelecionado.Desc_produto = Convert.ToString(row["desc_produto"]);
                item.ProdutoSelecionado.GrupoSelecionado.Nome_grupo = Convert.ToString(row["nome_grupo"]);
                item.ProdutoSelecionado.Preco_produto = Convert.ToDecimal(row["preco_produto"]);
                item.Quantidade = Convert.ToInt16(row["quantidade"]);
                item.Subtotal = Convert.ToDecimal(row["subtotal"]);
                colecao.Add(item);
            }
            dt.Dispose();
            return colecao;
        }

        public PagamentoColecao PegarPagamentoVenda(uint codigo)
        {
            controleBanco.LimpaParametros();
            controleBanco.AdicionaParametro("@codigo", codigo);
            string comando = "SELECT tipo_pagamento,pgto,credito_vezes FROM tb_pagamento_venda WHERE cod_venda = @codigo";
            DataTable dt = controleBanco.ExecuteReader(comando);
            PagamentoColecao colecao = new PagamentoColecao();
            foreach (DataRow row in dt.Rows)
            {
                Pagamento pagamento = new Pagamento()
                {
                    PagamentoSelecionado = (Pagamentos)Enum.Parse(typeof(Pagamentos), Convert.ToString(row["tipo_pagamento"])),
                    Valor = Convert.ToDecimal(row["pgto"]),
                    Vezes = row["credito_vezes"] == DBNull.Value ? (byte?)null : Convert.ToByte(row["credito_vezes"])
                };
                colecao.Add(pagamento);
            }
            dt.Dispose();
            return colecao;
        }

        public Venda PesquisarPorCodigo(uint codigo)
        {
            controleBanco.LimpaParametros();
            controleBanco.AdicionaParametro("@codigo", codigo);
            string comando = "SELECT v.cod_venda,v.cod_cliente,obs_venda,c.nome_cliente, v.reg_venda, c.cpf_cliente " +
                "FROM tb_vendas AS v " +
                "INNER JOIN tb_clientes AS c ON v.cod_cliente = c.cod_cliente " +
                "WHERE v.cod_venda = @codigo;";
            DataTable dt = controleBanco.ExecuteReader(comando);
            Venda venda = null;
            if(dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                venda = new Venda();
                venda.ClienteSelecionado.Cod_cliente = Convert.ToUInt32(dr["cod_cliente"]);
                venda.ClienteSelecionado.Nome_cliente = Convert.ToString(dr["nome_cliente"]);
                venda.ClienteSelecionado.Cpf_cliente = Convert.ToString(dr["cpf_cliente"]);
                venda.Cod_venda = Convert.ToUInt32(dr["cod_venda"]);
                venda.Obs_venda = Convert.ToString(dr["obs_venda"]);
                venda.Reg_venda = Convert.ToDateTime(dr["reg_venda"]);
                venda.Itens = PegarItensVenda(venda.Cod_venda);
                venda.PagamentoColecao = PegarPagamentoVenda(venda.Cod_venda);
                dt.Dispose();
            }
            return venda;
        }
    }
}
