using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class UFColecao : BindingList<UF> { }
    [Serializable]
    public class UF : ModelBase
    {
        sbyte cod_uf;
        string nome_uf;

        public sbyte Cod_uf { get => cod_uf; set => Set(ref cod_uf, value); }
        public string Nome_uf { get => nome_uf; set => Set(ref nome_uf, value); }
    }
}
