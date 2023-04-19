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
using Capa_LogicaDeNegocios;

namespace Pantallas_Sistema_facturación
{
    public partial class FrmListaClientes : Form
    {
        public FrmListaClientes()
        {
            InitializeComponent();
        }


        DataTable dt = new DataTable();
        Cls_Clien

        public void llenar_grid()
        {
            dgClientes.Rows.Clear();
            dt = ();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgEmpleados.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString());

                }

            }
            else
            {
                MessageBox.Show("No se encontraron registros");
            }
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarCliente Cliente = new FrmEditarCliente();
            Cliente.IdCliente = 0;
            Cliente.ShowDialog();

        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int PosActual = dgClientes.CurrentRow.Index;
                if (MessageBox.Show("seguro de borrar", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO  indice{e.RowIndex} ID {dgClientes[0, PosActual].Value.ToString()}");
            }
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int PosActual = dgClientes.CurrentRow.Index;
                FrmEditarCliente cliente = new FrmEditarCliente();
                cliente.IdCliente = int.Parse(dgClientes[0, PosActual].Value.ToString());
                cliente.ShowDialog();

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
