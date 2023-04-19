namespace Pantallas_Sistema_facturación
{
    partial class FrmListaFacturacion
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
            this.lblTituloFacturacion = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarFacturacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnNuevaFacturacion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarFacturacion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirFacturacion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgFacturacion = new System.Windows.Forms.DataGridView();
            this.numeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteFacturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emisionFacturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorFacturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoFacturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarFacturacion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrarFacturacion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloFacturacion
            // 
            this.lblTituloFacturacion.AutoSize = true;
            this.lblTituloFacturacion.Depth = 0;
            this.lblTituloFacturacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloFacturacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloFacturacion.Location = new System.Drawing.Point(356, 83);
            this.lblTituloFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloFacturacion.Name = "lblTituloFacturacion";
            this.lblTituloFacturacion.Size = new System.Drawing.Size(261, 19);
            this.lblTituloFacturacion.TabIndex = 0;
            this.lblTituloFacturacion.Text = "ADMINISTRACIÓN DE FACTURACIÓN";
            // 
            // txtBuscarFacturacion
            // 
            this.txtBuscarFacturacion.Depth = 0;
            this.txtBuscarFacturacion.Hint = "Buscar Facturación";
            this.txtBuscarFacturacion.Location = new System.Drawing.Point(125, 163);
            this.txtBuscarFacturacion.MaxLength = 32767;
            this.txtBuscarFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarFacturacion.Name = "txtBuscarFacturacion";
            this.txtBuscarFacturacion.PasswordChar = '\0';
            this.txtBuscarFacturacion.SelectedText = "";
            this.txtBuscarFacturacion.SelectionLength = 0;
            this.txtBuscarFacturacion.SelectionStart = 0;
            this.txtBuscarFacturacion.Size = new System.Drawing.Size(367, 23);
            this.txtBuscarFacturacion.TabIndex = 1;
            this.txtBuscarFacturacion.TabStop = false;
            this.txtBuscarFacturacion.UseSystemPasswordChar = false;
            // 
            // btnNuevaFacturacion
            // 
            this.btnNuevaFacturacion.AutoSize = true;
            this.btnNuevaFacturacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevaFacturacion.Depth = 0;
            this.btnNuevaFacturacion.Icon = null;
            this.btnNuevaFacturacion.Location = new System.Drawing.Point(765, 150);
            this.btnNuevaFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevaFacturacion.Name = "btnNuevaFacturacion";
            this.btnNuevaFacturacion.Primary = true;
            this.btnNuevaFacturacion.Size = new System.Drawing.Size(162, 36);
            this.btnNuevaFacturacion.TabIndex = 2;
            this.btnNuevaFacturacion.Text = "NUEVA FACTURACIÓN";
            this.btnNuevaFacturacion.UseVisualStyleBackColor = true;
            this.btnNuevaFacturacion.Click += new System.EventHandler(this.btnNuevaFacturacion_Click);
            // 
            // btnBuscarFacturacion
            // 
            this.btnBuscarFacturacion.AutoSize = true;
            this.btnBuscarFacturacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarFacturacion.Depth = 0;
            this.btnBuscarFacturacion.Icon = null;
            this.btnBuscarFacturacion.Location = new System.Drawing.Point(498, 150);
            this.btnBuscarFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarFacturacion.Name = "btnBuscarFacturacion";
            this.btnBuscarFacturacion.Primary = true;
            this.btnBuscarFacturacion.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarFacturacion.TabIndex = 3;
            this.btnBuscarFacturacion.Text = "BUSCAR";
            this.btnBuscarFacturacion.UseVisualStyleBackColor = true;
            // 
            // btnSalirFacturacion
            // 
            this.btnSalirFacturacion.AutoSize = true;
            this.btnSalirFacturacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirFacturacion.Depth = 0;
            this.btnSalirFacturacion.Icon = null;
            this.btnSalirFacturacion.Location = new System.Drawing.Point(869, 490);
            this.btnSalirFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirFacturacion.Name = "btnSalirFacturacion";
            this.btnSalirFacturacion.Primary = true;
            this.btnSalirFacturacion.Size = new System.Drawing.Size(58, 36);
            this.btnSalirFacturacion.TabIndex = 4;
            this.btnSalirFacturacion.Text = "SALIR";
            this.btnSalirFacturacion.UseVisualStyleBackColor = true;
            this.btnSalirFacturacion.Click += new System.EventHandler(this.btnSalirFacturacion_Click);
            // 
            // dgFacturacion
            // 
            this.dgFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroFactura,
            this.clienteFacturacion,
            this.emisionFacturacion,
            this.valorFacturacion,
            this.estadoFacturacion,
            this.btnEditarFacturacion,
            this.btnBorrarFacturacion});
            this.dgFacturacion.Location = new System.Drawing.Point(125, 214);
            this.dgFacturacion.Name = "dgFacturacion";
            this.dgFacturacion.Size = new System.Drawing.Size(745, 251);
            this.dgFacturacion.TabIndex = 5;
            this.dgFacturacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFacturacion_CellContentClick);
            // 
            // numeroFactura
            // 
            this.numeroFactura.HeaderText = "N° FACTURA";
            this.numeroFactura.Name = "numeroFactura";
            this.numeroFactura.Width = 80;
            // 
            // clienteFacturacion
            // 
            this.clienteFacturacion.HeaderText = "CLIENTE";
            this.clienteFacturacion.Name = "clienteFacturacion";
            // 
            // emisionFacturacion
            // 
            this.emisionFacturacion.HeaderText = "EMISION";
            this.emisionFacturacion.Name = "emisionFacturacion";
            // 
            // valorFacturacion
            // 
            this.valorFacturacion.HeaderText = "VALOR";
            this.valorFacturacion.Name = "valorFacturacion";
            // 
            // estadoFacturacion
            // 
            this.estadoFacturacion.HeaderText = "ESTADO";
            this.estadoFacturacion.Name = "estadoFacturacion";
            // 
            // btnEditarFacturacion
            // 
            this.btnEditarFacturacion.HeaderText = "EDITAR";
            this.btnEditarFacturacion.Name = "btnEditarFacturacion";
            this.btnEditarFacturacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditarFacturacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditarFacturacion.Text = "EDITAR";
            this.btnEditarFacturacion.UseColumnTextForButtonValue = true;
            // 
            // btnBorrarFacturacion
            // 
            this.btnBorrarFacturacion.HeaderText = "BORRAR";
            this.btnBorrarFacturacion.Name = "btnBorrarFacturacion";
            this.btnBorrarFacturacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnBorrarFacturacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnBorrarFacturacion.Text = "BORRAR";
            this.btnBorrarFacturacion.UseColumnTextForButtonValue = true;
            // 
            // FrmListaFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 551);
            this.Controls.Add(this.dgFacturacion);
            this.Controls.Add(this.btnSalirFacturacion);
            this.Controls.Add(this.btnBuscarFacturacion);
            this.Controls.Add(this.btnNuevaFacturacion);
            this.Controls.Add(this.txtBuscarFacturacion);
            this.Controls.Add(this.lblTituloFacturacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaFacturacion";
            this.Load += new System.EventHandler(this.FrmListaFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloFacturacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarFacturacion;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevaFacturacion;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarFacturacion;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirFacturacion;
        private System.Windows.Forms.DataGridView dgFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn emisionFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoFacturacion;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditarFacturacion;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrarFacturacion;
    }
}