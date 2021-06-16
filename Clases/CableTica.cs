using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV.Clases
{
   public class CableTica : IProveedor
    {
        public double CostoBase { get; set; }

        public string Nombre { get; set; }

        public Zona Zona { get; set; }

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
