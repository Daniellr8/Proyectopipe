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
    public partial class FrmEditarCliente : MaterialForm
    {
        public FrmEditarCliente()
        {
            InitializeComponent();
        }

        public int IdCliente { get; set; }
        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {
                lblTituloEditarCliente.Text = "INGRESAR NUEVO CLIENTE";

                btnActualizar.Text = "INGRESAR";
            }
            else
            {
                btnActualizar.Text = "ACTUALIZAR";
                lblTituloEditarCliente.Text = "MODIFICAR CLIENTE";
                TxtIdCliente.Text = IdCliente.ToString();
                TxtNombre.Text = "nombre 1 apellido";
                TxtDocumento.Text = "34353449";
                TxtDireccion.Text = "Calle donde vive el cliente";
                TxtTelefono.Text = "8378939";
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (IdCliente == 0)
            {

                MessageBox.Show("DATOS INGRESADOS CORRECTAMENTE");
            }
            else
            {
                MessageBox.Show("DATOS ACTUALIZADOS");

            }
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
