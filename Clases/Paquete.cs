using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV.Clases
{
     public abstract class Paquete
    {

        int CantidadTv { get; set; }
       public abstract String Descripcion { get; }
        List<Adicionales> ListaAdicionales { get; set; }
        public abstract float PorsentajeCosto { get; }
        public abstract float PorsentajeImpuesto { get; }


        public void AgregarAdicional(Adicionales adicional)
        {
            ListaAdicionales.Add(adicional);

        }
        public double CostoAdicionales(Zona zona)
        {
            double costos=0;
            switch (zona.Nombre)
            {
                case "Brunca":
                    costos = zona.PrecioDigital + zona.PrecioInternet + zona.PrecioTelefono;
                    break;
                case "Central":
                    costos= zona.PrecioDigital + zona.PrecioInternet + zona.PrecioTelefono;
                    break;
                case "Huetar":
                    costos = zona.PrecioDigital + zona.PrecioInternet + zona.PrecioTelefono;
                    break;
                case "GAM":
                    costos = zona.PrecioDigital + zona.PrecioInternet + zona.PrecioTelefono;
                    break;
                case "Zona Sur":
                    costos = zona.PrecioDigital + zona.PrecioInternet + zona.PrecioTelefono;
                    break;
                case "Zona Norte":
                    costos = zona.PrecioDigital + zona.PrecioInternet + zona.PrecioTelefono;
                    break;
                case "Valle Central":
                    costos = zona.PrecioDigital + zona.PrecioInternet + zona.PrecioTelefono;
                    break;
                case "Atlántico":
                    costos = zona.PrecioDigital + zona.PrecioInternet + zona.PrecioTelefono;
                    break;
                case "Pacífico":
                    costos = zona.PrecioDigital + zona.PrecioInternet + zona.PrecioTelefono;
                    break;
            }

            return costos;
        }

        public bool TieneAdicional(Adicionales adicional)
        {
            bool tiene = false;

            foreach (var item in this.ListaAdicionales)
            {
                if (item ==adicional )
                {
                    tiene = true;
                    break;
                }
                

            }

            return tiene;
        }


    }
}
