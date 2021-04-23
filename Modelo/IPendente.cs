using Modelo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{ 
    public interface IPendente
    {
        uint Codigo { get; }
        decimal Valor { get; }
        Cliente ClienteSelecionado { get; }
        string Observacao { get; }
        PagamentoColecao PagamentosColecao { get; }
        DateTime Entrada { get; }
    }
}
