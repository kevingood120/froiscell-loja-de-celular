using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Totalizadores
    {
        public decimal Total { get; set; } = 0;
        public decimal TotalDesconto { get; set; } = 0;
        public decimal TotalDebito { get; set; } = 0;
        public decimal TotalDinheiro { get; set; } = 0;
        public decimal TotalCredito { get; set; } = 0;
        public decimal TotalOS { get; set; } = 0;
        public decimal TotalVenda { get; set; } = 0;
        public decimal DinheiroAdicionado { get; set; } = 0;
        public decimal DinheiroRemovido { get; set; } = 0;
    }
}
