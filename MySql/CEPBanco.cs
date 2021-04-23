using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql
{
    public class CEPBanco
    {
        MySqlController bancoControle = new MySqlController();
        public CEP RetornarCEP(string cep)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@cep", cep);
            string comando = "SELECT * FROM tb_cep WHERE cep = @cep";
            DataTable dt = bancoControle.ExecuteReader(comando);
            CEP cepRetornado = null;
            if (dt.Rows.Count == 1)
            {
                cepRetornado = new CEP()
                {
                    Cep = Convert.ToString(dt.Rows[0]["cep"]),
                    Bairro = Convert.ToString(dt.Rows[0]["bairro"]),
                    Cidade = Convert.ToString(dt.Rows[0]["cidade"]),
                    Cod_cep = Convert.ToUInt32(dt.Rows[0]["cod_cep"]),
                    Logra = Convert.ToString(dt.Rows[0]["logra"])
                };
                cepRetornado.Uf = Convert.ToString(dt.Rows[0]["uf"]);
            }
            return cepRetornado;
        }

        public void InserirCEP(CEP cep)
        {
            try
            {
                bancoControle.LimpaParametros();
                bancoControle.AdicionaParametro("@cep", cep.Cep);
                bancoControle.AdicionaParametro("@bairro", cep.Bairro);
                bancoControle.AdicionaParametro("@cidade", cep.Cidade);
                bancoControle.AdicionaParametro("@uf", cep.Uf);
                bancoControle.AdicionaParametro("@logra", cep.Logra);
                string comando = "INSERT INTO tb_cep VALUES (NULL,@cep,@logra,@bairro,@cidade,@uf);";
                cep.Cod_cep = bancoControle.ExecuteNonQuery(comando);
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

        public void AlterarCEP(CEP cep)
        {
            try
            {
                bancoControle.LimpaParametros();
                bancoControle.AdicionaParametro("@cod_cep", cep.Cod_cep);
                bancoControle.AdicionaParametro("@cep", cep.Cep);
                bancoControle.AdicionaParametro("@bairro", cep.Bairro);
                bancoControle.AdicionaParametro("@cidade", cep.Cidade);
                bancoControle.AdicionaParametro("@uf", cep.Uf);
                bancoControle.AdicionaParametro("@logra", cep.Logra);
                string comando = "UPDATE tb_cep SET cep = @cep,bairro = @bairro,cidade = @cidade,logra = @logra,uf = @uf WHERE cod_cep = @cod_cep;";
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

        public CEPColecao PesquisarPorLogradouro(string logradouro)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@logra", logradouro);
            string comando = "SELECT c.cod_cep,c.cep,c.logra,c.bairro,c.cidade,c.uf FROM tb_cep AS c  WHERE c.logra LIKE CONCAT('%',@logra,'%');";
            DataTable dt = bancoControle.ExecuteReader(comando);
            CEPColecao colecao = new CEPColecao();
            foreach (DataRow dr in dt.Rows)
            {
                CEP cep = new CEP();
                cep.Cod_cep = Convert.ToUInt32(dr["cod_cep"]);
                cep.Bairro = Convert.ToString(dr["bairro"]);
                cep.Uf = Convert.ToString(dr["uf"]);
                cep.Cidade = Convert.ToString(dr["cidade"]);
                cep.Cep = Convert.ToString(dr["cep"]);
                cep.Logra = Convert.ToString(dr["logra"]);
                colecao.Add(cep);
            }
            dt.Dispose();
            return colecao;

        }

        public CEPColecao MostrarTodos()
        {
            bancoControle.LimpaParametros();
            string comando = "SELECT c.cod_cep,c.cep,c.logra,c.bairro,c.cidade,u.uf,u.cod_uf FROM tb_cep AS c INNER JOIN tb_uf AS u ON u.cod_uf = c.cod_uf";
            DataTable dt = bancoControle.ExecuteReader(comando);
            CEPColecao colecao = new CEPColecao();
            foreach (DataRow dr in dt.Rows)
            {
                CEP cep = new CEP();
                cep.Cod_cep = Convert.ToUInt32(dr["cod_cep"]);
                cep.Bairro = Convert.ToString(dr["bairro"]);
                cep.Uf = Convert.ToString(dr["uf"]);
                cep.Cidade = Convert.ToString(dr["cidade"]);
                cep.Cep = Convert.ToString(dr["cep"]);
                cep.Logra = Convert.ToString(dr["logra"]);
                colecao.Add(cep);
            }
            dt.Dispose();
            return colecao;
        }

        public short ContadorCEP(CEP cep)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@cep", cep.Cep);
            bancoControle.AdicionaParametro("@codigo", cep.Cod_cep);
            string comando = "SELECT COUNT(cod_cep) FROM tb_cep WHERE cep = @cep AND cod_cep <> @codigo;";
            object retorno = bancoControle.ExecuteScalarSemTransacao(comando);
            return Convert.ToInt16(retorno);
        }
    }
}
