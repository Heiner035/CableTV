using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.CableTV.Clases
{
    
 [DataContract]//Se tiene que especificar los datos utilizados en la serialización
    public class Zona
    {
        string ruta = Application.StartupPath + "\\Json\\Zonas.json"; //Asigna la ruta
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public double PrecioDigital { get; set; }
        [DataMember]
        public double PrecioInternet { get; set; }
        [DataMember]
        public double PrecioTelefono { get; set; }
        public double PrecioTV { get; set;}
        [DataMember]
        public string Proveedor { get; set; }
   
        public List<Zona> obtenerZonas ()
        {
            List<Zona> lista= new List<Zona>();
           

            if (File.Exists(ruta))
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string datosJson = sr.ReadToEnd();


                    DataContractJsonSerializer oDataContractJsonSerializer = new DataContractJsonSerializer(typeof(List<Zona>)); //lee el Json
                    MemoryStream ms = new MemoryStream(System.Text.ASCIIEncoding.UTF8.GetBytes(datosJson));//lee el Json


                    lista = (List<Zona>)oDataContractJsonSerializer.ReadObject(ms);
                }

            else
            {
                lista = null;
            }
            return lista;
        }
        public override string ToString()
        {
            return Nombre;
        }

    }
}
