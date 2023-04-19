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
    public partial class FrmListaSeguridad : Form
    {
        public FrmListaSeguridad()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Cls_Seguridad SeguridadEmpleado = new Cls_Seguridad();


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListaSeguridad_Load(object sender, EventArgs e)
        {
            llenar_combo_Empleados();
        }
        private void llenar_combo_Empleados()
        {
            cboEmpleado.DataSource = SeguridadEmpleado.ConsultarEmpleados();
            cboEmpleado.DisplayMember = "StrNombre";
            cboEmpleado.ValueMember= "IdEmpleado";
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        
        public void Consultar()
        {
            int IdEmpleado = int.Parse(cboEmpleado.SelectedValue.ToString());
            dt = SeguridadEmpleado.Consulta_SeguridadEmpleado(IdEmpleado);

            if(dt.Rows.Count > 0 )
            {
                foreach(DataRow row in dt.Rows)
                {
                    txtUsuarioSeguridad.Text = row[0].ToString();
                    txtClaveSeguridad.Text = row[1].ToString();
                }
            }
            else
            {
                txtUsuarioSeguridad.Text = "";
                txtClaveSeguridad.Text = "";
                MessageBox.Show("No se le ha asignado usuario y clave a este empleado");
            }
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public void Guardar()
        {
            string mensaje = "";
            if (Validar())
            {
                SeguridadEmpleado.C_IdEmpleado = int.Parse(cboEmpleado.SelectedValue.ToString());
                SeguridadEmpleado.C_StrUsuario = txtUsuarioSeguridad.Text;
                SeguridadEmpleado.C_StrClave = txtClaveSeguridad.Text;
                SeguridadEmpleado.C_StrUsuarioModifico = "Andres";

                mensaje = SeguridadEmpleado.ActualizarSeguridadEmpleado();
                MessageBox.Show(mensaje);
            }
            txtClaveSeguridad.Text = "";
            txtUsuarioSeguridad.Text = ""; 
        }

        

        private Boolean Validar()
        {
            Boolean errorCampos = true;
            if (txtUsuarioSeguridad.Text == string.Empty)
            {
                MensajeError.SetError(txtUsuarioSeguridad, "debe ingresar el nombre del empleado");
                txtUsuarioSeguridad.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtUsuarioSeguridad, "");
            }

            if (txtClaveSeguridad.Text == "")
            {
                MensajeError.SetError(txtClaveSeguridad, "debe ingresar el documento");
                txtClaveSeguridad.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtClaveSeguridad, "");
            }

            if (!esNumerico(txtClaveSeguridad.Text))
            {
                MensajeError.SetError(txtClaveSeguridad, "debe ingresar el nombre del empleado");
                txtClaveSeguridad.Focus();
                return false;
            }
            else
            {
                MensajeError.SetError(txtClaveSeguridad, "");
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

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        public void Eliminar()
        {
            if (MessageBox.Show($"ESTA SEGURO DE BORRAR EL REGISTRO DE: {cboEmpleado.Text}",
                "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SeguridadEmpleado.C_IdEmpleado = int.Parse(cboEmpleado.SelectedValue.ToString());

                string mensaje = SeguridadEmpleado.EliminarSeguridadEmpleado();
                if(mensaje != "")
                {
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("BORRANDO EL REGISTRO");
                    txtClaveSeguridad.Text = "";
                    txtUsuarioSeguridad.Text = "";
                }
            }
        }
    }
}
