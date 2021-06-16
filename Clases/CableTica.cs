using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV.Clases
{
   public class CableTica : IProveedor
    {
        public double CostoBase { get { return 11000; } }
        
        public string Nombre { get;}

        public Zona Zona { get; set; }

        public double AplicarDescuentos(Paquete paquete)
        {
            return 0;
        }

        public double CostoSegunCantidad(int cantidadTV)
        {
            if (cantidadTV >= 2)
            {
                return 400 * cantidadTV;
            }
            if(cantidadTV>=3 && cantidadTV <= 5)
            {
                return 300 * cantidadTV;
            }
            else
            {
                return 250 * cantidadTV;
            }
        }

        public double ObtenerCosto()
        {
            return 0;
        }
    }
}
