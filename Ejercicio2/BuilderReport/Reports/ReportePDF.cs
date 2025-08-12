using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using BuilderReport.Interfaces;

namespace BuilderReport.Reports
{
    public class ReportePDF
    {
        public string Cliente { get; }
        public DateTime FechaGeneracion { get; }
        public IReadOnlyList<ISeccion> Secciones { get; }

        private ReportePDF(string cliente, DateTime fecha, IReadOnlyList<ISeccion> secciones)
        {
            Cliente = cliente;
            FechaGeneracion = fecha;
            Secciones = secciones;
        }

        internal static ReportePDF Crear(string cliente, List<ISeccion> secciones)
        {
            var secc = new ReadOnlyCollection<ISeccion>(new List<ISeccion>(secciones));
            return new ReportePDF(cliente, DateTime.UtcNow, secc);
        }
    }
}