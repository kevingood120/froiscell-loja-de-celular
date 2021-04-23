using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CEPColecao : BindingList<CEP> { }
    [Serializable]
    public class CEP : ModelBase
    {
        uint cod_cep;
        string logra;
        string cep;
        string bairro;
        string cidade;
        string uf;

        public uint Cod_cep { get => cod_cep; set=> Set(ref cod_cep, value); }
        public string Logra { get { return logra; } set => Set(ref logra, value); }
        public string Cep { get => cep; set => Set(ref cep, value); }
        public string Bairro { get => bairro; set => Set(ref bairro, value); }
        public string Cidade { get => cidade; set => Set(ref cidade, value); }
        public string Uf { get => uf; set => Set(ref uf, value); }
    }
}
