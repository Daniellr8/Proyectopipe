using Capa_LogicaDeNegocios;
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
    public partial class FrmListaRoles : Form
    {
        public FrmListaRoles()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Cls_Roles rol = new Cls_Roles();
        public void llenar_grid()
        {
            dgRoles.Rows.Clear();
            dt = rol.ConsultaRol();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgRoles.Rows.Add(row[0].ToString(), row[1].ToString());

                }

            }
            else
            {
                MessageBox.Show("No se encontraron registros");
            }
        }

        private void btnSalirRoles_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoRoles_Click(object sender, EventArgs e)
        {
            FrmEditarRoles roles = new FrmEditarRoles();
            roles.IdRol = 0;
            roles.ShowDialog();
            llenar_grid();
        }

        private void FrmListaRoles_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void dgRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgRoles.Columns[e.ColumnIndex].Name == "btnBorrarRoles") 
            {
                int PosActual = dgRoles.CurrentRow.Index;
                if (MessageBox.Show("seguro de borrar", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)                               
                    MessageBox.Show($"BORRANDO  indice{e.RowIndex} a {dgRoles[0, PosActual].Value.ToString()}");
            }
            if(dgRoles.Columns[e.ColumnIndex].Name == "btnEditarRoles") 
            {
                int PosActual = dgRoles.CurrentRow.Index;
                FrmEditarRoles roles = new FrmEditarRoles();
                roles.IdRol = int.Parse(dgRoles[0, PosActual].Value.ToString());
                roles.ShowDialog();

            }
        }

        private void btnBuscarRoles_Click(object sender, EventArgs e)
        {
            if (txtBuscarRoles.Text != "")
            {
                dgRoles.Rows.Clear();
                dt = rol.Filtrar_Rol(txtBuscarRoles.Text);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgRoles.Rows.Add(row[0].ToString(), row[1].ToString());
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
            txtBuscarRoles.Text = "";
        }
    }
}
