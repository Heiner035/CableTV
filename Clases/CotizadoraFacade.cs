using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace Examen.CableTV.Clases
{
    public class CotizadoraFacade
    {
        private Cliente cliente = null;
        private Paquete paquete = null;
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
            xProveedor.SetAttribute("Nombre", cliente.IProvedor.Nombre);
            XmlElement xPaquete = xmlDoc.CreateElement("Paquete");
            xPaquete.SetAttribute("Descripcion", "aa");
            xProveedor.AppendChild(xPaquete);
            XmlElement xCliente = xmlDoc.CreateElement("Cliente");
            xCliente.SetAttribute("Identificacion", cliente.Identificacion);
            xCliente.SetAttribute("Nombre", cliente.Nombre);
            xCliente.SetAttribute("FechaNacimiento", cliente.FechaNacimiento.ToString("MM/dd/yyyy"));
            xCliente.SetAttribute("CantidadTV","");
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
            xmlDoc.DocumentElement.AppendChild(xProveedor);
            xmlDoc.Save(Ruta);


            //string rutaXslt = Application.StartupPath + "\\Xslt\\Libros.xslt";//Da la ruta donde se va a almacenar el xslt
            //// Transformación del XMl utilizando XSLT
            XslCompiledTransform myXslTrans = new XslCompiledTransform(); //crea la variable xslt
            // Carga en memoria la lectura xslt
            myXslTrans.Load(Ruta); //carga el documento
            // Transforma el archivo xml aun archivo HTML
            myXslTrans.Transform(Ruta, Application.StartupPath + "\\html\\Cotizacion.html");// se indica donde se va a guardar el html

            return "Cotización realizada con exito";
        }

    }
}
