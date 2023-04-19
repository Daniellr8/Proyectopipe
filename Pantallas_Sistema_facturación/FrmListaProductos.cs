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
    public partial class FrmListaProductos : Form
    {
        public FrmListaProductos()
        {
            InitializeComponent();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmEditarProductos productos = new FrmEditarProductos();
            productos.IdProducto = 0;
            productos.ShowDialog();
        }

        private void btnSalirProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListaProductos_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }
        private void llenar_grid()
        {
            for (int i = 1; i < 11; i++)
            {
                dgProductos.Rows.Add(i,$"{i} Nombre1 Nombre2", $"{i} A", $"{i * 12345}", $"{i * 22345}", $"{20}");
            }
        }

        private void dgProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnBorrarProducto")
            {
                int PosActual = dgProductos.CurrentRow.Index;
                if (MessageBox.Show("seguro de borrar", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO  indice{e.RowIndex} ID {dgProductos[0, PosActual].Value.ToString()}");
            }
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnEditarProducto")
            {
                int PosActual = dgProductos.CurrentRow.Index;
                FrmEditarProductos producto = new FrmEditarProductos();
                producto.IdProducto = int.Parse(dgProductos[0, PosActual].Value.ToString());
                producto.ShowDialog();

            }
        }
    }
}
