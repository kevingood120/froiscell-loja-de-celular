using Modelo.Enums;
using System;
using System.ComponentModel;

namespace Modelo
{
    public class AparelhoColecao : BindingList<Aparelho> { }

    [Serializable]
    public class Aparelho : ModelBase
    {
        uint cod_aparelho;
        Marca marcaSelecionada;
        Aparelhos tipoSelecionado;
        string modelo_aparelho;

        public uint Cod_aparelho { get => cod_aparelho; set => Set(ref cod_aparelho, value); }
        public Marca MarcaSelecionada
        {
            get
            {
                if (marcaSelecionada == null)
                    marcaSelecionada = new Marca();
                return marcaSelecionada;
            }
            set => Set(ref marcaSelecionada, value);
        }
        public Aparelhos TipoSelecionado { get => tipoSelecionado; set => Set(ref tipoSelecionado, value); }
        public string Modelo_aparelho { get => modelo_aparelho; set => Set(ref modelo_aparelho, value); }
    }
}
