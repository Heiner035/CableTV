using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.CableTV.Clases
{
  public class Zona
    {
        String ruta;

        String Nombre { get; set; }
        Double PrecioDigital { get; set; }
        Double PrecioInternet { get; set; }
        double PrecioTV { get; set;}
        String Proveedor { get; set; }
        public List<Zona> obtenerZonas ()
        {
            List<Zona> lista= new List<Zona>();
            string ruta = Application.StartupPath + "\\Json\\Zonas.json"; //Asigna la ruta

            if (File.Exists(ruta))
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string datosJson = sr.ReadToEnd();


                    DataContractJsonSerializer oDataContractJsonSerializer = new DataContractJsonSerializer(typeof(List<Zona>));
                    MemoryStream ms = new MemoryStream(System.Text.ASCIIEncoding.UTF8.GetBytes(datosJson));


                    lista = (List<Zona>)oDataContractJsonSerializer.ReadObject(ms);
                }

            else
            {
                lista = null;
            }
            return lista;
        }

    }
}
