﻿using Examen.CableTV.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.CableTV
{
   public  class TeleCable : IProveedor
    {
        public double CostoBase { get { return 10000; } }

        public string Nombre { get; }

        public Zona Zona { get; set; }

        public double AplicarDescuentos(Paquete paquete)
        {
            return 0;
        }

        public double CostoSegunCantidad(int cantidadTV)
        {
            return 0;
        }

        public double ObtenerCosto()
        {
            return 0;
        }
    }
}
