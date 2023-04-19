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
    public partial class FrmEditarCategorias : MaterialForm
    {
        public FrmEditarCategorias()
        {
            InitializeComponent();
        }

        public int codigoCategorias { get; set; }
        private void FrmEditarCategorias_Load(object sender, EventArgs e)
        {
            if (codigoCategorias == 0)
            {
                lblTituloCategoria.Text = "INGRESAR NUEVA CATEGORIA";
                btnActualizarCategoria.Text = "INGRESAR";
            }
            else
            {
                btnActualizarCategoria.Text = "ACTUALIZAR";
                lblTituloCategoria.Text = "MODIFICAR CATEGORIA";
                txtCategoria.Text = codigoCategorias.ToString();
                txtNombreCategoria.Text = "nombre 1 apellido";
                
                
            }
        }

        private void btnSalirCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            if (codigoCategorias == 0)
            {
                if(txtCategoria.Text.Trim() == "")
                {
                    epValidarCampos.SetError(txtCategoria, "INTRODUCE UN ID PARA LA CATEGORIA");
                    txtCategoria.Focus();

                    if(txtNombreCategoria.Text.Trim() == "")
                    {
                        epValidarCampos.SetError(txtNombreCategoria, "INTRODUCE UN NOMBRE PARA EL ROL");
                        txtCategoria.Focus();
                    }
                   
                }
                else
                {
                    epValidarCampos.Clear();
                    MessageBox.Show("DATOS INGRESADOS CORRECTAMENTE");
                    this.Close();
                } 
            }
            else
            {
                if (txtCategoria.Text.Trim() == "" || txtNombreCategoria.Text.Trim() == "")
                {
                    epValidarCampos.SetError(txtCategoria, "COMPLETE EL CAMPO");
                    txtCategoria.Focus();

                    epValidarCampos.SetError(txtNombreCategoria, "COMPLETE EL CAMPO");
                    txtCategoria.Focus();
                   
                }
                else
                {
                    epValidarCampos.Clear();
                    MessageBox.Show("DATOS ACTUALIZADOS");
                    this.Close();
                }
            } 
        }  
    }
}
