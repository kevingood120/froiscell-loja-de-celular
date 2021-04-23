using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MovimentacaoCaixa : ModelBase
    {
        uint cod_mov;
        Venda venda;
        string razao;
        decimal valor;
        DateTime data_entrada;
        bool subtrair;

        public uint Cod_mov { get => cod_mov; set => Set(ref cod_mov, value); }
        public Venda Venda { get => venda ?? (venda = new Venda()); set => Set(ref venda, value); }
        public string Razao { get => razao; set => Set(ref razao, value); }
        public bool Subtrair { get => subtrair; set => Set(ref subtrair, value); }
        public decimal Valor { get => valor; set => Set(ref valor, value); }
        public DateTime Data_entrada { get => data_entrada; set => Set(ref data_entrada, value); }
    }

    public class MovimentacaoCaixaColecao : BindingList<MovimentacaoCaixa>
    {
        public decimal DinheiroAdicionado
        {
            get
            {
                decimal acum = decimal.Zero;
                foreach(var movCaixa in this)
                {
                    if (!movCaixa.Subtrair)
                        acum += movCaixa.Valor;
                }
                return acum;
            }
        }

        public decimal DinheiroSubtraido
        {
            get
            {
                decimal acum = decimal.Zero;
                foreach (var movCaixa in this)
                {
                    if (movCaixa.Subtrair)
                        acum += movCaixa.Valor;
                }
                return acum;
            }
        }
    }
}
