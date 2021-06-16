using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV.Clases
{
   public class CableTica : IProveedor
    {
        public double CostoBase => throw new NotImplementedException();

        public string Nombre => throw new NotImplementedException();

        public Zona Zona { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double AplicarDescuentos(Paquete paquete)
        {
            throw new NotImplementedException();
        }

        public double CostoSegunCantidad(int cantidadTV)
        {
            throw new NotImplementedException();
        }

        public double ObtenerCosto()
        {
            throw new NotImplementedException();
        }
    }
}
