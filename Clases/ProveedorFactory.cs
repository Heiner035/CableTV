using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV.Clases
{
   public class ProveedorFactory
    {
        private static ProveedorFactory instancia = null;
        private ProveedorFactory() { } //Constructor privado

        public static ProveedorFactory Instancia {//Patron singleton
            get
            {
                if (instancia == null)
                {
                    instancia = new ProveedorFactory();
                }
                return instancia;
            }
        }

        public IProveedor factoryProveedor (bool telecable, bool cabletica, bool tigoStar)
        {
            IProveedor provedor = null;
            if (telecable == true)
            {
                provedor = new TeleCable();
            }
            if (cabletica == true)
            {
                provedor = new CableTica();
            }
            if (tigoStar == true)
            {
                provedor = new TigoStar();
            }
            return provedor;
        }

    }
}
