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
            if (zona.Nombre.Equals(""))
            {
                
            }
         
            return 0;
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
