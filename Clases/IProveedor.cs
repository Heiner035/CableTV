using Examen.CableTV.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV
{
  public  interface IProveedor
    {
        double CostoBase { get; }
        String Nombre { get; }
        Zona Zona { get; set; }

        double AplicarDescuentos(Paquete paquete);
        double CostoSegunCantidad(int cantidadTV);
        double ObtenerCosto();




       
    }
}
