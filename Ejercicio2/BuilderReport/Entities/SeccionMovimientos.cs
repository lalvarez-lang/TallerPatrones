using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderReport.Interfaces;

namespace BuilderReport.Entities
{
    public class SeccionMovimientos : ISeccion
    {
        public IEnumerable<string> Movimientos { get; }
        public string Nombre => "Movimientos recientes";
         public SeccionMovimientos(IEnumerable<string> movimientos)
        {
            Movimientos = movimientos ?? Array.Empty<string>();
        }

        public void AgregarSeccion()
        {
            Console.WriteLine("Se agregoron movimientos recientes...");
        }
    }
}