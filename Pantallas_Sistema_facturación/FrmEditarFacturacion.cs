using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación
{
    public partial class FrmEditarFacturacion : MaterialForm
    {
        public FrmEditarFacturacion()
        {
            InitializeComponent();
        }

        public int numeroFactura { get; set; }

        private void FrmEditarFacturacion_Load(object sender, EventArgs e)
        {

            if (numeroFactura == 0)
            {
                lblTituloEditarFacturacion.Text = "INGRESA NUEVA FACTURA";
                btnActualizarEditarFacturacion.Text = "INGRESAR";
            }
            else
            {
                btnActualizarEditarFacturacion.Text = "ACTUALIZAR";
                lblTituloEditarFacturacion.Text = "MODIFICAR FACTURA";
                txtNumeroFactura.Text = numeroFactura.ToString();
            }
        }
    

        private void btnSalirEditarFacturacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarEditarFacturacion_Click(object sender, EventArgs e)
        {
            if (numeroFactura == 0)
            {
                MessageBox.Show("DATOS INGRESADOS CORRECTAMENTE");
            }
            else
            {
                MessageBox.Show("DATOS ACTUALIZADOS");

            }
            this.Close();
        }
    }
}
