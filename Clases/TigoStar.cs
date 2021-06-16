using Examen.CableTV.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV
{
   public class TigoStar : IProveedor
    {
        public double CostoBase { get { return 12000; } }

        public string Nombre { get; }

        public Zona Zona { get; set; }

        public double AplicarDescuentos(Paquete paquete)
        {
            return 0;
        }

        public double CostoSegunCantidad(int cantidadTV)
        {
            if (cantidadTV >= 4)
            {
                return 450 * cantidadTV;
            }
            if (cantidadTV >= 5 && cantidadTV <= 6)
            {
                return 375 * cantidadTV;
            }
            else
            {
                return 325 * cantidadTV;
            }
            
        }

        public double ObtenerCosto()
        {
            return 0;
        }
    }
}
