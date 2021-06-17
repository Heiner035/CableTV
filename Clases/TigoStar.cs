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
            bool tieneDigital = paquete.TieneAdicional(Adicionales.Digital);
            bool tieneInternet = paquete.TieneAdicional(Adicionales.Internet);
            bool tieneTelefono = paquete.TieneAdicional(Adicionales.Telefono);
            double costoBase = this.CostoBase;
            double costoTelefono = 0;
            double costoDigital = 0;
            double costoInternet = 0;
          
            
            if (tieneDigital) // si hay digital
            {
                costoBase = costoBase - (costoBase * 0.55);
                
            }
            if (paquete is Premium)//si es premium
            {

                //  costoDigital = precio guardado en zona - (precio en zona * 0.75);
                if (paquete.TieneAdicional(Adicionales.Internet))
                {
                    //costoInternet = precio guardado en zona - (precio en zona *0.25);
                }
               
            }

            double descuentoTotal = costoInternet + costoTelefono + costoDigital;
            



            return descuentoTotal;
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
