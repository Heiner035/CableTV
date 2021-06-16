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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Zona instanciaZona = new Zona();
               foreach (Zona zona in instanciaZona.obtenerZonas() )
            {
                cmbZonas.Items.Add(zona);
            }
        }       

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            
        }     

        private void rbtTeleCable_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtCableTica_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtTigoStar_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
