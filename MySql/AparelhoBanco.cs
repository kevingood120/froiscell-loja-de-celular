using Modelo;
using Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql
{
    public class AparelhoBanco
    {
        MySqlController bancoControle = new MySqlController();

        public AparelhoColecao PesquisarPorNome(string aparelho)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@aparelho", aparelho);
            string comando = "SELECT tb_aparelho.cod_aparelho,tb_aparelho.cod_marca,tb_aparelho.tipo_aparelho,tb_aparelho.modelo_aparelho, tb_marcas.marca " +
                             "FROM tb_aparelho INNER JOIN tb_marcas " +
                             "ON tb_aparelho.cod_marca = tb_marcas.cod_marca " +
                             "WHERE (tb_aparelho.modelo_aparelho LIKE CONCAT('%',@aparelho,'%')) OR (tb_marcas.marca LIKE CONCAT('%',@aparelho,'%'));";
            DataTable dt = bancoControle.ExecuteReader(comando);
            AparelhoColecao colecao = new AparelhoColecao();
            foreach (DataRow dr in dt.Rows)
            {
                Aparelho aparelhoItem = new Aparelho();
                aparelhoItem.Modelo_aparelho = Convert.ToString(dr["modelo_aparelho"]);
                aparelhoItem.Cod_aparelho = Convert.ToUInt32(dr["cod_aparelho"]);
                aparelhoItem.MarcaSelecionada.Cod_marca = Convert.ToInt32(dr["cod_marca"]);
                aparelhoItem.MarcaSelecionada.Nome_marca = Convert.ToString(dr["marca"]);
                aparelhoItem.TipoSelecionado = (Aparelhos)Enum.Parse(typeof(Aparelhos), Convert.ToString(dr["tipo_aparelho"]));
                colecao.Add(aparelhoItem);
            }
            dt.Dispose();
            return colecao;
        }

        public void InserirAparelho(Aparelho aparelho)
        {
            try
            {
                bancoControle.LimpaParametros();
                bancoControle.AdicionaParametro("@cod_marca", aparelho.MarcaSelecionada.Cod_marca);
                bancoControle.AdicionaParametro("@tipo", aparelho.TipoSelecionado);
                bancoControle.AdicionaParametro("@modelo_aparelho", aparelho.Modelo_aparelho);
                string comando = "INSERT INTO tb_aparelho VALUES (NULL,@cod_marca,@tipo,@modelo_aparelho);";
                uint codigoAparelho = bancoControle.ExecuteNonQuery(comando);
                aparelho.Cod_aparelho = codigoAparelho;
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

        public void AlterarAparelho(Aparelho aparelho)
        {
            try
            {
                bancoControle.LimpaParametros();
                bancoControle.AdicionaParametro("@codigo", aparelho.Cod_aparelho);
                bancoControle.AdicionaParametro("@cod_marca", aparelho.MarcaSelecionada.Cod_marca);
                bancoControle.AdicionaParametro("@tipo", aparelho.TipoSelecionado);
                bancoControle.AdicionaParametro("@modelo_aparelho", aparelho.Modelo_aparelho);
                string comando = " UPDATE tb_aparelho SET modelo_aparelho = @modelo_aparelho, cod_marca = @cod_marca, tipo_aparelho = @tipo WHERE cod_aparelho = @codigo;";
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

        public short ContadorAparelho(Aparelho aparelho)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@modelo_aparelho", aparelho.Modelo_aparelho);
            bancoControle.AdicionaParametro("@marca", aparelho.MarcaSelecionada.Cod_marca);
            bancoControle.AdicionaParametro("@codigo", aparelho.Cod_aparelho);
            string comando = "SELECT COUNT(cod_aparelho) FROM tb_aparelho WHERE LOWER(REPLACE(modelo_aparelho,' ','')) = LOWER(REPLACE(@modelo_aparelho,' ','')) AND cod_marca = @marca  AND cod_aparelho <> @codigo;";
            return Convert.ToInt16(bancoControle.ExecuteScalarSemTransacao(comando));
        }
    }
}
