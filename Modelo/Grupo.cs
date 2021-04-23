using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class GrupoColecao : BindingList<Grupo> { }
    [Serializable]
    public class Grupo : ModelBase
    {
        int cod_grupo;
        string nome_grupo;

        public int Cod_grupo { get => cod_grupo; set => Set(ref cod_grupo, value); }
        public string Nome_grupo { get => nome_grupo; set => Set(ref nome_grupo, value); }
    }
}
