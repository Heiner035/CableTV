using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV.Clases
{
    class Deportivo : Paquete
    {
        public override string Descripcion { get { return "Deportivo"; } }

        public override float PorsentajeCosto { get { return 1.88f; } }
        public override float PorsentajeImpuesto { get { return 1.15f; } }
    }
}
