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
            double descuento = 0;
            bool tieneDigital = paquete.TieneAdicional(Adicionales.Digital);
            if (paquete is Premium)
            {
               descuento = this.CostoSegunCantidad(paquete.CantidadTv);
            }
            if (tieneDigital)
            {
                descuento =+ this.CostoBase * 0.50;
            }
            return descuento;
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

            double total = this.CostoBase + this.Zona.PrecioTV;
            

            return total;
        }
    }
}
