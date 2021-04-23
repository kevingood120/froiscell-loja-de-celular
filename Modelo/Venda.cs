using System;
using Modelo.Enums;
using System.ComponentModel;

namespace Modelo
{
    public class VendaColecao : BindingList<Venda> { }
    [Serializable]
    public class Venda : ModelBase, IPendente
    {
        uint cod_venda;
        Cliente clienteSelecionado;
        decimal total_venda;
        string obs_venda;
        ItemVendaColecao itens;
        PagamentoColecao pagamentoColecao;
        DateTime reg_venda;

        public uint Cod_venda { get => cod_venda; set => Set(ref cod_venda, value); }
        public DateTime Reg_venda { get => reg_venda; set => Set(ref reg_venda, value); }
        public decimal Total_venda { get => total_venda; set => Set(ref total_venda, value); }
        public string Obs_venda { get => obs_venda; set => Set(ref obs_venda, value); }
        public ItemVendaColecao Itens
        {
            get
            {
                if (itens == null)
                    itens = new ItemVendaColecao();
                return itens;
            }
            set => Set(ref itens, value);
        }
        public PagamentoColecao PagamentoColecao
        {
            get
            {
                if (pagamentoColecao == null)
                    pagamentoColecao = new PagamentoColecao();
                return pagamentoColecao;
            }
            set
            {
                Set(ref pagamentoColecao, value);
            }
        }
        public Cliente ClienteSelecionado
        {
            get
            {
                if (clienteSelecionado == null)
                    clienteSelecionado = new Cliente();
                return clienteSelecionado;
            }
            set => Set(ref clienteSelecionado, value);
        }

        #region IPendente
        DateTime IPendente.Entrada => Reg_venda;
        uint IPendente.Codigo => Cod_venda;

        decimal IPendente.Valor => Total_venda;

        string IPendente.Observacao => Obs_venda;
        PagamentoColecao IPendente.PagamentosColecao => PagamentoColecao;
        #endregion
    }
}
