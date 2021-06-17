using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Examen.CableTV.Clases
{
    public class CotizadoraFacade
    {
        private Cliente Cliente;

        public double CalculaCosto()
        {
            return 0;
        }

        public string ExportarXml(string Ruta)
        {
            System.Xml.XmlDocument xmlDoc = new XmlDocument();//crea la variable
            // si esxites el documento == falso
            if (File.Exists(Ruta) == false)
            {
                // Se crea el documento y la raiz si no existe el archivo
                xmlDoc.LoadXml("<CableTV/>"); // raiz
            }
            else
            {
                //Se carga el documento
                xmlDoc.Load(Ruta);
            }
            XmlElement xProveedor = xmlDoc.CreateElement("Proveedor");
            xProveedor.SetAttribute("Nombre", "aaa");
            XmlElement xPaquete = xmlDoc.CreateElement("Paquete");
            xPaquete.SetAttribute("Descripcion", "aa");
            xProveedor.AppendChild(xPaquete);
            XmlElement xCliente = xmlDoc.CreateElement("Cliente");
            xCliente.SetAttribute("Identificacion", "aa");
            xCliente.SetAttribute("Nombre", "aa");
            xCliente.SetAttribute("FechaNacimiento", "aa");
            xCliente.SetAttribute("CantidadTV", "aa");
            xProveedor.AppendChild(xCliente);
            XmlElement xZona = xmlDoc.CreateElement("Zona");
            xZona.SetAttribute("PrecioTV", "aaa");
            xZona.InnerText = "aaa";
            xProveedor.AppendChild(xZona);
            XmlElement XAdicionales = xmlDoc.CreateElement("Adicionales");
            //if (!= 0)
            //{
            //    for ()
            //    {
            //        XmlElement xAdicional = xmlDoc.CreateElement("Adicional");
            //        xAdicional.InnerText = "aaa";
            //        XAdicionales.AppendChild(xAdicional);
            //    }
            //}
            XmlElement xTotal = xmlDoc.CreateElement("Total");
            xTotal.SetAttribute("Descuentos", "aaa");
            xTotal.InnerText = "aa";
            xProveedor.AppendChild(xTotal);

            return "Cotización realizada con exito";
        }

    }
}
