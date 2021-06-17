using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV.Clases
{
    public class Premium : Paquete
    {
        public override string Descripcion { get { return "Premium"; } }

        public override float PorsentajeCosto { get { return 1.115f; } }
        public override float PorsentajeImpuesto { get { return 1.20f; } }
    }
}
