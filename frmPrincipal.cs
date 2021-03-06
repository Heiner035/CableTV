using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Examen.CableTV.Clases
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private CotizadoraFacade cotizadoraFacade = new CotizadoraFacade();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lstPaquetes.Items.Add(new Basico());
            lstPaquetes.Items.Add(new Premium());
            lstPaquetes.Items.Add(new Deportivo());
        }
         

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            Validacion();
            cotizadoraFacade.agregarCliente(dtpFechaNace.Value, mtxId.Text, txtNombre.Text, (Paquete)lstPaquetes.SelectedItem, cotizadoraFacade.crearProveedor(rbtTeleCable.Checked, rbtTigoStar.Checked, rbtCableTica.Checked, (Zona)cmbZonas.SelectedItem));
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo xml|*.xml";
            var resultado = saveFileDialog.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                if (chkDigital.Checked)
                {
                    cotizadoraFacade.agregarAdicionales(Adicionales.Digital);
                }
                if (chkInternet.Checked)
                {
                    cotizadoraFacade.agregarAdicionales(Adicionales.Internet);
                }
                if (chkTelefono.Checked)
                {
                    cotizadoraFacade.agregarAdicionales(Adicionales.Telefono);
                }
                MessageBox.Show(cotizadoraFacade.ExportarXml(saveFileDialog.FileName));
             
              

            }
            else
            {
                MessageBox.Show("Por favor seleccione la ruta");
            }
            webBrowser.Url = new Uri(Application.StartupPath + "\\html\\Cotizacion.html");
        }
        

       

        private void rbtTeleCable_CheckedChanged(object sender, EventArgs e)
        {
                Zona instanciaZona = new Zona();
                foreach (Zona zona in instanciaZona.obtenerZonas())
                {
                    cmbZonas.Items.Add(zona);
                }
            }
        

        private void rbtCableTica_CheckedChanged(object sender, EventArgs e)
        {
            Zona instanciaZona = new Zona();
            foreach (Zona zona in instanciaZona.obtenerZonas())
            {
                cmbZonas.Items.Add(zona);
            }
        }
    

        private void rbtTigoStar_CheckedChanged(object sender, EventArgs e)
        {
        Zona instanciaZona = new Zona();
        foreach (Zona zona in instanciaZona.obtenerZonas())
        {
            cmbZonas.Items.Add(zona);
        }
    }


        private void Validacion()
        {
            if (txtNombre.Text==String.Empty)
            {
                MessageBox.Show("Debe digitar una identificación");
                return;
            }


            if (txtNombre.Text==String.Empty)
            {
                MessageBox.Show("Debe digitar un nombre");
                return;
            }

            if (nudCantidadTV.Value<1)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0");
                return;
            }

            if (cmbZonas.SelectedIndex<0)
            {
                MessageBox.Show("Debe seleccionar una zona");
                return;
            }


        }


    }
}
