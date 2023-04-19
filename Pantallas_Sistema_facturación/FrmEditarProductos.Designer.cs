namespace Pantallas_Sistema_facturación
{
    partial class FrmEditarProductos
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
            this.lblTituloEditarProducto = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtEditarNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEditarCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEditarPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEditarPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEditarStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEditarRuta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.lblDetalles = new MaterialSkin.Controls.MaterialLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnActualizarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditarSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblIdProducto = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblTituloEditarProducto
            // 
            this.lblTituloEditarProducto.AutoSize = true;
            this.lblTituloEditarProducto.Depth = 0;
            this.lblTituloEditarProducto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloEditarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloEditarProducto.Location = new System.Drawing.Point(182, 91);
            this.lblTituloEditarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloEditarProducto.Name = "lblTituloEditarProducto";
            this.lblTituloEditarProducto.Size = new System.Drawing.Size(161, 19);
            this.lblTituloEditarProducto.TabIndex = 0;
            this.lblTituloEditarProducto.Text = "INGRESAR PRODUCTO";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(61, 102);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(20, 20);
            this.txtIdProducto.TabIndex = 1;
            // 
            // txtEditarNombreProducto
            // 
            this.txtEditarNombreProducto.Depth = 0;
            this.txtEditarNombreProducto.Hint = "Nombre Producto";
            this.txtEditarNombreProducto.Location = new System.Drawing.Point(28, 134);
            this.txtEditarNombreProducto.MaxLength = 32767;
            this.txtEditarNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEditarNombreProducto.Name = "txtEditarNombreProducto";
            this.txtEditarNombreProducto.PasswordChar = '\0';
            this.txtEditarNombreProducto.SelectedText = "";
            this.txtEditarNombreProducto.SelectionLength = 0;
            this.txtEditarNombreProducto.SelectionStart = 0;
            this.txtEditarNombreProducto.Size = new System.Drawing.Size(216, 23);
            this.txtEditarNombreProducto.TabIndex = 2;
            this.txtEditarNombreProducto.TabStop = false;
            this.txtEditarNombreProducto.UseSystemPasswordChar = false;
            // 
            // txtEditarCodigo
            // 
            this.txtEditarCodigo.Depth = 0;
            this.txtEditarCodigo.Hint = "Codigo Referencia";
            this.txtEditarCodigo.Location = new System.Drawing.Point(28, 184);
            this.txtEditarCodigo.MaxLength = 32767;
            this.txtEditarCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEditarCodigo.Name = "txtEditarCodigo";
            this.txtEditarCodigo.PasswordChar = '\0';
            this.txtEditarCodigo.SelectedText = "";
            this.txtEditarCodigo.SelectionLength = 0;
            this.txtEditarCodigo.SelectionStart = 0;
            this.txtEditarCodigo.Size = new System.Drawing.Size(216, 23);
            this.txtEditarCodigo.TabIndex = 3;
            this.txtEditarCodigo.TabStop = false;
            this.txtEditarCodigo.UseSystemPasswordChar = false;
            // 
            // txtEditarPrecioCompra
            // 
            this.txtEditarPrecioCompra.Depth = 0;
            this.txtEditarPrecioCompra.Hint = "Precio Compra";
            this.txtEditarPrecioCompra.Location = new System.Drawing.Point(28, 238);
            this.txtEditarPrecioCompra.MaxLength = 32767;
            this.txtEditarPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEditarPrecioCompra.Name = "txtEditarPrecioCompra";
            this.txtEditarPrecioCompra.PasswordChar = '\0';
            this.txtEditarPrecioCompra.SelectedText = "";
            this.txtEditarPrecioCompra.SelectionLength = 0;
            this.txtEditarPrecioCompra.SelectionStart = 0;
            this.txtEditarPrecioCompra.Size = new System.Drawing.Size(216, 23);
            this.txtEditarPrecioCompra.TabIndex = 4;
            this.txtEditarPrecioCompra.TabStop = false;
            this.txtEditarPrecioCompra.UseSystemPasswordChar = false;
            // 
            // txtEditarPrecioVenta
            // 
            this.txtEditarPrecioVenta.Depth = 0;
            this.txtEditarPrecioVenta.Hint = "Precio Venta";
            this.txtEditarPrecioVenta.Location = new System.Drawing.Point(28, 290);
            this.txtEditarPrecioVenta.MaxLength = 32767;
            this.txtEditarPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEditarPrecioVenta.Name = "txtEditarPrecioVenta";
            this.txtEditarPrecioVenta.PasswordChar = '\0';
            this.txtEditarPrecioVenta.SelectedText = "";
            this.txtEditarPrecioVenta.SelectionLength = 0;
            this.txtEditarPrecioVenta.SelectionStart = 0;
            this.txtEditarPrecioVenta.Size = new System.Drawing.Size(216, 23);
            this.txtEditarPrecioVenta.TabIndex = 5;
            this.txtEditarPrecioVenta.TabStop = false;
            this.txtEditarPrecioVenta.UseSystemPasswordChar = false;
            // 
            // txtEditarStock
            // 
            this.txtEditarStock.Depth = 0;
            this.txtEditarStock.Hint = "Cantidad Stock";
            this.txtEditarStock.Location = new System.Drawing.Point(28, 345);
            this.txtEditarStock.MaxLength = 32767;
            this.txtEditarStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEditarStock.Name = "txtEditarStock";
            this.txtEditarStock.PasswordChar = '\0';
            this.txtEditarStock.SelectedText = "";
            this.txtEditarStock.SelectionLength = 0;
            this.txtEditarStock.SelectionStart = 0;
            this.txtEditarStock.Size = new System.Drawing.Size(216, 23);
            this.txtEditarStock.TabIndex = 6;
            this.txtEditarStock.TabStop = false;
            this.txtEditarStock.UseSystemPasswordChar = false;
            // 
            // txtEditarRuta
            // 
            this.txtEditarRuta.Depth = 0;
            this.txtEditarRuta.Hint = "Ruta Imagen";
            this.txtEditarRuta.Location = new System.Drawing.Point(291, 196);
            this.txtEditarRuta.MaxLength = 32767;
            this.txtEditarRuta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEditarRuta.Name = "txtEditarRuta";
            this.txtEditarRuta.PasswordChar = '\0';
            this.txtEditarRuta.SelectedText = "";
            this.txtEditarRuta.SelectionLength = 0;
            this.txtEditarRuta.SelectionStart = 0;
            this.txtEditarRuta.Size = new System.Drawing.Size(216, 23);
            this.txtEditarRuta.TabIndex = 7;
            this.txtEditarRuta.TabStop = false;
            this.txtEditarRuta.UseSystemPasswordChar = false;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(386, 136);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 8;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoria.Location = new System.Drawing.Point(287, 138);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(74, 19);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Depth = 0;
            this.lblDetalles.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetalles.Location = new System.Drawing.Point(287, 262);
            this.lblDetalles.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(129, 19);
            this.lblDetalles.TabIndex = 10;
            this.lblDetalles.Text = "Detalles Producto";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(291, 300);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(216, 137);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.AutoSize = true;
            this.btnActualizarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarProducto.Depth = 0;
            this.btnActualizarProducto.Icon = null;
            this.btnActualizarProducto.Location = new System.Drawing.Point(141, 418);
            this.btnActualizarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Primary = true;
            this.btnActualizarProducto.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarProducto.TabIndex = 12;
            this.btnActualizarProducto.Text = "ACTUALIZAR";
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // btnEditarSalir
            // 
            this.btnEditarSalir.AutoSize = true;
            this.btnEditarSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarSalir.Depth = 0;
            this.btnEditarSalir.Icon = null;
            this.btnEditarSalir.Location = new System.Drawing.Point(28, 418);
            this.btnEditarSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarSalir.Name = "btnEditarSalir";
            this.btnEditarSalir.Primary = true;
            this.btnEditarSalir.Size = new System.Drawing.Size(58, 36);
            this.btnEditarSalir.TabIndex = 13;
            this.btnEditarSalir.Text = "SALIR";
            this.btnEditarSalir.UseVisualStyleBackColor = true;
            this.btnEditarSalir.Click += new System.EventHandler(this.btnEditarSalir_Click);
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Depth = 0;
            this.lblIdProducto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdProducto.Location = new System.Drawing.Point(24, 102);
            this.lblIdProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(31, 19);
            this.lblIdProducto.TabIndex = 14;
            this.lblIdProducto.Text = "ID: ";
            // 
            // FrmEditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 479);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.btnEditarSalir);
            this.Controls.Add(this.btnActualizarProducto);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtEditarRuta);
            this.Controls.Add(this.txtEditarStock);
            this.Controls.Add(this.txtEditarPrecioVenta);
            this.Controls.Add(this.txtEditarPrecioCompra);
            this.Controls.Add(this.txtEditarCodigo);
            this.Controls.Add(this.txtEditarNombreProducto);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.lblTituloEditarProducto);
            this.Name = "FrmEditarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.FrmEditarProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloEditarProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEditarNombreProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEditarCodigo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEditarPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEditarPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEditarStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEditarRuta;
        private System.Windows.Forms.ComboBox cboCategoria;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialLabel lblDetalles;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditarSalir;
        private MaterialSkin.Controls.MaterialLabel lblIdProducto;
    }
}