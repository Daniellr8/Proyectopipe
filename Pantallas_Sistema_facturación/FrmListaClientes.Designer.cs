namespace Pantallas_Sistema_facturación
{
    partial class FrmListaClientes
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
            this.lblTituloCliente = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBuscarCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevoCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCliente
            // 
            this.lblTituloCliente.AutoSize = true;
            this.lblTituloCliente.Depth = 0;
            this.lblTituloCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloCliente.Location = new System.Drawing.Point(419, 47);
            this.lblTituloCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloCliente.Name = "lblTituloCliente";
            this.lblTituloCliente.Size = new System.Drawing.Size(206, 19);
            this.lblTituloCliente.TabIndex = 0;
            this.lblTituloCliente.Text = "ADMINISTRACIÓN CLIENTES";
            // 
            // TxtBuscarCliente
            // 
            this.TxtBuscarCliente.Depth = 0;
            this.TxtBuscarCliente.Hint = "Buscar por cliente";
            this.TxtBuscarCliente.Location = new System.Drawing.Point(125, 120);
            this.TxtBuscarCliente.MaxLength = 32767;
            this.TxtBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscarCliente.Name = "TxtBuscarCliente";
            this.TxtBuscarCliente.PasswordChar = '\0';
            this.TxtBuscarCliente.SelectedText = "";
            this.TxtBuscarCliente.SelectionLength = 0;
            this.TxtBuscarCliente.SelectionStart = 0;
            this.TxtBuscarCliente.Size = new System.Drawing.Size(329, 23);
            this.TxtBuscarCliente.TabIndex = 1;
            this.TxtBuscarCliente.TabStop = false;
            this.TxtBuscarCliente.UseSystemPasswordChar = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.AutoSize = true;
            this.btnBuscarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarCliente.Depth = 0;
            this.btnBuscarCliente.Icon = null;
            this.btnBuscarCliente.Location = new System.Drawing.Point(488, 107);
            this.btnBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Primary = true;
            this.btnBuscarCliente.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "BUSCAR";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.AutoSize = true;
            this.btnNuevoCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoCliente.Depth = 0;
            this.btnNuevoCliente.Icon = null;
            this.btnNuevoCliente.Location = new System.Drawing.Point(835, 107);
            this.btnNuevoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Primary = true;
            this.btnNuevoCliente.Size = new System.Drawing.Size(66, 36);
            this.btnNuevoCliente.TabIndex = 3;
            this.btnNuevoCliente.Text = "NUEVO";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalirCliente
            // 
            this.btnSalirCliente.AutoSize = true;
            this.btnSalirCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirCliente.Depth = 0;
            this.btnSalirCliente.Icon = null;
            this.btnSalirCliente.Location = new System.Drawing.Point(861, 490);
            this.btnSalirCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirCliente.Name = "btnSalirCliente";
            this.btnSalirCliente.Primary = true;
            this.btnSalirCliente.Size = new System.Drawing.Size(58, 36);
            this.btnSalirCliente.TabIndex = 4;
            this.btnSalirCliente.Text = "SALIR";
            this.btnSalirCliente.UseVisualStyleBackColor = true;
            this.btnSalirCliente.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cliente,
            this.strCliente,
            this.strDocumento,
            this.strTelefono,
            this.btnEditar,
            this.btnBorrar});
            this.dgClientes.Location = new System.Drawing.Point(125, 183);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.Size = new System.Drawing.Size(794, 282);
            this.dgClientes.TabIndex = 5;
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.HeaderText = "ID";
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.Width = 80;
            // 
            // strCliente
            // 
            this.strCliente.HeaderText = "CLIENTE";
            this.strCliente.Name = "strCliente";
            this.strCliente.Width = 300;
            // 
            // strDocumento
            // 
            this.strDocumento.HeaderText = "DOCUMENTO";
            this.strDocumento.Name = "strDocumento";
            // 
            // strTelefono
            // 
            this.strTelefono.HeaderText = "TELEFONO";
            this.strTelefono.Name = "strTelefono";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 80;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            this.btnBorrar.Width = 80;
            // 
            // FrmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 561);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.btnSalirCliente);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.TxtBuscarCliente);
            this.Controls.Add(this.lblTituloCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD LISTA CLIENTES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirCliente;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn strTelefono;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}