using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Enums
{
    public enum Status
    {
        [Description("Aberto")]
        Aberto = 0,
        [Description("Sem Reparo")]
        SemReparo = 1,
        [Description("Consertado")]
        Consertado = 2,
        [Description("Devolução")]
        Devolvido = 3,
        [Description("Pago e Retirado")]
        Retirado = 4
    }
}
