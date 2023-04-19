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

namespace Pantallas_Sistema_facturación
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text != "" && TxtUsuario.Text != string.Empty)
            {

                Validar_usuario Obj_validar = new Validar_usuario();


                Obj_validar.C_StrClave = TxtPasword.Text ;
                Obj_validar.C_strUsuario = TxtUsuario.Text;

                Obj_validar.ValidarUsuario();

                if (Obj_validar.C_IdEmpleado !=0)
                {
                    MessageBox.Show("Datos de verificación validos ");
                    FrmPrincipal frmPrincipal = new FrmPrincipal();
                    this.Hide();
                    frmPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("USUARIO Y CLAVE NO ENCONTRADOS");
                    TxtUsuario.Text = "";
                    TxtUsuario.Focus();
                    TxtPasword.Text = "";
                }  
            }
            else
            {
                MessageBox.Show("Debes ingresar un usuario y una clave");
            }
        }
    }
}
