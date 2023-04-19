using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación
{
    public partial class FrmAcercaDe : Form
    {
        public FrmAcercaDe()
        {
            InitializeComponent();
        }

        private void FrmAcercaDe_Load(object sender, EventArgs e)
        {

        }

        private void llblInfoSistema_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://portafoliofelipezapataiupascualbravo.blogspot.com/");
        }

        private void btnAceptarPolitica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("POLITICAS DE SEGURIDAD Y DERECHOS DE AUTOR ACEPTADAS");
        }
    }
}
