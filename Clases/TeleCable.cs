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
                int cant = 0;
               descuento+= this.CostoSegunCantidad(cant);
            }
            if (tieneDigital)
            {
                descuento =+ this.CostoBase * 0.5;
            }
            return descuento;
        }

        double cant = 0;
        public double CostoSegunCantidad(int cantidadTV)
        {
            if (cantidadTV >= 3)
            {
                cant = 500 * cantidadTV;
                return 500 * cantidadTV;
            }
            if (cantidadTV >= 4 && cantidadTV <= 5)
            {
                cant = 450 * cantidadTV;
                return 450 * cantidadTV;
            }
            else
            {
                cant = 400 * cantidadTV;
                return 400 * cantidadTV;
            }
        }

        public double ObtenerCosto()
        {

            double costoCant = cant;
            double costo = AplicarDescuentos();
            return 0;
        }
    }
}
