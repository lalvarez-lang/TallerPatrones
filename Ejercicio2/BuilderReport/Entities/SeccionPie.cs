using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderReport.Interfaces;

namespace BuilderReport.Entities
{
    public class SeccionPie : ISeccion
    {
        public string ContactoAsesor { get; }
        public string Nombre => "Pie de página";

        public SeccionPie(string contactoAsesor)
        {
            ContactoAsesor = contactoAsesor ?? string.Empty;
        }

        public void AgregarSeccion()
        {
            Console.WriteLine("Se agrego el pie de pagina...");
        }
    }
}