using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV.Clases
{
    class Basico : Paquete
    {
        public override string Descripcion { get { return "Básico"; } }

        public override float PorsentajeCosto { get { return 1.55f; } }
        public override float PorsentajeImpuesto { get { return 1.13f; } }
    }
}
