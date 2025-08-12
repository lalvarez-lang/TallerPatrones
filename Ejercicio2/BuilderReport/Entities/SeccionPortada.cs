using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderReport.Interfaces;

namespace BuilderReport.Entities
{
    public class SeccionPortada : ISeccion
    {
        public string NombreCliente { get; }
        public byte[] Logo { get; }
        public string Nombre => "Portada";


        public SeccionPortada(string nombreCliente, byte[] logo)
        {
            NombreCliente = !string.IsNullOrWhiteSpace(nombreCliente)
                ? nombreCliente : throw new ArgumentException("El nombre del cliente es obligatorio.");
            Logo = logo ?? Array.Empty<byte>();
        }

        public void AgregarSeccion()
        {
            Console.WriteLine("Se agrego la portada...");
        }
    }
}