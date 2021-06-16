using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV.Clases
{
    public class Cliente
    {

        DateTime FechaNacimiento { get; set; }
        String Identificacion { get; set; }
        String Nombre { get; set; }
        Paquete Paquete{get;set;}
        IProveedor IProvedor { get;  set; }

    }
}
