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
            double descuentos = 0;
            bool tieneDigital = paquete.TieneAdicional(Adicionales.Digital);
            if (tieneDigital)
            {
                descuentos = descuentos +(CostoBase * 0.55);
            }
            if(paquete is Premium)
            {
                descuentos = descuentos + (Zona.PrecioDigital * 0.75) + (Zona.PrecioInternet * 0.25);
            }
            return descuentos;
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
