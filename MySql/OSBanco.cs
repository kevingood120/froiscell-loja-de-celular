using Modelo;
using Modelo.Enums;
using System;
using System.Data;

namespace MySql
{
    public class OSBanco
    {
        MySqlController bancoControle = new MySqlController();

        public void InserirOS(OS ordem)
        {
            try
            {
                bancoControle.LimpaParametros();
                bancoControle.AdicionaParametro("@cod_cliente", ordem.ClienteSelecionado.Cod_cliente);
                bancoControle.AdicionaParametro("@cod_aparelho", ordem.AparelhoSelecionado.Cod_aparelho);
                bancoControle.AdicionaParametro("@cod_cor", ordem.CorSelecionada.Cod_cor);
                bancoControle.AdicionaParametro("@tampa", ordem.Tampa);
                bancoControle.AdicionaParametro("@bateria", ordem.Bateria);
                bancoControle.AdicionaParametro("@cartaosd", ordem.Cartaosd);
                bancoControle.AdicionaParametro("@capa", ordem.Capa);
                bancoControle.AdicionaParametro("@cartaosim", ordem.Cartaosim);
                bancoControle.AdicionaParametro("@imei1_aparelho", ordem.Imei1_aparelho);
                bancoControle.AdicionaParametro("@imei2_aparelho", ordem.Imei2_aparelho);
                bancoControle.AdicionaParametro("@rec_aparelho", ordem.Rec_aparelho);
                bancoControle.AdicionaParametro("@obs_aparelho", ordem.Obs_aparelho);
                bancoControle.AdicionaParametro("@orc_descricao", ordem.Orc_descricao);
                bancoControle.AdicionaParametro("@orc_preco", ordem.Orc_preco);
                bancoControle.AdicionaParametro("@status", ordem.StatusSelecionado);
                string comando = "INSERT INTO tb_ordemservico VALUES (NULL,@cod_cliente,@cod_aparelho,@cod_cor," +
                    "@tampa,@bateria,@cartaosd,@capa,@cartaosim,@imei1_aparelho,@imei2_aparelho,@rec_aparelho,@obs_aparelho," +
                    "@orc_descricao,@orc_preco,NOW(),NULL,@status);";
                ordem.Cod_ordem = bancoControle.ExecuteNonQuery(comando);
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

        public void InserirPagamentosOS(OS os)
        {
            foreach (var pagamento in os.PagamentoColecao)
            {
                bancoControle.LimpaParametros();
                bancoControle.AdicionaParametro("@codigo", os.Cod_ordem);
                bancoControle.AdicionaParametro("@pagamento", pagamento.PagamentoSelecionado);
                bancoControle.AdicionaParametro("@valor", pagamento.Valor);
                bancoControle.AdicionaParametro("@vezes", pagamento.Vezes);
                string comando = "INSERT INTO tb_pagamento_ordem VALUES(@codigo,@pagamento,@valor,@vezes);";
                bancoControle.ExecuteNonQuery(comando);
            }
        }

        public OS ImprimirCupom(uint codigo)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@codigo", codigo);
            DataTable dt = bancoControle.ExecuteReader("sp_imprimirCupomOS", CommandType.StoredProcedure);
            OS os = null;
            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                os = new OS();
                os.ClienteSelecionado.Nome_cliente = Convert.ToString(dr["nome_cliente"]);
                os.ClienteSelecionado.Cpf_cliente = Convert.ToString(dr["cpf_cliente"]);
                os.Cod_ordem = Convert.ToUInt32(dr["cod_ordem"]);
                os.CorSelecionada.Nome_cor = Convert.ToString(dr["cor"]);
                os.Rec_aparelho = Convert.ToString(dr["rec_aparelho"]);
                os.Orc_descricao = Convert.ToString(dr["orc_descricao"]);
                os.Reg_entrada = Convert.ToDateTime(dr["reg_entrada"]);
                os.Reg_saida = Convert.ToDateTime(dr["reg_saida"]);
                os.AparelhoSelecionado.Modelo_aparelho = Convert.ToString(dr["modelo_aparelho"]);
                os.AparelhoSelecionado.TipoSelecionado = (Modelo.Enums.Aparelhos)Enum.Parse(typeof(Aparelhos), Convert.ToString(dr["tipo_aparelho"]));
                os.AparelhoSelecionado.MarcaSelecionada.Nome_marca = Convert.ToString(dr["marca"]);
                os.PagamentoColecao = PegarPagamentoOS(os.Cod_ordem);
                os.Orc_preco = os.PagamentoColecao.Total;
                dt.Dispose();
            }
            dt.Dispose();
            return os;
        }
        
