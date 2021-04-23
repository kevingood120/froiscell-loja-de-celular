using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClienteColecao : BindingList<Cliente> {}
    [Serializable]
    public class Cliente : ModelBase
    {
        uint cod_cliente;
        CEP cepSelecionado;
        string nome_cliente;
        string tel_cliente;
        string cel_cliente;
        string telcom_cliente;
        string cpf_cliente;
        string rg_cliente;
        string email_cliente;
        string num_cliente;
        string comp_cliente;

        public string Endereco_cliente => CepSelecionado.Logra == null ? null : string.Format("{0}, {1}", CepSelecionado.Logra, Num_cliente);
        public uint Cod_cliente { get => cod_cliente; set => Set(ref cod_cliente, value); }
        public CEP CepSelecionado
        {
            get
            {
                if (cepSelecionado == null)
                    cepSelecionado = new CEP();
                return cepSelecionado;
            }
            set
            {
                Set(ref cepSelecionado, value);
            }
        }
        public string Nome_cliente { get => nome_cliente; set => Set(ref nome_cliente, value); }
        public string Tel_cliente { get => tel_cliente; set => Set(ref tel_cliente, value); }
        public string Cel_cliente { get => cel_cliente; set => Set(ref cel_cliente, value); }
        public string Telcom_cliente { get => telcom_cliente; set => Set(ref telcom_cliente, value); }
        public string Cpf_cliente { get => cpf_cliente; set => Set(ref cpf_cliente, value); }
        public string Rg_cliente { get => rg_cliente; set => Set(ref rg_cliente, value); }
        public string Email_cliente { get => email_cliente; set => Set(ref email_cliente, value); }
        public string Num_cliente { get => num_cliente; set => Set(ref num_cliente, value); }
        public string Comp_cliente { get => comp_cliente; set => Set(ref comp_cliente, value); }
    }
}
