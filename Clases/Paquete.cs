using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV.Clases
{
     abstract class Paquete
    {

        int CantidadTv { get; set; }
        String Descripcion { get; }
        List<Adicionales> ListaAdicionales { get; set; }
        float PorsentajeCosto { get; }
        float PorsentajeImpuesto { get; }


        public void AgregarAdicional(Adicionales adicional)
        {

        }
        public double CostoAdicionales(Zona zona)
        {
            return 0;
        }

        public bool TieneAdicional(Adicionales adicional)
        {
            bool tiene = false;
            return tiene;
        }


    }
}
