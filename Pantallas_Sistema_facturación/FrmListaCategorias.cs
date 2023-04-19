using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación
{
    public partial class FrmListaCategorias : Form
    {
        public FrmListaCategorias()
        {
            InitializeComponent();
        }

        
        public void llenar_grid()
        {
            for (int i = 1; i < 11; i++)
            {
                dgCategorias.Rows.Add($"{i * 12345}", $"{i} xxxxxx");
            }
        }

        private void btnSalirCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoCategoria_Click(object sender, EventArgs e)
        {
            FrmEditarCategorias categorias = new FrmEditarCategorias();
            categorias.codigoCategorias = 0;          
            categorias.ShowDialog();
        }

        private void FrmListaCategorias_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void dgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCategorias.Columns[e.ColumnIndex].Name == "btnBorrarCategoria")
            {
                int PosActual = dgCategorias.CurrentRow.Index;
                if (MessageBox.Show("seguro de borrar", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO  indice{e.RowIndex} ID {dgCategorias[0, PosActual].Value.ToString()}");
            }
            if (dgCategorias.Columns[e.ColumnIndex].Name == "btnEditarCategoria")
            {
                int PosActual = dgCategorias.CurrentRow.Index;
                FrmEditarCategorias categorias = new FrmEditarCategorias();
                categorias.codigoCategorias = int.Parse(dgCategorias[0, PosActual].Value.ToString());
                categorias.ShowDialog();

            }
        }
    }
}
