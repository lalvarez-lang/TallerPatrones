using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderReport.Interfaces;

namespace BuilderReport.Entities
{
    public class SeccionGraficos: ISeccion
    {
        public IEnumerable<string> Graficos { get; }
        public string Nombre => "Gráficos";

        public SeccionGraficos(IEnumerable<string> graficos)
        {
            Graficos = graficos ?? Array.Empty<string>();
        }

        public void AgregarSeccion() 
        {
            Console.WriteLine("Se agregaron graficos...");
        }
    }
}