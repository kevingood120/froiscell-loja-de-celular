using Modelo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PagamentoColecao : BindingList<Pagamento>
    {
        public decimal TotalDinheiro => this.Sum(s => s.PagamentoSelecionado == Pagamentos.Dinheiro ? s.Valor : 0);
        public decimal TotalDesconto => this.Sum(s => s.PagamentoSelecionado == Pagamentos.Desconto ? s.Valor : 0);
        public decimal TotalCredito => this.Sum(s => s.PagamentoSelecionado == Pagamentos.Crédito ? s.Valor : 0);
        public decimal TotalDebito => this.Sum(s => s.PagamentoSelecionado == Pagamentos.Débito ? s.Valor : 0);
        public decimal Total => this.Sum(s => s.PagamentoSelecionado != Pagamentos.Desconto ? s.Valor : 0);
        
    }

    [Serializable]
    public class Pagamento : ModelBase
    {
        decimal valor;
        Pagamentos pagamentoSelecionado;
        byte? vezes;

        public decimal Valor { get => valor; set => Set(ref valor, value); }
        public Pagamentos PagamentoSelecionado { get => pagamentoSelecionado; set => Set(ref pagamentoSelecionado, value); }
        public byte? Vezes { get => vezes; set => Set(ref vezes, value); }
    }
}
