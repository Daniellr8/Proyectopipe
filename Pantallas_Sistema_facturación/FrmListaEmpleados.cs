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
    public partial class FrmListaEmpleados : Form
    {
        public FrmListaEmpleados()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Cls_Empleados empleado = new Cls_Empleados();
        
        private void llenar_grid()
        {
            dgEmpleados.Rows.Clear();
            dt = empleado.ConsultaEmpleado();

            if(dt.Rows.Count > 0 )
            {
                foreach(DataRow row in dt.Rows)
                {
                    dgEmpleados.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString());

                }

            }
            else
            {
                MessageBox.Show("No se encontraron registros");
            }
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmEditarEmpleado empleado= new FrmEditarEmpleado();
            empleado.IdEmpleado = 0;
            empleado.ShowDialog();
            llenar_grid();
        }

        private void btnSalirEmpleados_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListaEmpleados_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnBorrarEmpleado") 
            {
                int PosActual = dgEmpleados.CurrentRow.Index;
                if (MessageBox.Show("seguro de borrar", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO  indice{e.RowIndex} ID: {dgEmpleados[0, PosActual].Value.ToString()}");
            }
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnEditarEmpleado") 
            {
                int PosActual = dgEmpleados.CurrentRow.Index;
                FrmEditarEmpleado empleado = new FrmEditarEmpleado();
                empleado.IdEmpleado = int.Parse(dgEmpleados[0, PosActual].Value.ToString());
                empleado.ShowDialog();

            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            if(txtBuscarEmpleado.Text != "")
            {
                dgEmpleados.Rows.Clear();
                dt = empleado.Filtrar_Empleado(txtBuscarEmpleado.Text);

                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow row in dt.Rows)
                    {
                        dgEmpleados.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros por la busqueda solicitada");
                    llenar_grid();
                }
            }
            else
            {
                llenar_grid();
            }
            txtBuscarEmpleado.Text = "";
        }
    }
}
