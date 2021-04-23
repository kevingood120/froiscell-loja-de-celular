using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql
{
    public class CorBanco
    {
        MySqlController controleBanco = new MySqlController();

        public void InserirCor(Cor cor)
        {
            try
            {
                controleBanco.LimpaParametros();
                controleBanco.AdicionaParametro("@cor", cor.Nome_cor);
                string comando = "INSERT INTO tb_cores VALUES (NULL,@cor);";
                cor.Cod_cor = Convert.ToSByte(controleBanco.ExecuteNonQuery(comando));
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

        public void AlterarCor(Cor cor)
        {
            try
            {
                controleBanco.LimpaParametros();
                controleBanco.AdicionaParametro("@codigo", cor.Cod_cor);
                controleBanco.AdicionaParametro("@cor", cor.Nome_cor);
                string comando = "UPDATE tb_cores SET cor = @cor WHERE cod_cor = @codigo;";
                controleBanco.ExecuteNonQuery(comando);
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

        public CorColecao MostrarTodos()
        {
            controleBanco.LimpaParametros();
            string comando = "SELECT * FROM tb_cores ORDER BY cor;";
            DataTable dt = controleBanco.ExecuteReader(comando);
            CorColecao colecao = new CorColecao();
            foreach(DataRow dr in dt.Rows)
            {
                colecao.Add(new Cor()
                {
                    Cod_cor = Convert.ToSByte(dr["cod_cor"]),
                    Nome_cor = Convert.ToString(dr["cor"])
                });
            }
            dt.Dispose();
            return colecao;
        }

        public short ContadorCores(Cor cor)
        {
            controleBanco.LimpaParametros();
            controleBanco.AdicionaParametro("@cor", cor.Nome_cor);
            controleBanco.AdicionaParametro("@codigo", cor.Cod_cor);
            string comando = "SELECT COUNT(cod_cor) FROM tb_cores WHERE UPPER(REPLACE(cor,' ','')) = UPPER(REPLACE(@cor,' ','')) AND cod_cor <> @codigo;";
            return Convert.ToInt16(controleBanco.ExecuteScalarSemTransacao(comando));
        }
    }
}
