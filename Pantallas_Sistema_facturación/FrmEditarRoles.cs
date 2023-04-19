using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación
{
    public partial class FrmEditarRoles : MaterialForm
    {
        public FrmEditarRoles()
        {
            InitializeComponent();
        }       

        public int IdRol { get; set; }

        DataTable dt = new DataTable();
        Cls_Roles roles = new Cls_Roles();

        private void FrmEditarRoles_Load(object sender, EventArgs e)
        {           
            if (IdRol == 0)
            {
                lblTituloEditarRol.Text = "INGRESO NUEVO EMPLEADO";
            }
            else
            {
                lblTituloEditarRol.Text = "MODIFICAR EMPLEADO";
                llenar_campos();
            }
        }
 
        private void llenar_campos()
        {
            dt = roles.Consulta_Rol(IdRol);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    txtRol.Text = row[0].ToString();
                    txtNombreRol.Text = row[1].ToString();
                   
                }
            }
        }
        private void btnSalirRol_Click(object sender, EventArgs e)
        {
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edición ?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (Rta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnActualizarRol_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public void Guardar()
        {
            string mensaje = "";
            if (Validar())
            {
                roles.C_IdRolEmpleado = IdRol;
                roles.C_StrDescripcion = txtNombreRol.Text;

                mensaje = roles.ActualizarRol();
                MessageBox.Show(mensaje);
            }
        }

        private Boolean Validar()
        {
            Boolean errorCampos = true;
            if (txtNombreRol.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreRol, "debe ingresar el nombre del rol");
                txtNombreRol.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNombreRol, "");
            }

            if (txtRol.Text == "")
            {
                MensajeError.SetError(txtRol, "debe ingresar el Numero de rol");
                txtRol.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtRol, "");
            }

            if (!esNumerico(txtRol.Text))
            {
                MensajeError.SetError(txtRol, "debe ingresar un numero ");
                txtRol.Focus();
                return false;
            }
            else
            {
                MensajeError.SetError(txtRol, "");
                return errorCampos;
            }
        }

        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
