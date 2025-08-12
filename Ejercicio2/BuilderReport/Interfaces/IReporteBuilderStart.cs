using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderReport.Interfaces
{
    public interface IReporteBuilderStart
    {
        IReporteBuilder ObligatorioConPortada(string nombreCliente, byte[] logo);
    }
}