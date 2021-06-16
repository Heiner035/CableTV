using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV.Clases
{
   public class Paquete
    {
        
        int CantidadTV { get;  set; }
        String Descripcion { get;  }
        List<Adicionales> ListaAdicionales { get;  set; }
        float PorcentajeCosto { get; }
        float PorcentajeImpuesto { get;  }

    }
}
