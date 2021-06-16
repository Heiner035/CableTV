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
            return 0;
        }

        public double CostoSegunCantidad(int cantidadTV)
        {
            return 0;
        }

        public double ObtenerCosto()
        {
            return 0;
        }
    }
}
