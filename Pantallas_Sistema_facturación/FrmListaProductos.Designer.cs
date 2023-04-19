namespace Pantallas_Sistema_facturación
{
    partial class FrmListaProductos
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
            this.lblTituloProductos = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscarProductos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevoProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirProductos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarProductos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompraProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompraVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloProductos
            // 
            this.lblTituloProductos.AutoSize = true;
            this.lblTituloProductos.Depth = 0;
            this.lblTituloProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloProductos.Location = new System.Drawing.Point(386, 44);
            this.lblTituloProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloProductos.Name = "lblTituloProductos";
            this.lblTituloProductos.Size = new System.Drawing.Size(246, 19);
            this.lblTituloProductos.TabIndex = 0;
            this.lblTituloProductos.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            // 
            // btnBuscarProductos
            // 
            this.btnBuscarProductos.AutoSize = true;
            this.btnBuscarProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarProductos.Depth = 0;
            this.btnBuscarProductos.Icon = null;
            this.btnBuscarProductos.Location = new System.Drawing.Point(456, 98);
            this.btnBuscarProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarProductos.Name = "btnBuscarProductos";
            this.btnBuscarProductos.Primary = true;
            this.btnBuscarProductos.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarProductos.TabIndex = 1;
            this.btnBuscarProductos.Text = "BUSCAR";
            this.btnBuscarProductos.UseVisualStyleBackColor = true;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.AutoSize = true;
            this.btnNuevoProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoProducto.Depth = 0;
            this.btnNuevoProducto.Icon = null;
            this.btnNuevoProducto.Location = new System.Drawing.Point(886, 98);
            this.btnNuevoProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Primary = true;
            this.btnNuevoProducto.Size = new System.Drawing.Size(66, 36);
            this.btnNuevoProducto.TabIndex = 2;
            this.btnNuevoProducto.Text = "NUEVO";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnSalirProductos
            // 
            this.btnSalirProductos.AutoSize = true;
            this.btnSalirProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirProductos.Depth = 0;
            this.btnSalirProductos.Icon = null;
            this.btnSalirProductos.Location = new System.Drawing.Point(894, 523);
            this.btnSalirProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirProductos.Name = "btnSalirProductos";
            this.btnSalirProductos.Primary = true;
            this.btnSalirProductos.Size = new System.Drawing.Size(58, 36);
            this.btnSalirProductos.TabIndex = 3;
            this.btnSalirProductos.Text = "SALIR";
            this.btnSalirProductos.UseVisualStyleBackColor = true;
            this.btnSalirProductos.Click += new System.EventHandler(this.btnSalirProductos_Click);
            // 
            // txtBuscarProductos
            // 
            this.txtBuscarProductos.Depth = 0;
            this.txtBuscarProductos.Hint = "Buscar Productos";
            this.txtBuscarProductos.Location = new System.Drawing.Point(83, 111);
            this.txtBuscarProductos.MaxLength = 32767;
            this.txtBuscarProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarProductos.Name = "txtBuscarProductos";
            this.txtBuscarProductos.PasswordChar = '\0';
            this.txtBuscarProductos.SelectedText = "";
            this.txtBuscarProductos.SelectionLength = 0;
            this.txtBuscarProductos.SelectionStart = 0;
            this.txtBuscarProductos.Size = new System.Drawing.Size(327, 23);
            this.txtBuscarProductos.TabIndex = 4;
            this.txtBuscarProductos.TabStop = false;
            this.txtBuscarProductos.UseSystemPasswordChar = false;
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.nombreProducto,
            this.categoriaProducto,
            this.precioCompraProducto,
            this.precioCompraVenta,
            this.stockProducto,
            this.btnEditarProducto,
            this.btnBorrarProducto});
            this.dgProductos.Location = new System.Drawing.Point(38, 163);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(933, 292);
            this.dgProductos.TabIndex = 5;
            this.dgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellContentClick_1);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "ID";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Width = 80;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "PRODUCTO";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Width = 250;
            // 
            // categoriaProducto
            // 
            this.categoriaProducto.HeaderText = "CATEGORIA";
            this.categoriaProducto.Name = "categoriaProducto";
            // 
            // precioCompraProducto
            // 
            this.precioCompraProducto.HeaderText = "PRECIO COMPRA";
            this.precioCompraProducto.Name = "precioCompraProducto";
            // 
            // precioCompraVenta
            // 
            this.precioCompraVenta.HeaderText = "PRECIO VENTA";
            this.precioCompraVenta.Name = "precioCompraVenta";
            // 
            // stockProducto
            // 
            this.stockProducto.HeaderText = "STOCK";
            this.stockProducto.Name = "stockProducto";
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.HeaderText = "EDITAR";
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Text = "EDITAR";
            this.btnEditarProducto.UseColumnTextForButtonValue = true;
            this.btnEditarProducto.Width = 80;
            // 
            // btnBorrarProducto
            // 
            this.btnBorrarProducto.HeaderText = "BORRAR";
            this.btnBorrarProducto.Name = "btnBorrarProducto";
            this.btnBorrarProducto.Text = "BORRAR";
            this.btnBorrarProducto.UseColumnTextForButtonValue = true;
            this.btnBorrarProducto.Width = 80;
            // 
            // FrmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 584);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.txtBuscarProductos);
            this.Controls.Add(this.btnSalirProductos);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.btnBuscarProductos);
            this.Controls.Add(this.lblTituloProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD LISTA PRODUCTOS";
            this.Load += new System.EventHandler(this.FrmListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloProductos;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarProductos;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirProductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarProductos;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompraProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompraVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockProducto;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditarProducto;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrarProducto;
    }
}