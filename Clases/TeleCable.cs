using Examen.CableTV.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV
{
   public  class TeleCable : IProveedor
    {
        public double CostoBase { get { return 10000; } }

        public string Nombre { get; }

        public Zona Zona { get; set;}

        public double AplicarDescuentos(Paquete paquete)
        {

            bool tieneDigital = paquete.TieneAdicional(Adicionales.Digital);
            if (paquete is Premium)
            {
                int cant = 0;
               return this.CostoSegunCantidad(cant);
            }
            if (tieneDigital)
            {
                return this.CostoBase * 0.5;
            }
            return 0;
        }

        public double CostoSegunCantidad(int cantidadTV)
        {
            if (cantidadTV >= 3)
            {
                return 500 * cantidadTV;
            }
            if (cantidadTV >= 4 && cantidadTV <= 5)
            {
                return 450 * cantidadTV;
            }
            else
            {
                return 400 * cantidadTV;
            }
        }

        public double ObtenerCosto()
        {
            return 0;
        }
    }
}
