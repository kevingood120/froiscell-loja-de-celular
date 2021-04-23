using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CorColecao : BindingList<Cor> { }
    [Serializable]
    public class Cor : ModelBase
    {
        sbyte cod_cor;
        string nome_cor;

        public sbyte Cod_cor { get => cod_cor; set => Set(ref cod_cor, value); }
        public string Nome_cor { get => nome_cor; set => Set(ref nome_cor, value); }
    }
}
