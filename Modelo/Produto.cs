using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ProdutoColecao : BindingList<Produto> { }
    [Serializable]
    public class Produto : ModelBase
    {
        uint cod_produto;
        Grupo grupoSelecionado;
        decimal preco_produto;
        decimal precocusto_produto;
        short qtd_produto;
        short qtdmin_produto;
        string desc_produto;
        string codigo_barras;

        public uint Cod_produto { get => cod_produto; set => Set(ref cod_produto, value); }
        public Grupo GrupoSelecionado
        {
            get
            {
                if (grupoSelecionado == null)
                    grupoSelecionado = new Grupo();
                return grupoSelecionado;
            }
            set => Set(ref grupoSelecionado, value);
        }
        public decimal Preco_produto { get => preco_produto; set => Set(ref preco_produto, value); }
        public decimal Precocusto_produto { get => precocusto_produto; set => Set(ref precocusto_produto, value); }
        public short Qtd_produto { get => qtd_produto; set => Set(ref qtd_produto, value); }
        public short Qtdmin_produto { get => qtdmin_produto; set => Set(ref qtdmin_produto, value); }
        public string Desc_produto { get => desc_produto; set => Set(ref desc_produto, value); }
        public string Codigo_barras { get => codigo_barras; set => Set(ref codigo_barras, value); }
    }
}
