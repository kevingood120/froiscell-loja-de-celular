using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ItemVendaColecao : BindingList<ItemVenda> { }
    [Serializable]
    public class ItemVenda : ModelBase
    {
        Produto produtoSelecionado;
        short quantidade;
        decimal subtotal;

        public Produto ProdutoSelecionado
        {
            get
            {
                if (produtoSelecionado == null)
                    produtoSelecionado = new Produto();
                return produtoSelecionado;
            }
            set => Set(ref produtoSelecionado, value);
        }
        public short Quantidade { get => quantidade; set => Set(ref quantidade, value); }
        public decimal Subtotal { get => subtotal; set => Set(ref subtotal, value); }
    }
}
