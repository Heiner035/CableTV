using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV.Clases
{
    public class Basico : Paquete
    {
        public override string Descripcion { get { return "Básico"; } }

        public override float PorsentajeCosto { get { return 1.055f; } }
        public override float PorsentajeImpuesto { get { return 1.013f; } }
    }
}
