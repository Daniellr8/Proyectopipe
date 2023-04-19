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
    public partial class FrmEditarProductos : MaterialForm
    {
        public FrmEditarProductos()
        {
            InitializeComponent();
        }

        public int IdProducto { get; set; }

        private void FrmEditarProductos_Load(object sender, EventArgs e)
        {

            if (IdProducto == 0)
            {
                lblTituloEditarProducto.Text = "INGRESAR NUEVO PRODUCTO ";
                btnActualizarProducto.Text = "INGRESAR";
            }
            else
            {
                btnActualizarProducto.Text = "ACTUALIZAR";
                lblTituloEditarProducto.Text = "MODIFICAR PRODUCTO";
                txtIdProducto.Text = IdProducto.ToString();
                txtEditarNombreProducto.Text = "nombre 1 apellido";
                txtEditarCodigo.Text = "09834764";
                txtEditarPrecioCompra.Text = "50000";
                txtEditarPrecioVenta.Text = " 70000";
                txtEditarStock.Text = "20";
                txtEditarRuta.Text = "D:\\semestre 4\\Herramientas lll\\imagenes proyecto 1";
                
            }
        }

         private void btnEditarSalir_Click(object sender, EventArgs e)
         {
            this.Close();
         }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            if (IdProducto == 0)
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
