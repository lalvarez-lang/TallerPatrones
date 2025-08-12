using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderReport.Entities;
using BuilderReport.Interfaces;

namespace BuilderReport.Reports
{
    public class ReportePdfBuilder : IReporteBuilderStart, IReporteBuilder
    {
        private string _cliente = "";
        private readonly List<ISeccion> _secciones = new();
        private bool _tienePortada = false;
        private bool _construido = false;

        private ReportePdfBuilder() { }

        public static IReporteBuilderStart Nuevo() => new ReportePdfBuilder();

        public IReporteBuilder ObligatorioConPortada(string nombreCliente, byte[] logo)
        {
            var seccion = new SeccionPortada(nombreCliente, logo);
            seccion.AgregarSeccion(); 
            _secciones.Add(seccion);  
            _cliente = seccion.NombreCliente;
            _tienePortada = true;
            return this;
        }

        public IReporteBuilder ConGraficos(IEnumerable<string> graficos)
        {
            var seccion = new SeccionGraficos(graficos);
            seccion.AgregarSeccion(); 
            _secciones.Add(seccion);    
            return this;
        }

        public IReporteBuilder ConTablaMovimientos(IEnumerable<string> movimientos)
        {
            var seccion = new SeccionMovimientos(movimientos);
            seccion.AgregarSeccion(); 
            _secciones.Add(seccion);    
            return this;
        }

        public IReporteBuilder ConAnalisisTendencias(string analisis)
        {
            var seccion = new SeccionTendencias(analisis);
            seccion.AgregarSeccion(); 
            _secciones.Add(seccion);    
            return this;
        }

        public IReporteBuilder ConPieDePagina(string contactoAsesor)
        {
            var seccion = new SeccionPie(contactoAsesor);
            seccion.AgregarSeccion(); 
            _secciones.Add(seccion);    
            return this;
        }

        public IReporteBuilder ConSeccionPersonalizada(ISeccion seccion)
        {
            if (seccion is null) throw new ArgumentNullException(nameof(seccion));
            _secciones.Add(seccion);
            return this;
        }

        public ReportePDF Build()
        {
            if (_construido) throw new InvalidOperationException("Este builder ya construyó un reporte.");
            if (!_tienePortada) throw new InvalidOperationException("El reporte debe tener una Portada.");
            if (string.IsNullOrWhiteSpace(_cliente)) throw new InvalidOperationException("El nombre del cliente es obligatorio.");

            _construido = true;
            return ReportePDF.Crear(_cliente, _secciones);
        }
    }
}