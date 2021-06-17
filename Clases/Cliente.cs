using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV.Clases
{
    public class Cliente
    {

       public DateTime FechaNacimiento { get; set; }
       public string Identificacion { get; set; }
        public string Nombre { get; set; }
       public  Paquete Paquete{get;set;}
        public IProveedor IProvedor { get;  set; }

    }
}
