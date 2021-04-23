using Modelo;
using Modelo.Enums;
using System;
using System.Data;

namespace MySql
{
    public class CaixaBanco
    {
        MySqlController bancoControle = new MySqlController();
        VendaBanco bancoVenda = new VendaBanco();
        OSBanco osBanco = new OSBanco();

        public DateTime HoraServidor
        {
            get
            {
                bancoControle.LimpaParametros();
                string texto = "SELECT NOW();";
                return (DateTime)bancoControle.ExecuteScalarSemTransacao(texto);
            }
        }

        public VendaColecao PesquisarVendaCaixa(DateTime dataInicial, DateTime? dataFinal)
        {
            bancoControle.LimpaParametros();
            VendaColecao colecao = new VendaColecao();
            bancoControle.AdicionaParametro("@dataInicial", dataInicial);
            bancoControle.AdicionaParametro("@dataFinal", dataFinal);
            string comando = "SELECT v.cod_venda,v.reg_venda,obs_venda,c.nome_cliente " +
                            "FROM tb_vendas AS v " +
                            "INNER JOIN tb_clientes AS c ON v.cod_cliente = c.cod_cliente " +
                            "INNER JOIN tb_caixa AS ca ON v.cod_caixa = ca.cod_caixa " +
                            "WHERE(@dataFinal IS NOT NULL) OR CAST(ca.cod_caixa AS DATE) BETWEEN CAST(@dataInicial AS DATE) AND CAST(@dataFinal AS DATE) " +
                            "AND(@dataFinal IS NULL) OR CAST(ca.reg_caixa AS DATE) = CAST(@dataInicial AS DATE)";
            DataTable dt = bancoControle.ExecuteReader(comando);
           
            foreach (DataRow dr in dt.Rows)
            {
                Venda venda = new Venda();
                venda.ClienteSelecionado.Nome_cliente = Convert.ToString(dr["nome_cliente"]);
                venda.Cod_venda = Convert.ToUInt32(dr["cod_venda"]);
                venda.Obs_venda = Convert.ToString(dr["obs_venda"]);
                venda.Reg_venda = Convert.ToDateTime(dr["reg_venda"]);
                venda.Itens = bancoVenda.PegarItensVenda(venda.Cod_venda);
                venda.PagamentoColecao = bancoVenda.PegarPagamentoVenda(venda.Cod_venda);
                venda.Total_venda = venda.PagamentoColecao.Total;
                colecao.Add(venda);
            }
            dt.Dispose();
            return colecao;
        }

        public MovimentacaoCaixaColecao PesquisarMovimentacaoCaixa(DateTime dataInicial, DateTime? dataFinal)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@dataInicial", dataInicial);
            bancoControle.AdicionaParametro("@dataFinal", dataFinal);
            string comando = "SELECT m.razao, m.valor, m.subtrair, m.data_entrada, m.cod_mov " +
                            "FROM tb_movimentacao_caixa AS m " +
                            "INNER JOIN tb_caixa AS c ON c.cod_caixa = m.cod_caixa " +
                            "WHERE(@dataFinal IS NOT NULL) OR CAST(c.cod_caixa AS DATE) BETWEEN CAST(@dataInicial AS DATE) AND CAST(@dataFinal AS DATE) " +
                            "AND(@dataFinal IS NULL) OR CAST(c.reg_caixa AS DATE) = CAST(@dataInicial AS DATE); ";
            DataTable dt = bancoControle.ExecuteReader(comando);
            MovimentacaoCaixaColecao colecao = new MovimentacaoCaixaColecao();

            foreach(DataRow dr in dt.Rows)
            {
                MovimentacaoCaixa movimentacaoCaixa = new MovimentacaoCaixa()
                {
                    Cod_mov = Convert.ToUInt32(dr["cod_mov"]),
                    Data_entrada = Convert.ToDateTime(dr["data_entrada"]),
                    Razao = Convert.ToString(dr["razao"]),
                    Subtrair = Convert.ToBoolean(dr["subtrair"]),
                    Valor = Convert.ToDecimal(dr["valor"])
                };
                colecao.Add(movimentacaoCaixa);
            }

            return colecao;
        }

        public OSColecao PesquisarOrdemCaixa(DateTime dataInicial, DateTime? dataFinal)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@dataInicial", dataInicial);
            bancoControle.AdicionaParametro("@dataFinal", dataFinal);
            string comando = "SELECT o.cod_ordem,n.cor,o.reg_saida,o.orc_descricao,o.reg_entrada,c.nome_cliente,a.modelo_aparelho,a.tipo_aparelho,m.marca FROM tb_caixa_ordem AS co " +
                "INNER JOIN tb_ordemservico AS o ON co.cod_ordem = o.cod_ordem " +
                "INNER JOIN tb_clientes AS c ON o.cod_cliente = c.cod_cliente " +
                "INNER JOIN tb_aparelho AS a ON o.cod_aparelho = a.cod_aparelho " +
                "INNER JOIN tb_marcas AS m ON a.cod_marca = m.cod_marca " +
                "INNER JOIN tb_cores AS n ON o.cod_cor = n.cod_cor " +
                "INNER JOIN tb_caixa AS ca ON co.cod_caixa = ca.cod_caixa " +
                "WHERE(@dataFinal IS NOT NULL) OR CAST(ca.cod_caixa AS DATE) BETWEEN CAST(@dataInicial AS DATE) AND CAST(@dataFinal AS DATE) " +
                "AND(@dataFinal IS NULL) OR CAST(ca.reg_caixa AS DATE) = CAST(@dataInicial AS DATE)";

            DataTable dt = bancoControle.ExecuteReader(comando);
            OSColecao colecao = new OSColecao();
            foreach (DataRow dr in dt.Rows)
            {
                OS os = new OS();
                os.ClienteSelecionado.Nome_cliente = Convert.ToString(dr["nome_cliente"]);
                os.Cod_ordem = Convert.ToUInt32(dr["cod_ordem"]);
                os.CorSelecionada.Nome_cor = Convert.ToString(dr["cor"]);
                os.Reg_saida = Convert.ToDateTime(dr["reg_saida"] == DBNull.Value ? DateTime.Now : dr["reg_saida"]);
                os.Orc_descricao = Convert.ToString(dr["orc_descricao"]);
                os.Reg_entrada = Convert.ToDateTime(dr["reg_entrada"]);
                os.AparelhoSelecionado.Modelo_aparelho = Convert.ToString(dr["modelo_aparelho"]);
                os.AparelhoSelecionado.TipoSelecionado = (Modelo.Enums.Aparelhos)Enum.Parse(typeof(Aparelhos), dr["tipo_aparelho"].ToString());
                os.AparelhoSelecionado.MarcaSelecionada.Nome_marca = Convert.ToString(dr["marca"]);
                os.PagamentoColecao = osBanco.PegarPagamentoOS(os.Cod_ordem);
                os.Orc_preco = os.PagamentoColecao.Total;
                colecao.Add(os);
            }
            dt.Dispose();
            return colecao;
        }
    }
}
