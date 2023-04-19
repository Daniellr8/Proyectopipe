namespace Pantallas_Sistema_facturación
{
    partial class FrmEditarFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarFacturacion));
            this.lblTituloEditarFacturacion = new MaterialSkin.Controls.MaterialLabel();
            this.lblNumeroFactura = new MaterialSkin.Controls.MaterialLabel();
            this.lblCliente = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalFactura = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalIva = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescuento = new MaterialSkin.Controls.MaterialLabel();
            this.lblDetalleFactura = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaRegistro = new MaterialSkin.Controls.MaterialLabel();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblEstadoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.cboEstadoFactura = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSalirEditarFacturacion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarEditarFacturacion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtTotalIva = new System.Windows.Forms.TextBox();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloEditarFacturacion
            // 
            this.lblTituloEditarFacturacion.AutoSize = true;
            this.lblTituloEditarFacturacion.Depth = 0;
            this.lblTituloEditarFacturacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloEditarFacturacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloEditarFacturacion.Location = new System.Drawing.Point(260, 84);
            this.lblTituloEditarFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloEditarFacturacion.Name = "lblTituloEditarFacturacion";
            this.lblTituloEditarFacturacion.Size = new System.Drawing.Size(235, 19);
            this.lblTituloEditarFacturacion.TabIndex = 0;
            this.lblTituloEditarFacturacion.Text = "ADMINISTRACIÓN DE FACTURAS";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Depth = 0;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNumeroFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumeroFactura.Location = new System.Drawing.Point(73, 129);
            this.lblNumeroFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(83, 19);
            this.lblNumeroFactura.TabIndex = 1;
            this.lblNumeroFactura.Text = "No Factura";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Depth = 0;
            this.lblCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCliente.Location = new System.Drawing.Point(73, 164);
            this.lblCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 19);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Depth = 0;
            this.lblEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmpleado.Location = new System.Drawing.Point(73, 198);
            this.lblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(76, 19);
            this.lblEmpleado.TabIndex = 3;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblTotalFactura
            // 
            this.lblTotalFactura.AutoSize = true;
            this.lblTotalFactura.Depth = 0;
            this.lblTotalFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalFactura.Location = new System.Drawing.Point(73, 307);
            this.lblTotalFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalFactura.Name = "lblTotalFactura";
            this.lblTotalFactura.Size = new System.Drawing.Size(98, 19);
            this.lblTotalFactura.TabIndex = 4;
            this.lblTotalFactura.Text = "Total Factura";
            // 
            // lblTotalIva
            // 
            this.lblTotalIva.AutoSize = true;
            this.lblTotalIva.Depth = 0;
            this.lblTotalIva.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalIva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalIva.Location = new System.Drawing.Point(73, 266);
            this.lblTotalIva.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalIva.Name = "lblTotalIva";
            this.lblTotalIva.Size = new System.Drawing.Size(67, 19);
            this.lblTotalIva.TabIndex = 5;
            this.lblTotalIva.Text = "Total Iva";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Depth = 0;
            this.lblDescuento.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescuento.Location = new System.Drawing.Point(73, 231);
            this.lblDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(81, 19);
            this.lblDescuento.TabIndex = 6;
            this.lblDescuento.Text = "Descuento";
            // 
            // lblDetalleFactura
            // 
            this.lblDetalleFactura.AutoSize = true;
            this.lblDetalleFactura.Depth = 0;
            this.lblDetalleFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetalleFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetalleFactura.Location = new System.Drawing.Point(74, 350);
            this.lblDetalleFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetalleFactura.Name = "lblDetalleFactura";
            this.lblDetalleFactura.Size = new System.Drawing.Size(130, 19);
            this.lblDetalleFactura.TabIndex = 7;
            this.lblDetalleFactura.Text = "Detalle de Factura";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Depth = 0;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaRegistro.Location = new System.Drawing.Point(543, 148);
            this.lblFechaRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(129, 19);
            this.lblFechaRegistro.TabIndex = 8;
            this.lblFechaRegistro.Text = "Fecha de Registro";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(176, 164);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(255, 21);
            this.cboCliente.TabIndex = 10;
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.Depth = 0;
            this.lblEstadoFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoFactura.Location = new System.Drawing.Point(543, 217);
            this.lblEstadoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(130, 19);
            this.lblEstadoFactura.TabIndex = 11;
            this.lblEstadoFactura.Text = "Estado de Factura";
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(176, 199);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(255, 21);
            this.cboEmpleado.TabIndex = 12;
            // 
            // cboEstadoFactura
            // 
            this.cboEstadoFactura.FormattingEnabled = true;
            this.cboEstadoFactura.Location = new System.Drawing.Point(547, 248);
            this.cboEstadoFactura.Name = "cboEstadoFactura";
            this.cboEstadoFactura.Size = new System.Drawing.Size(125, 21);
            this.cboEstadoFactura.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(547, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // btnSalirEditarFacturacion
            // 
            this.btnSalirEditarFacturacion.AutoSize = true;
            this.btnSalirEditarFacturacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirEditarFacturacion.Depth = 0;
            this.btnSalirEditarFacturacion.Icon = null;
            this.btnSalirEditarFacturacion.Location = new System.Drawing.Point(617, 492);
            this.btnSalirEditarFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirEditarFacturacion.Name = "btnSalirEditarFacturacion";
            this.btnSalirEditarFacturacion.Primary = true;
            this.btnSalirEditarFacturacion.Size = new System.Drawing.Size(58, 36);
            this.btnSalirEditarFacturacion.TabIndex = 15;
            this.btnSalirEditarFacturacion.Text = "SALIR";
            this.btnSalirEditarFacturacion.UseVisualStyleBackColor = true;
            this.btnSalirEditarFacturacion.Click += new System.EventHandler(this.btnSalirEditarFacturacion_Click);
            // 
            // btnActualizarEditarFacturacion
            // 
            this.btnActualizarEditarFacturacion.AutoSize = true;
            this.btnActualizarEditarFacturacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarEditarFacturacion.Depth = 0;
            this.btnActualizarEditarFacturacion.Icon = null;
            this.btnActualizarEditarFacturacion.Location = new System.Drawing.Point(572, 299);
            this.btnActualizarEditarFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarEditarFacturacion.Name = "btnActualizarEditarFacturacion";
            this.btnActualizarEditarFacturacion.Primary = true;
            this.btnActualizarEditarFacturacion.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarEditarFacturacion.TabIndex = 16;
            this.btnActualizarEditarFacturacion.Text = "ACTUALIZAR";
            this.btnActualizarEditarFacturacion.UseVisualStyleBackColor = true;
            this.btnActualizarEditarFacturacion.Click += new System.EventHandler(this.btnActualizarEditarFacturacion_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(77, 371);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(192, 192);
            this.axAcroPDF1.TabIndex = 17;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(176, 130);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(255, 20);
            this.txtNumeroFactura.TabIndex = 9;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(176, 230);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(255, 20);
            this.txtDescuento.TabIndex = 18;
            // 
            // txtTotalIva
            // 
            this.txtTotalIva.Location = new System.Drawing.Point(176, 266);
            this.txtTotalIva.Name = "txtTotalIva";
            this.txtTotalIva.Size = new System.Drawing.Size(255, 20);
            this.txtTotalIva.TabIndex = 19;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Location = new System.Drawing.Point(188, 306);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(243, 20);
            this.txtTotalFactura.TabIndex = 20;
            // 
            // FrmEditarFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 554);
            this.Controls.Add(this.txtTotalFactura);
            this.Controls.Add(this.txtTotalIva);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.btnActualizarEditarFacturacion);
            this.Controls.Add(this.btnSalirEditarFacturacion);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cboEstadoFactura);
            this.Controls.Add(this.cboEmpleado);
            this.Controls.Add(this.lblEstadoFactura);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.lblFechaRegistro);
            this.Controls.Add(this.lblDetalleFactura);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblTotalIva);
            this.Controls.Add(this.lblTotalFactura);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.lblTituloEditarFacturacion);
            this.Name = "FrmEditarFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURACIÓN";
            this.Load += new System.EventHandler(this.FrmEditarFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloEditarFacturacion;
        private MaterialSkin.Controls.MaterialLabel lblNumeroFactura;
        private MaterialSkin.Controls.MaterialLabel lblCliente;
        private MaterialSkin.Controls.MaterialLabel lblEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblTotalFactura;
        private MaterialSkin.Controls.MaterialLabel lblTotalIva;
        private MaterialSkin.Controls.MaterialLabel lblDescuento;
        private MaterialSkin.Controls.MaterialLabel lblDetalleFactura;
        private MaterialSkin.Controls.MaterialLabel lblFechaRegistro;
        private System.Windows.Forms.ComboBox cboCliente;
        private MaterialSkin.Controls.MaterialLabel lblEstadoFactura;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.ComboBox cboEstadoFactura;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirEditarFacturacion;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarEditarFacturacion;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTotalIva;
        private System.Windows.Forms.TextBox txtTotalFactura;
    }
}