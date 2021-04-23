using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql
{
    public class GrupoBanco
    {
        MySqlController bancoControle = new MySqlController();

        public void InserirGrupo(Grupo grupo)
        {
            try
            {
                bancoControle.LimpaParametros();
                bancoControle.AdicionaParametro("@grupo", grupo.Nome_grupo);
                string comando = "INSERT INTO tb_grupo VALUES (NULL, @grupo);";
                grupo.Cod_grupo = Convert.ToInt32(bancoControle.ExecuteNonQuery(comando));
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

        public void AlterarGrupo(Grupo grupo)
        {
            try
            {
                bancoControle.LimpaParametros();
                bancoControle.AdicionaParametro("@codigo", grupo.Cod_grupo);
                bancoControle.AdicionaParametro("@grupo", grupo.Nome_grupo);
                string comando = "UPDATE tb_grupo SET nome_grupo = @grupo WHERE cod_grupo = @codigo;";
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

        public GrupoColecao MostrarTodos()
        {
            bancoControle.LimpaParametros();
            string comando = "SELECT * FROM tb_grupo;";
            DataTable dt = bancoControle.ExecuteReader(comando);
            GrupoColecao colecao = new GrupoColecao();
            foreach(DataRow dr in dt.Rows)
            {
                colecao.Add(new Grupo()
                {
                    Nome_grupo = Convert.ToString(dr["Nome_grupo"]),
                    Cod_grupo = Convert.ToInt32(dr["Cod_grupo"])
                });
            }
            return colecao;
        }

        public short ContadorGrupo(Grupo grupo)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@grupo", grupo.Nome_grupo);
            bancoControle.AdicionaParametro("@codigo", grupo.Cod_grupo);
            string comando = "SELECT COUNT(cod_grupo) FROM tb_grupo WHERE UPPER(REPLACE(nome_grupo,' ','')) = UPPER(REPLACE(@grupo,' ','')) AND cod_grupo <> @codigo;";
            return Convert.ToInt16(bancoControle.ExecuteScalarSemTransacao(comando));
        }
    }
}
