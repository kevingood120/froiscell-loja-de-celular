using Modelo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class OSColecao : BindingList<OS> { }

    [Serializable]
    public class OS : ModelBase, IPendente
    {
        uint cod_ordem;
        Cliente clienteSelecionado;
        Aparelho aparelhoSelecionado;
        Cor corSelecionada;
        bool tampa;
        bool bateria;
        bool cartaosd;
        bool capa;
        bool cartaosim;
        string imei1_aparelho;
        string imei2_aparelho;
        string rec_aparelho;
        string obs_aparelho;
        string orc_descricao;
        decimal orc_preco;
        DateTime reg_entrada;
        DateTime? reg_saida;
        Status statusSelecionado;
        PagamentoColecao pagamentoColecao;

        public Cliente ClienteSelecionado
        {
            get
            {
                if (clienteSelecionado == null)
                    clienteSelecionado = new Cliente();
                return clienteSelecionado;
            }
            set
            {
                Set(ref clienteSelecionado, value);
            }
        }

        public Aparelho AparelhoSelecionado
        {
            get
            {
                if (aparelhoSelecionado == null)
                    aparelhoSelecionado = new Aparelho();
                return aparelhoSelecionado;
            }
            set
            {
                Set(ref aparelhoSelecionado, value);
            }
        }
        public Cor CorSelecionada
        {
            get
            {
                if (corSelecionada == null)
                    corSelecionada = new Cor();
                return corSelecionada;
            }
            set
            {
                Set(ref corSelecionada, value);
            }
        }
        public bool Tampa { get => tampa; set => Set(ref tampa, value); }
        public bool Bateria { get => bateria; set => Set(ref bateria, value); }
        public bool Cartaosd { get => cartaosd; set => Set(ref cartaosd, value); }
        public bool Capa { get => capa; set => Set(ref capa, value); }
        public bool Cartaosim { get => cartaosim; set => Set(ref cartaosim, value); }
        public string Imei1_aparelho { get => imei1_aparelho; set => Set(ref imei1_aparelho, value); }
        public string Imei2_aparelho { get => imei2_aparelho; set => Set(ref imei2_aparelho, value); }
        public string Rec_aparelho { get => rec_aparelho; set => Set(ref rec_aparelho, value); }
        public string Obs_aparelho { get => obs_aparelho; set => Set(ref obs_aparelho, value); }
        public string Orc_descricao { get => orc_descricao; set => Set(ref orc_descricao, value); }
        public decimal Orc_preco { get => orc_preco; set => Set(ref orc_preco, value); }
        public DateTime Reg_entrada { get => reg_entrada; set => Set(ref reg_entrada, value); }
        public DateTime? Reg_saida { get => reg_saida; set => Set(ref reg_saida, value); }
        public uint Cod_ordem { get => cod_ordem; set => cod_ordem = value; }
        public Status StatusSelecionado { get => statusSelecionado; set => Set(ref statusSelecionado, value); }
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

        #region IPendende
        uint IPendente.Codigo => Cod_ordem;

        decimal IPendente.Valor => Orc_preco;

        DateTime IPendente.Entrada => Reg_entrada;


        string IPendente.Observacao => Rec_aparelho;

        PagamentoColecao IPendente.PagamentosColecao => PagamentoColecao;
        #endregion
    }
}