        public PagamentoColecao PegarPagamentoOS(uint codigo)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@codigo", codigo);
            PagamentoColecao colecao = new PagamentoColecao();
            string comando = "SELECT tipo_pagamento,pgto,credito_vezes FROM tb_pagamento_ordem WHERE cod_ordem = @codigo";
            DataTable dt = bancoControle.ExecuteReader(comando);
            foreach (DataRow row in dt.Rows)
            {
                Pagamento pgto = new Pagamento()
                {
                    PagamentoSelecionado = (Pagamentos)Enum.Parse(typeof(Pagamentos), Convert.ToString(row["tipo_pagamento"])),
                    Valor = Convert.ToDecimal(row["pgto"]),
                    Vezes = row["credito_vezes"] == DBNull.Value ? (byte?)null : Convert.ToByte(row["credito_vezes"])
                };
                colecao.Add(pgto);
            }
            return colecao;
        }

        public void AlterarOS(OS ordem, bool pagamento)
        {
            try
            {
                bancoControle.LimpaParametros();
                bancoControle.AdicionaParametro("@observacao", ordem.Obs_aparelho);
                bancoControle.AdicionaParametro("@codigo", ordem.Cod_ordem);
                bancoControle.AdicionaParametro("@descricao", ordem.Orc_descricao);
                bancoControle.AdicionaParametro("@valor", ordem.Orc_preco);
                bancoControle.AdicionaParametro("@statusos", ordem.StatusSelecionado);
                bancoControle.ExecuteNonQuery("UPDATE tb_ordemservico " +
                    "SET obs_aparelho = @observacao, " +
                    "orc_descricao = @descricao, " +
                    "orc_preco = @valor, " +
                    "status_os = @statusos " +
                    "WHERE cod_ordem = @codigo;");
                if (pagamento)
                    InserirPagamentosOS(ordem);
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

        public OS PesquisarPorCodigo(uint codigo)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@codigo", codigo);
            DataTable dt = bancoControle.ExecuteReader("sp_pesquisarCodigoOS", CommandType.StoredProcedure);
            OS os = null;
            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                os = new OS();
                os.ClienteSelecionado.Nome_cliente = Convert.ToString(dr["nome_cliente"]);
                os.Cod_ordem = Convert.ToUInt32(dr["cod_ordem"]);
                os.ClienteSelecionado.Cod_cliente = Convert.ToUInt32(dr["cod_cliente"]);
                os.AparelhoSelecionado.Cod_aparelho = Convert.ToUInt32(dr["cod_aparelho"]);
                os.CorSelecionada.Nome_cor = Convert.ToString(dr["cor"]);
                os.Tampa = Convert.ToBoolean(dr["tampa"]);
                os.Reg_saida = bancoControle.CampoNulo<DateTime?>(dr["reg_saida"]);
                os.Bateria = Convert.ToBoolean(dr["bateria"]);
                os.Cartaosd = Convert.ToBoolean(dr["cartaosd"]);
                os.Capa = Convert.ToBoolean(dr["capa"]);
                os.Cartaosim = Convert.ToBoolean(dr["cartaosim"]);
                os.Imei1_aparelho = Convert.ToString(dr["imei1_aparelho"]);
                os.Imei2_aparelho = Convert.ToString(dr["imei2_aparelho"]);
                os.Rec_aparelho = Convert.ToString(dr["rec_aparelho"]);
                os.Obs_aparelho = Convert.ToString(dr["obs_aparelho"]);
                os.Orc_descricao = Convert.ToString(dr["orc_descricao"]);
                os.Orc_preco = Convert.ToDecimal(dr["orc_preco"]);
                os.Reg_entrada = Convert.ToDateTime(dr["reg_entrada"]);
                os.StatusSelecionado = (Status)Enum.Parse(typeof(Status), dr["status_os"].ToString());
                os.AparelhoSelecionado.Modelo_aparelho = Convert.ToString(dr["modelo_aparelho"]);
                os.AparelhoSelecionado.TipoSelecionado = (Modelo.Enums.Aparelhos)Enum.Parse(typeof(Aparelhos), dr["tipo_aparelho"].ToString());
                os.AparelhoSelecionado.MarcaSelecionada.Cod_marca = Convert.ToInt32(dr["cod_marca"]);
                os.CorSelecionada.Cod_cor = Convert.ToSByte(dr["cod_cor"]);
                os.AparelhoSelecionado.MarcaSelecionada.Nome_marca = Convert.ToString(dr["marca"]);
            }
            dt.Dispose();
            return os;
        }

