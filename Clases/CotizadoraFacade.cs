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

        public double CalculaCosto()
        {

            double total = cliente.IProvedor.ObtenerCosto(); // 14000
            double adicionales = cliente.Paquete.CostoAdicionales(cliente.IProvedor.Zona);//23000
            double televisores = cliente.IProvedor.CostoSegunCantidad(cliente.Paquete.CantidadTv);//1800
            double paquetesPremium = (total + adicionales + televisores) * cliente.Paquete.PorsentajeCosto + (total + adicionales + televisores) * cliente.Paquete.PorsentajeImpuesto;
            double descuento = this.cliente.IProvedor.AplicarDescuentos(cliente.Paquete);
            

            
            return total + adicionales + televisores + paquetesPremium - descuento;
        }

        public void agregarCliente (DateTime fecha, string identficacion, string nombre, Paquete paquete, IProveedor proveedor)
        {
            cliente = new Cliente();
            cliente.FechaNacimiento = fecha;
            cliente.Identificacion = identficacion;
            cliente.Nombre = nombre;
            cliente.Paquete = paquete;
            cliente.IProvedor = proveedor;
            paquete.crear();
        }

        public void agregarAdicionales (Adicionales adicional)
        {
            cliente.Paquete.AgregarAdicional(adicional);

        }

        public IProveedor crearProveedor(bool teleCable, bool tigoStar, bool cableTica, Zona zona)
        {
           return ProveedorFactory.Instancia.factoryProveedor(teleCable, tigoStar, cableTica, zona);

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
            xPaquete.SetAttribute("Descripcion", cliente.Paquete.Descripcion);
            xProveedor.AppendChild(xPaquete);
            XmlElement xCliente = xmlDoc.CreateElement("Cliente");
            xCliente.SetAttribute("Identificacion", cliente.Identificacion);
            xCliente.SetAttribute("Nombre", cliente.Nombre);
            xCliente.SetAttribute("FechaNacimiento", cliente.FechaNacimiento.ToString("MM/dd/yyyy"));
            xCliente.SetAttribute("CantidadTV", cliente.Paquete.CantidadTv + "");
            xProveedor.AppendChild(xCliente);
            XmlElement xZona = xmlDoc.CreateElement("Zona");
            xZona.SetAttribute("PrecioTV", cliente.IProvedor.Zona.PrecioTV + "");
            xZona.InnerText = cliente.IProvedor.Zona.Nombre;
            xProveedor.AppendChild(xZona);
            XmlElement XAdicionales = xmlDoc.CreateElement("Adicionales");

            if (cliente.Paquete.ListaAdicionales.Count  != 0)
            {
                foreach (Adicionales adicional in cliente.Paquete.ListaAdicionales)
                {
                    XmlElement xAdicional = xmlDoc.CreateElement("Adicional");
                    xAdicional.InnerText = adicional + "";
                    XAdicionales.AppendChild(xAdicional);
                }
            }
            XmlElement xTotal = xmlDoc.CreateElement("Total");
            xTotal.SetAttribute("Descuentos", ""+cliente.IProvedor.AplicarDescuentos(cliente.Paquete));
            xTotal.InnerText = ""+ this.CalculaCosto();
            xProveedor.AppendChild(xTotal);
            xmlDoc.DocumentElement.AppendChild(xProveedor);
            xmlDoc.Save(Ruta);


            string rutaXslt = Application.StartupPath + "\\Xslt\\CableTV.xslt";//Da la ruta donde se va a almacenar el xslt
            //// Transformación del XMl utilizando XSLT
            XslCompiledTransform myXslTrans = new XslCompiledTransform(); //crea la variable xslt
            // Carga en memoria la lectura xslt
            myXslTrans.Load(rutaXslt); //carga el documento
            // Transforma el archivo xml aun archivo HTML
            myXslTrans.Transform(Ruta, Application.StartupPath + "\\html\\Cotizacion.html");// se indica donde se va a guardar el html

            return "Cotización realizada con exito";
        }

    }
}
