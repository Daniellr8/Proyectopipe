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
    public partial class FrmPrincipal : MaterialForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmListaClientes listaCliente = new FrmListaClientes();
            AbrirForm(listaCliente);
        }

        private void AbrirForm(Form formHijo)
        {
            if(this.pnlContenedorTablas.Controls.Count > 0) 
                this.pnlContenedorTablas.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock= DockStyle.Fill;
            this.pnlContenedorTablas.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmListaProductos listaProductos = new FrmListaProductos();
            AbrirForm(listaProductos);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmListaCategorias listaCategorias = new FrmListaCategorias();
            AbrirForm(listaCategorias);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            FrmListaFacturacion listaFacturacion = new FrmListaFacturacion();
            AbrirForm(listaFacturacion);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            FrmListaInformes listaInformes = new FrmListaInformes();
            AbrirForm(listaInformes);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmListaEmpleados listaEmpleados = new FrmListaEmpleados();
            AbrirForm(listaEmpleados);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            FrmListaRoles listaRoles = new FrmListaRoles();
            AbrirForm(listaRoles);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            FrmListaSeguridad listaSeguridad = new FrmListaSeguridad();
            AbrirForm(listaSeguridad);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda ayuda = new FrmAyuda();
            AbrirForm(ayuda);
        }

        private void btnAcercad_Click(object sender, EventArgs e)
        {
            FrmAcercaDe acercaDe = new FrmAcercaDe();
            AbrirForm(acercaDe);
        }
    }
}
