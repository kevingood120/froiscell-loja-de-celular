using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql
{
    public class ClienteBanco
    {
        MySqlController controleBanco = new MySqlController();

        public void InserirCliente(Cliente cliente)
        {
            try
            {
                controleBanco.LimpaParametros();
                controleBanco.AdicionaParametro("@cod_cep", cliente.CepSelecionado.Cod_cep > 0 ? cliente.CepSelecionado.Cod_cep : (object)DBNull.Value);
                controleBanco.AdicionaParametro("@nome_cliente", cliente.Nome_cliente);
                controleBanco.AdicionaParametro("@tel_cliente", cliente.Tel_cliente);
                controleBanco.AdicionaParametro("@cel_cliente", cliente.Cel_cliente);
                controleBanco.AdicionaParametro("@telcom_cliente", cliente.Telcom_cliente);
                controleBanco.AdicionaParametro("@cpf_cliente", cliente.Cpf_cliente);
                controleBanco.AdicionaParametro("@rg_cliente", cliente.Rg_cliente);
                controleBanco.AdicionaParametro("@email_cliente", cliente.Email_cliente);
                controleBanco.AdicionaParametro("@num_cliente", cliente.Num_cliente);
                controleBanco.AdicionaParametro("@comp_cliente", cliente.Comp_cliente);
                string comando = "INSERT INTO tb_clientes VALUES (NULL,@cod_cep,@nome_cliente,@tel_cliente,@cel_cliente,@telcom_cliente,@cpf_cliente,@rg_cliente,@email_cliente,@num_cliente,@comp_cliente);";
                cliente.Cod_cliente = controleBanco.ExecuteNonQuery(comando);
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

        public void AlterarCliente(Cliente cliente)
        {
            try
            {
                controleBanco.LimpaParametros();
                controleBanco.AdicionaParametro("@cod_cliente", cliente.Cod_cliente);
                controleBanco.AdicionaParametro("@cod_cep", cliente.CepSelecionado.Cod_cep > 0 ? cliente.CepSelecionado.Cod_cep : (object)DBNull.Value);
                controleBanco.AdicionaParametro("@nome_cliente", cliente.Nome_cliente);
                controleBanco.AdicionaParametro("@tel_cliente", cliente.Tel_cliente);
                controleBanco.AdicionaParametro("@cel_cliente", cliente.Cel_cliente);
                controleBanco.AdicionaParametro("@telcom_cliente", cliente.Telcom_cliente);
                controleBanco.AdicionaParametro("@cpf_cliente", cliente.Cpf_cliente);
                controleBanco.AdicionaParametro("@rg_cliente", cliente.Rg_cliente);
                controleBanco.AdicionaParametro("@email_cliente", cliente.Email_cliente);
                controleBanco.AdicionaParametro("@num_cliente", cliente.Num_cliente);
                controleBanco.AdicionaParametro("@comp_cliente", cliente.Comp_cliente);
                string comando = "UPDATE tb_clientes " +
                                 "SET cod_cep = @cod_cep, nome_cliente = @nome_cliente, tel_cliente = @tel_cliente, cel_cliente = @cel_cliente, telcom_cliente = @telcom_cliente, cpf_cliente = @cpf_cliente, rg_cliente = @rg_cliente, email_cliente = @email_cliente, num_cliente = @num_cliente, comp_cliente = @comp_cliente " +
                                 "WHERE cod_cliente = @cod_cliente;";
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

        public ClienteColecao PesquisarCliente(string nome)
        {
            controleBanco.LimpaParametros();
            controleBanco.AdicionaParametro("@nome", nome);
            string comando = "SELECT cod_cliente,nome_cliente,cpf_cliente,rg_cliente FROM tb_clientes WHERE nome_cliente LIKE CONCAT('%',@nome,'%');";
            DataTable dt = controleBanco.ExecuteReader(comando);
            ClienteColecao colecao = new ClienteColecao();
            foreach (DataRow dr in dt.Rows)
            {
                Cliente cliente = new Cliente()
                {
                    Cod_cliente = Convert.ToUInt32(dr["cod_cliente"]),
                    Cpf_cliente = controleBanco.CampoNulo<string>(dr["cpf_cliente"]),
                    Nome_cliente = Convert.ToString(dr["nome_cliente"]),
                    Rg_cliente = controleBanco.CampoNulo<string>(dr["rg_cliente"])
                };
                colecao.Add(cliente);
            }
            dt.Dispose();
            return colecao;
        }

        public ClienteColecao PesquisarPorNome(string nome)
        {
            controleBanco.LimpaParametros();
            controleBanco.AdicionaParametro("@nome", nome);
            string comando = "select tb_clientes.cod_cliente,tb_clientes.cod_cep,tb_clientes.nome_cliente,tb_clientes.tel_cliente,tb_clientes.cel_cliente,tb_clientes.telcom_cliente,tb_clientes.cpf_cliente,tb_clientes.rg_cliente,tb_clientes.email_cliente,tb_clientes.num_cliente,tb_clientes.comp_cliente,tb_cep.cep,tb_cep.logra,tb_cep.cidade,tb_cep.uf,tb_cep.bairro " +
                             "FROM tb_clientes LEFT JOIN tb_cep " +
                             "ON tb_clientes.cod_cep = tb_cep.cod_cep " +
                             "WHERE tb_clientes.nome_cliente LIKE CONCAT('%',@nome,'%');";
            DataTable dt = controleBanco.ExecuteReader(comando);
            ClienteColecao colecao = new ClienteColecao();
            foreach (DataRow dr in dt.Rows)
            {
                Cliente cliente = new Cliente()
                {
                    Cel_cliente = controleBanco.CampoNulo<string>(dr["cel_cliente"]),
                    Cod_cliente = Convert.ToUInt32(dr["cod_cliente"]),
                    Comp_cliente = controleBanco.CampoNulo<string>(dr["comp_cliente"]),
                    Cpf_cliente = controleBanco.CampoNulo<string>(dr["cpf_cliente"]),
                    Email_cliente = controleBanco.CampoNulo<string>(dr["email_cliente"]),
                    Nome_cliente = Convert.ToString(dr["nome_cliente"]),
                    Num_cliente = controleBanco.CampoNulo<string>(dr["num_cliente"]),
                    Rg_cliente = controleBanco.CampoNulo<string>(dr["rg_cliente"]),
                    Telcom_cliente = controleBanco.CampoNulo<string>(dr["telcom_cliente"]),
                    Tel_cliente = controleBanco.CampoNulo<string>(dr["tel_cliente"])
                };
                object cep = dr["cod_cep"];
                if (!cep.Equals(DBNull.Value))
                {
                    cliente.CepSelecionado.Bairro = Convert.ToString(dr["bairro"]);
                    cliente.CepSelecionado.Cep = Convert.ToString(dr["cep"]);
                    cliente.CepSelecionado.Cidade = Convert.ToString(dr["cidade"]);
                    cliente.CepSelecionado.Cod_cep = Convert.ToUInt32(cep);
                    cliente.CepSelecionado.Logra = Convert.ToString(dr["logra"]);
                    cliente.CepSelecionado.Uf = Convert.ToString(dr["uf"]);
                }
                colecao.Add(cliente);
            }
            dt.Dispose();
            return colecao;
        }

        public Cliente PesquisarPorCodigo(uint codigo)
        {
            controleBanco.LimpaParametros();
            controleBanco.AdicionaParametro("@codigo", codigo);
            string comando = "select tb_clientes.cod_cliente,tb_clientes.cod_cep,tb_clientes.nome_cliente,tb_clientes.tel_cliente,tb_clientes.cel_cliente,tb_clientes.telcom_cliente,tb_clientes.cpf_cliente,tb_clientes.rg_cliente,tb_clientes.email_cliente,tb_clientes.num_cliente,tb_clientes.comp_cliente,tb_cep.cep,tb_cep.logra,tb_cep.cidade,tb_cep.uf,tb_cep.bairro " +
                             "FROM tb_clientes LEFT JOIN tb_cep " +
                             "ON tb_clientes.cod_cep = tb_cep.cod_cep " +
                             "WHERE tb_clientes.cod_cliente = @codigo;";
            Cliente cliente = null;
            DataTable dt = controleBanco.ExecuteReader(comando);
            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                cliente = new Cliente()
                {
                    Cel_cliente = controleBanco.CampoNulo<string>(dr["cel_cliente"]),
                    Cod_cliente = Convert.ToUInt32(dr["cod_cliente"]),
                    Comp_cliente = controleBanco.CampoNulo<string>(dr["comp_cliente"]),
                    Cpf_cliente = controleBanco.CampoNulo<string>(dr["cpf_cliente"]),
                    Email_cliente = controleBanco.CampoNulo<string>(dr["email_cliente"]),
                    Nome_cliente = Convert.ToString(dr["nome_cliente"]),
                    Num_cliente = controleBanco.CampoNulo<string>(dr["num_cliente"]),
                    Rg_cliente = controleBanco.CampoNulo<string>(dr["rg_cliente"]),
                    Telcom_cliente = controleBanco.CampoNulo<string>(dr["telcom_cliente"]),
                    Tel_cliente = controleBanco.CampoNulo<string>(dr["tel_cliente"])
                };
                object cep = dr["cod_cep"];
                if (!cep.Equals(DBNull.Value))
                {
                    cliente.CepSelecionado.Bairro = Convert.ToString(dr["bairro"]);
                    cliente.CepSelecionado.Cep = Convert.ToString(dr["cep"]);
                    cliente.CepSelecionado.Cidade = Convert.ToString(dr["cidade"]);
                    cliente.CepSelecionado.Cod_cep = Convert.ToUInt32(cep);
                    cliente.CepSelecionado.Logra = Convert.ToString(dr["logra"]);
                    cliente.CepSelecionado.Uf = Convert.ToString(dr["uf"]);
                }
            }
            dt.Dispose();
            return cliente;
        }

        public uint ContadorCPF(Cliente cliente)
        {
            controleBanco.LimpaParametros();
            controleBanco.AdicionaParametro("@cpf", cliente.Cpf_cliente);
            controleBanco.AdicionaParametro("@codigo", cliente.Cod_cliente);
            string comando = "SELECT COUNT(cod_cliente) FROM tb_clientes WHERE cpf_cliente = @cpf AND cod_cliente <> @codigo;";
            return Convert.ToUInt32(controleBanco.ExecuteScalarSemTransacao(comando));
        }
    }
}
