using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql
{
    public class MarcaBanco
    {
        MySqlController controleBanco = new MySqlController();

        public void InserirMarca(Marca marca)
        {
            try
            {
                controleBanco.LimpaParametros();
                controleBanco.AdicionaParametro("@marca", marca.Nome_marca);
                string comando = "INSERT INTO tb_marcas VALUES (NULL,@marca);";
                marca.Cod_marca = Convert.ToInt32(controleBanco.ExecuteNonQuery(comando));
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

        public void AlterarMarca(Marca marca)
        {
            try
            {
                controleBanco.LimpaParametros();
                controleBanco.AdicionaParametro("@marca", marca.Nome_marca);
                controleBanco.AdicionaParametro("@codigo", marca.Cod_marca);
                string comando = "UPDATE tb_marcas SET marca = @marca WHERE cod_marca = @codigo;";
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

        public MarcaColecao MostrarTodos()
        {
            controleBanco.LimpaParametros();
            string comando = "SELECT * FROM tb_marcas;";
            DataTable dt = controleBanco.ExecuteReader(comando);
            MarcaColecao colecao = new MarcaColecao();
            foreach(DataRow dr in dt.Rows)
            {
                colecao.Add(new Marca()
                {
                    Cod_marca = Convert.ToInt32(dr["cod_marca"]),
                    Nome_marca = Convert.ToString(dr["marca"])
                });
            }
            return colecao;
        }

        public short ContadorMarca(Marca marca)
        {
            controleBanco.LimpaParametros();
            controleBanco.AdicionaParametro("@codigo", marca.Cod_marca);
            controleBanco.AdicionaParametro("@marca", marca.Nome_marca);
            string comando = "SELECT COUNT(cod_marca) FROM tb_marcas WHERE UPPER(REPLACE(marca,' ','')) = UPPER(REPLACE(@marca,' ','')) AND cod_marca <> @codigo;";
            return Convert.ToInt16(controleBanco.ExecuteScalarSemTransacao(comando));
        }
    }
}
