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
    public partial class FrmEditarSeguridad : MaterialForm
    {
        public FrmEditarSeguridad()
        {
            InitializeComponent();
        }

        public int idEmpleadoSeguridad { get; set; }

        private void FrmEditarSeguridad_Load(object sender, EventArgs e)
        {
            if (idEmpleadoSeguridad == 0)
            {
                lblTituloEditarSeguridad.Text = "INGRESAR NUEVO CLIENTE";

                btnActualizarSeguridad.Text = "INGRESAR";
            }
            else
            {
                btnActualizarSeguridad.Text = "ACTUALIZAR";
                lblTituloEditarSeguridad.Text = "MODIFICAR CLIENTE";
                cboEditarEmpleado.Text = idEmpleadoSeguridad.ToString();
                txtEditarUsuarioSeguridad.Text = "nombre 1 apellido";
                txtEditarClaveSeguridad.Text = "34353449";
            }
        }

        private void btnEditarSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarSeguridad_Click(object sender, EventArgs e)
        {
            if (idEmpleadoSeguridad == 0)
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
