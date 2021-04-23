using Modelo;
using System;
using System.Data;

namespace MySql
{
    public class ProdutoBanco
    {
        MySqlController bancoControle = new MySqlController();

        public void AdicionarProduto(Produto produto)
        {
            try
            {
                bancoControle.LimpaParametros();
                bancoControle.AdicionaParametro("@cod_grupo", produto.GrupoSelecionado.Cod_grupo);
                bancoControle.AdicionaParametro("@preco_produto", produto.Preco_produto);
                bancoControle.AdicionaParametro("@precocusto_produto", produto.Precocusto_produto);
                bancoControle.AdicionaParametro("@qtd_produto", produto.Qtd_produto);
                bancoControle.AdicionaParametro("@qtdmin_produto", produto.Qtdmin_produto);
                bancoControle.AdicionaParametro("@desc_produto", produto.Desc_produto);
                bancoControle.AdicionaParametro("@codigo_barras", produto.Codigo_barras);
                string comando = "INSERT INTO tb_produtos VALUES(NULL,@cod_grupo,@preco_produto,@precocusto_produto,@qtd_produto,@qtdmin_produto,@desc_produto,@codigo_barras);";
                produto.Cod_produto = bancoControle.ExecuteNonQuery(comando);
                bancoControle.Commit();
            }
            catch
            {
                bancoControle.Rollback();
                throw;
            }
            finally
            {
                bancoControle.FechaConexaoTransacao();
            }
        }

        public void AlterarProduto(Produto produto)
        {
            try
            {
                bancoControle.LimpaParametros();
                bancoControle.AdicionaParametro("@cod_produto", produto.Cod_produto);
                bancoControle.AdicionaParametro("@cod_grupo", produto.GrupoSelecionado.Cod_grupo);
                bancoControle.AdicionaParametro("@preco_produto", produto.Preco_produto);
                bancoControle.AdicionaParametro("@precocusto_produto", produto.Precocusto_produto);
                bancoControle.AdicionaParametro("@qtd_produto", produto.Qtd_produto);
                bancoControle.AdicionaParametro("@qtdmin_produto", produto.Qtdmin_produto);
                bancoControle.AdicionaParametro("@desc_produto", produto.Desc_produto);
                bancoControle.AdicionaParametro("@codigo_barras", produto.Codigo_barras);
                string comando = "UPDATE tb_produtos SET cod_grupo = @cod_grupo, preco_produto = @preco_produto, precocusto_produto = @precocusto_produto, qtd_produto = @qtd_produto, qtdmin_produto = @qtdmin_produto, desc_produto = @desc_produto, codigo_barras = @codigo_barras WHERE cod_produto = @cod_produto;";
                bancoControle.ExecuteNonQuery(comando);
                bancoControle.Commit();
            }
            catch
            {
                bancoControle.Rollback();
                throw;
            }
            finally
            {
                bancoControle.FechaConexaoTransacao();
            }
        }

        public ProdutoColecao PesquisarPorNome(string produtoNome)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@produto", produtoNome);
            string comando = "SELECT p.cod_produto,p.cod_grupo,p.preco_produto,p.qtd_produto,p.qtdmin_produto,p.precocusto_produto,p.desc_produto,p.codigo_barras,g.nome_grupo " +
                             "FROM tb_produtos AS p INNER JOIN tb_grupo AS g " +
                             "ON p.cod_grupo = g.cod_grupo WHERE (g.nome_grupo LIKE CONCAT('%',@produto,'%')) OR (p.desc_produto LIKE CONCAT('%',@produto,'%'));";
            DataTable dt = bancoControle.ExecuteReader(comando);
            ProdutoColecao colecao = new ProdutoColecao();
            foreach (DataRow dr in dt.Rows)
            {
                Produto produto = new Produto()
                {
                    Codigo_barras = bancoControle.CampoNulo<string>(dr["codigo_barras"]),
                    Desc_produto = Convert.ToString(dr["desc_produto"]),
                    Cod_produto = Convert.ToUInt32(dr["cod_produto"]),
                    Preco_produto = Convert.ToDecimal(dr["preco_produto"]),
                    Qtdmin_produto = Convert.ToInt16(dr["qtdmin_produto"]),
                    Precocusto_produto = Convert.ToDecimal(dr["precocusto_produto"]),
                    Qtd_produto = Convert.ToInt16(dr["qtd_produto"])
                };
                produto.GrupoSelecionado.Cod_grupo = Convert.ToInt32(dr["cod_grupo"]);
                produto.GrupoSelecionado.Nome_grupo = Convert.ToString(dr["nome_grupo"]);
                colecao.Add(produto);
            }
            dt.Dispose();
            return colecao;
        }

