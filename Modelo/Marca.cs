using System;
using System.ComponentModel;

namespace Modelo
{
    public class MarcaColecao : BindingList<Marca> { }
    [Serializable]
    public class Marca : ModelBase
    {
        int cod_marca;
        string nome_marca;

        public int Cod_marca { get => cod_marca; set => Set(ref cod_marca, value); }
        public string Nome_marca { get => nome_marca; set => Set(ref nome_marca ,value); }
    }
}
