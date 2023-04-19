using Capa_LogicaDeNegocios;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación
{
    public partial class FrmEditarEmpleado : MaterialForm
    {
        public FrmEditarEmpleado()
        {
            InitializeComponent();
        }

        public int IdEmpleado { get; set; }

        DataTable dt = new DataTable();
        Cls_Empleados empleado = new Cls_Empleados();

        private void FrmEditarEmpleado_Load(object sender, EventArgs e)
        {
            llenar_combo();
            if(IdEmpleado == 0)
            {
                lblTituloEditarEmpleado.Text = "INGRESO NUEVO EMPLEADO";
            }
            else
            {
                lblTituloEditarEmpleado.Text = "MODIFICAR EMPLEADO";
                llenar_campos();
            }
        }

        private void llenar_combo()
        {
            cboRol.DataSource = empleado.ConsultarRol();
            cboRol.DisplayMember = "strDescripcion";
            cboRol.ValueMember = "IdRolEmpleado";
        }

        private void llenar_campos()
        {
            dt = empleado.Consulta_Empleado(IdEmpleado);
            if(dt.Rows.Count > 0 )
            {
                foreach(DataRow row in dt.Rows)
                {
                    TxtNombreEmpleado.Text = row[1].ToString();
                    TxtDocumentoEmpleado.Text = row[2].ToString();                    
                    TxtDireccionEmpleado.Text = row[3].ToString();
                    TxtTelefonoEmpleado.Text = row[4].ToString();
                    TxtEmailEmpleado.Text = row[5].ToString();

                    cboRol.SelectedValue= int.Parse(row[6].ToString());
                    dtmFechaIngreso.Value = Convert.ToDateTime(row[7].ToString());
                    dtmFechaRetiro.Value = Convert.ToDateTime(row[8].ToString());
                    txtDatosAdicionales.Text = row[9].ToString();
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edición ?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if(Rta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public void Guardar()
        {
            string name = "andres";
            string mensaje = "";
            if(Validar())
            {
                empleado.C_IdEmpleado = IdEmpleado;
                empleado.C_strNombre = TxtNombreEmpleado.Text;
                empleado.C_NumDocumento = double.Parse(TxtDocumentoEmpleado.Text);
                empleado.C_StrDireccion = TxtDireccionEmpleado.Text;
                empleado.C_StrTelefono = TxtTelefonoEmpleado.Text;
                empleado.C_StrEmail = TxtEmailEmpleado.Text;
                empleado.C_IdRolEmpleado = int.Parse(cboRol.SelectedValue.ToString());
                empleado.C_DtmIngreso = DateTime.Now.ToString("yyyy/MM/dd");
                empleado.C_DtmRetiro = DateTime.Now.ToString("yyyy/MM/dd");
                empleado.C_strDatosAdicionales = txtDatosAdicionales.Text;
                empleado.C_StrUsuarioModifico = name;

                mensaje = empleado.ActualizarEmpleado();
                MessageBox.Show(mensaje);
            }
        }

        private Boolean Validar()
        {
            Boolean errorCampos = true;
            if(TxtNombreEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(TxtNombreEmpleado, "debe ingresar el nombre del empleado");
                TxtNombreEmpleado.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(TxtNombreEmpleado, "");
            }

            if (TxtDocumentoEmpleado.Text == "")
            {
                MensajeError.SetError(TxtDocumentoEmpleado, "debe ingresar el documento");
                TxtDocumentoEmpleado.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(TxtDocumentoEmpleado, "");
            }

            if (!esNumerico(TxtDocumentoEmpleado.Text))
            {
                MensajeError.SetError(TxtDocumentoEmpleado, "debe ingresar el nombre del empleado");
                TxtDocumentoEmpleado.Focus();
                return false;
            }
            else
            {
                MensajeError.SetError(TxtDocumentoEmpleado, "");
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
