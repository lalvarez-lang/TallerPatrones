using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderReport.Reports;

namespace BuilderReport.Interfaces
{
    public interface IReporteBuilder
    {
        IReporteBuilder ConGraficos(IEnumerable<string> graficos);
        IReporteBuilder ConTablaMovimientos(IEnumerable<string> movimientos);
        IReporteBuilder ConAnalisisTendencias(string analisis);
        IReporteBuilder ConPieDePagina(string contactoAsesor);
        IReporteBuilder ConSeccionPersonalizada(ISeccion seccion);
        ReportePDF Build();
    }
}