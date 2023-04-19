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
    public partial class FrmListaFacturacion : Form
    {
        public FrmListaFacturacion()
        {
            InitializeComponent();
        }

        private void btnSalirFacturacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenar_grid()
        {
            for (int i = 1; i < 11; i++)
            {
                dgFacturacion.Rows.Add(i, $"Nombre {i} Apellido1 Apellido2", $"{i * 12345}", $"{i * 12345}");
            }
        }

        private void btnNuevaFacturacion_Click(object sender, EventArgs e)
        {
            FrmEditarFacturacion editarFacturacion = new FrmEditarFacturacion();
            editarFacturacion.numeroFactura = 0;
            editarFacturacion.ShowDialog();
        }

        private void dgFacturacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgFacturacion.Columns[e.ColumnIndex].Name == "btnBorrarFacturacion") 
            {
                int PosActual = dgFacturacion.CurrentRow.Index;
                if (MessageBox.Show("seguro de borrar", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO  indice{e.RowIndex} Numero de Factura: {dgFacturacion[0, PosActual].Value.ToString()}");

            }
            if (dgFacturacion.Columns[e.ColumnIndex].Name == "btnEditarFacturacion")
            {
                int PosActual = dgFacturacion.CurrentRow.Index;
                FrmEditarFacturacion facturacion = new FrmEditarFacturacion();           
                facturacion.numeroFactura = int.Parse(dgFacturacion[0, PosActual].Value.ToString());              
                facturacion.ShowDialog();

            }
        }

        private void FrmListaFacturacion_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }
    }
}
