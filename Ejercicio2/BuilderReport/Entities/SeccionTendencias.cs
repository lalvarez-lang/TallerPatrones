using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderReport.Interfaces;

namespace BuilderReport.Entities
{
    public class SeccionTendencias : ISeccion
    {
        public string Analisis { get; }
        public string Nombre => "Análisis de tendencias";

        public SeccionTendencias(string analisis)
        {
            Analisis = analisis ?? string.Empty;
        }

        public void AgregarSeccion()
        {
            Console.WriteLine("Se agrego analisis de tendencias...");
        }
    }
}