        public Produto PegarProdutoCodigoBarras(string codigoBarra)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@codBarras", codigoBarra);
            string comando = "SELECT p.cod_produto,p.cod_grupo,p.preco_produto,p.qtd_produto,p.qtdmin_produto,p.precocusto_produto,p.desc_produto,p.codigo_barras,g.nome_grupo " +
                             "FROM tb_produtos AS p INNER JOIN tb_grupo AS g " +
                             "ON p.cod_grupo = g.cod_grupo WHERE p.codigo_barras = @codBarras";
            Produto produto = null;
            DataTable dt = bancoControle.ExecuteReader(comando);
            if (dt.Rows.Count == 1)
            {
                produto = new Produto()
                {
                    Codigo_barras = bancoControle.CampoNulo<string>(dt.Rows[0]["codigo_barras"]),
                    Desc_produto = Convert.ToString(dt.Rows[0]["desc_produto"]),
                    Cod_produto = Convert.ToUInt32(dt.Rows[0]["cod_produto"]),
                    Preco_produto = Convert.ToDecimal(dt.Rows[0]["preco_produto"]),
                    Qtdmin_produto = Convert.ToInt16(dt.Rows[0]["qtdmin_produto"]),
                    Precocusto_produto = Convert.ToDecimal(dt.Rows[0]["precocusto_produto"]),
                    Qtd_produto = Convert.ToInt16(dt.Rows[0]["qtd_produto"])
                };
                produto.GrupoSelecionado.Cod_grupo = Convert.ToInt32(dt.Rows[0]["cod_grupo"]);
                produto.GrupoSelecionado.Nome_grupo = Convert.ToString(dt.Rows[0]["nome_grupo"]);
            }
            dt.Dispose();
            return produto;
        }

        public short ContadorCodigoBarras(Produto produto)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@codigo", produto.Cod_produto);
            bancoControle.AdicionaParametro("@codigoBarras", produto.Codigo_barras);
            string comando = "SELECT COUNT(cod_produto) FROM tb_produtos WHERE REPLACE(codigo_barras,' ','') = REPLACE(@codigoBarras,' ','') AND cod_produto <> @codigo;";
            return Convert.ToInt16(bancoControle.ExecuteScalarSemTransacao(comando));
        }

        public ProdutoColecao MostrarTodos()
        {
            bancoControle.LimpaParametros();
            string comando = "SELECT p.cod_produto,p.cod_grupo,p.preco_produto,p.qtd_produto,p.qtdmin_produto,p.precocusto_produto,p.desc_produto,p.codigo_barras,g.nome_grupo " +
                             "FROM tb_produtos AS p INNER JOIN tb_grupo AS g " +
                             "ON p.cod_grupo = g.cod_grupo;";
            DataTable dt = bancoControle.ExecuteReader(comando);
            ProdutoColecao colecao = new ProdutoColecao();
            foreach (DataRow dr in dt.Rows)
            {
                Produto produto = new Produto()
                {
                    Codigo_barras = bancoControle.CampoNulo<string>(dr["codigo_barras"]),
                    Desc_produto = Convert.ToString(dr["desc_produto"]),
                    Cod_produto = Convert.ToUInt32(dr["cod_produto"]),
                    Preco_produto = Convert.ToDecimal(dr["preco_produto"]),
                    Qtdmin_produto = Convert.ToInt16(dr["qtdmin_produto"]),
                    Precocusto_produto = Convert.ToDecimal(dr["precocusto_produto"]),
                    Qtd_produto = Convert.ToInt16(dr["qtd_produto"])
                };
                produto.GrupoSelecionado.Cod_grupo = Convert.ToInt32(dr["cod_grupo"]);
                produto.GrupoSelecionado.Nome_grupo = Convert.ToString(dr["nome_grupo"]);
                colecao.Add(produto);
            }
            dt.Dispose();
            return colecao;
        }

        public ProdutoColecao RelatorioEstoqueMinimo()
        {
            bancoControle.LimpaParametros();
            string comando = "SELECT p.cod_produto,g.nome_grupo,p.preco_produto,p.precocusto_produto,p.qtd_produto, "+
	                         "p.desc_produto "+
                             "FROM tb_produtos AS p INNER JOIN tb_grupo AS g "+
                             "ON g.cod_grupo = p.cod_grupo WHERE p.qtd_produto <= p.qtdmin_produto;";
            ProdutoColecao colecao = new ProdutoColecao();
            using (DataTable dt = bancoControle.ExecuteReader(comando, CommandType.Text))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Produto item = new Produto();
                    item.GrupoSelecionado.Nome_grupo = Convert.ToString(dr["nome_grupo"]);
                    item.Desc_produto = Convert.ToString(dr["desc_produto"]);
                    item.Preco_produto = Convert.ToDecimal(dr["preco_produto"]);
                    item.Precocusto_produto = Convert.ToDecimal(dr["precocusto_produto"]);
                    item.Qtd_produto = Convert.ToInt16(dr["qtd_produto"]);
                    item.Cod_produto = Convert.ToUInt32(dr["cod_produto"]);
                    colecao.Add(item);
                }
                return colecao;
            }

        }
    }
}