        public OS ImprimirFolha(uint codigo)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@codigo", codigo);
            DataTable dt = bancoControle.ExecuteReader("sp_folhaOS", CommandType.StoredProcedure);
            OS ordem = null;
            if(dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                ordem = new OS();
                ordem.Cod_ordem = Convert.ToUInt32(dr["cod_ordem"]);
                ordem.Bateria = Convert.ToBoolean(dr["bateria"]);
                ordem.Capa = Convert.ToBoolean(dr["capa"]);
                ordem.Cartaosd = Convert.ToBoolean(dr["Cartaosd"]);
                ordem.Cartaosim = Convert.ToBoolean(dr["cartaosim"]);
                ordem.ClienteSelecionado.Cel_cliente = Convert.ToString(dr["cel_cliente"]);
                ordem.ClienteSelecionado.Comp_cliente = Convert.ToString(dr["comp_cliente"]);
                ordem.ClienteSelecionado.Cpf_cliente = Convert.ToString(dr["cpf_cliente"]);
                ordem.ClienteSelecionado.Email_cliente = Convert.ToString(dr["email_cliente"]);
                ordem.ClienteSelecionado.Nome_cliente = Convert.ToString(dr["nome_cliente"]);
                ordem.ClienteSelecionado.Num_cliente = Convert.ToString(dr["num_cliente"]);
                ordem.ClienteSelecionado.Rg_cliente = Convert.ToString(dr["rg_cliente"]);
                ordem.ClienteSelecionado.Telcom_cliente = Convert.ToString(dr["telcom_cliente"]);
                ordem.ClienteSelecionado.Tel_cliente = Convert.ToString(dr["tel_cliente"]);
                if (!dr["cod_cep"].Equals(DBNull.Value))
                {
                    ordem.ClienteSelecionado.CepSelecionado.Bairro = Convert.ToString(dr["bairro"]);
                    ordem.ClienteSelecionado.CepSelecionado.Cep = Convert.ToString(dr["cep"]);
                    ordem.ClienteSelecionado.CepSelecionado.Cidade = Convert.ToString(dr["cidade"]);
                    ordem.ClienteSelecionado.CepSelecionado.Logra = Convert.ToString(dr["logra"]);
                    ordem.ClienteSelecionado.CepSelecionado.Uf = Convert.ToString(dr["uf"]);
                }
                ordem.AparelhoSelecionado.MarcaSelecionada.Nome_marca = Convert.ToString(dr["marca"]);
                ordem.AparelhoSelecionado.Modelo_aparelho = Convert.ToString(dr["modelo_aparelho"]);
                ordem.AparelhoSelecionado.TipoSelecionado = (Aparelhos)Enum.Parse(typeof(Aparelhos), dr["tipo_aparelho"].ToString());
                ordem.CorSelecionada.Nome_cor = Convert.ToString(dr["cor"]);
                ordem.Imei1_aparelho = Convert.ToString(dr["imei1_aparelho"]);
                ordem.Imei2_aparelho = Convert.ToString(dr["imei2_aparelho"]);
                ordem.Obs_aparelho = Convert.ToString(dr["obs_aparelho"]);
                ordem.Orc_descricao = Convert.ToString(dr["orc_descricao"]);
                ordem.Orc_preco = Convert.ToDecimal(dr["orc_preco"]);
                ordem.Rec_aparelho = Convert.ToString(dr["rec_aparelho"]);
                ordem.Reg_entrada = Convert.ToDateTime(dr["reg_entrada"]);
                ordem.Tampa = Convert.ToBoolean(dr["tampa"]);
            }
            dt.Dispose();
            return ordem;
        }

        public OSColecao PesquisarPorCliente(string nome)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@nome", nome);
            DataTable dt = bancoControle.ExecuteReader("sp_pesquisarNomeOS", CommandType.StoredProcedure);
            OSColecao colecao = new OSColecao();
            foreach(DataRow dr in dt.Rows)
            {
                OS os = new OS();
                os.ClienteSelecionado.Nome_cliente = Convert.ToString(dr["nome_cliente"]);
                os.Cod_ordem = Convert.ToUInt32(dr["cod_ordem"]);
                os.ClienteSelecionado.Cod_cliente = Convert.ToUInt32(dr["cod_cliente"]);
                os.AparelhoSelecionado.Cod_aparelho = Convert.ToUInt32(dr["cod_aparelho"]);
                os.CorSelecionada.Nome_cor = Convert.ToString(dr["cor"]);
                os.Tampa = Convert.ToBoolean(dr["tampa"]);
                os.Reg_saida = bancoControle.CampoNulo<DateTime?>(dr["reg_saida"]);
                os.Bateria = Convert.ToBoolean(dr["bateria"]);
                os.Cartaosd = Convert.ToBoolean(dr["cartaosd"]);
                os.Capa = Convert.ToBoolean(dr["capa"]);
                os.Cartaosim = Convert.ToBoolean(dr["cartaosim"]);
                os.Imei1_aparelho = Convert.ToString(dr["imei1_aparelho"]);
                os.Imei2_aparelho = Convert.ToString(dr["imei2_aparelho"]);
                os.Rec_aparelho = Convert.ToString(dr["rec_aparelho"]);
                os.Obs_aparelho = Convert.ToString(dr["obs_aparelho"]);
                os.Orc_descricao = Convert.ToString(dr["orc_descricao"]);
                os.Orc_preco = Convert.ToDecimal(dr["orc_preco"]);
                os.Reg_entrada = Convert.ToDateTime(dr["reg_entrada"]);
                os.StatusSelecionado = (Status)Enum.Parse(typeof(Status), dr["status_os"].ToString());
                os.AparelhoSelecionado.Modelo_aparelho = Convert.ToString(dr["modelo_aparelho"]);
                os.AparelhoSelecionado.TipoSelecionado = (Modelo.Enums.Aparelhos)Enum.Parse(typeof(Aparelhos), dr["tipo_aparelho"].ToString());
                os.AparelhoSelecionado.MarcaSelecionada.Cod_marca = Convert.ToInt32(dr["cod_marca"]);
                os.CorSelecionada.Cod_cor = Convert.ToSByte(dr["cod_cor"]);
                os.AparelhoSelecionado.MarcaSelecionada.Nome_marca = Convert.ToString(dr["marca"]);
                colecao.Add(os);
            }
            dt.Dispose();
            return colecao;
        }

        public OSColecao PesquisarPorClienteStatus(string nome, Status status)
        {
            bancoControle.LimpaParametros();
            bancoControle.AdicionaParametro("@nome", nome);
            bancoControle.AdicionaParametro("@status_os", status);
            DataTable dt = bancoControle.ExecuteReader("sp_pesquisarNomeStatusOS", CommandType.StoredProcedure);
            OSColecao colecao = new OSColecao();
            foreach (DataRow dr in dt.Rows)
            {
                OS os = new OS();
                os.ClienteSelecionado.Nome_cliente = Convert.ToString(dr["nome_cliente"]);
                os.Cod_ordem = Convert.ToUInt32(dr["cod_ordem"]);
                os.ClienteSelecionado.Cod_cliente = Convert.ToUInt32(dr["cod_cliente"]);
                os.AparelhoSelecionado.Cod_aparelho = Convert.ToUInt32(dr["cod_aparelho"]);
                os.CorSelecionada.Nome_cor = Convert.ToString(dr["cor"]);
                os.Tampa = Convert.ToBoolean(dr["tampa"]);
                os.Reg_saida = bancoControle.CampoNulo<DateTime?>(dr["reg_saida"]);
                os.Bateria = Convert.ToBoolean(dr["bateria"]);
                os.Cartaosd = Convert.ToBoolean(dr["cartaosd"]);
                os.Capa = Convert.ToBoolean(dr["capa"]);
                os.Cartaosim = Convert.ToBoolean(dr["cartaosim"]);
                os.Imei1_aparelho = Convert.ToString(dr["imei1_aparelho"]);
                os.Imei2_aparelho = Convert.ToString(dr["imei2_aparelho"]);
                os.Rec_aparelho = Convert.ToString(dr["rec_aparelho"]);
                os.Obs_aparelho = Convert.ToString(dr["obs_aparelho"]);
                os.Orc_descricao = Convert.ToString(dr["orc_descricao"]);
                os.Orc_preco = Convert.ToDecimal(dr["orc_preco"]);
                os.Reg_entrada = Convert.ToDateTime(dr["reg_entrada"]);
                os.StatusSelecionado = (Status)Enum.Parse(typeof(Status), dr["status_os"].ToString());
                os.AparelhoSelecionado.Modelo_aparelho = Convert.ToString(dr["modelo_aparelho"]);
                os.AparelhoSelecionado.TipoSelecionado = (Modelo.Enums.Aparelhos)Enum.Parse(typeof(Aparelhos), dr["tipo_aparelho"].ToString());
                os.AparelhoSelecionado.MarcaSelecionada.Cod_marca = Convert.ToInt32(dr["cod_marca"]);
                os.CorSelecionada.Cod_cor = Convert.ToSByte(dr["cod_cor"]);
                os.AparelhoSelecionado.MarcaSelecionada.Nome_marca = Convert.ToString(dr["marca"]);
                colecao.Add(os);
            }
            dt.Dispose();
            return colecao;
        }
    }
}
