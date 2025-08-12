using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderReport.Interfaces
{
    public interface ISeccion
    {
        string Nombre { get; }
        void AgregarSeccion();
    }
}