namespace Pantallas_Sistema_facturación
{
    partial class FrmEditarCategorias
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
            this.components = new System.ComponentModel.Container();
            this.lblTituloCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtNombreCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnActualizarCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblCodigo = new MaterialSkin.Controls.MaterialLabel();
            this.epValidarCampos = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epValidarCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCategoria
            // 
            this.lblTituloCategoria.AutoSize = true;
            this.lblTituloCategoria.BackColor = System.Drawing.Color.Snow;
            this.lblTituloCategoria.Depth = 0;
            this.lblTituloCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloCategoria.Location = new System.Drawing.Point(95, 100);
            this.lblTituloCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloCategoria.Name = "lblTituloCategoria";
            this.lblTituloCategoria.Size = new System.Drawing.Size(219, 19);
            this.lblTituloCategoria.TabIndex = 0;
            this.lblTituloCategoria.Text = "INGRESAR NUEVA CATEGORIA";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(130, 164);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(78, 20);
            this.txtCategoria.TabIndex = 1;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Depth = 0;
            this.txtNombreCategoria.Hint = "Nombre Categoria";
            this.txtNombreCategoria.Location = new System.Drawing.Point(52, 215);
            this.txtNombreCategoria.MaxLength = 32767;
            this.txtNombreCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.PasswordChar = '\0';
            this.txtNombreCategoria.SelectedText = "";
            this.txtNombreCategoria.SelectionLength = 0;
            this.txtNombreCategoria.SelectionStart = 0;
            this.txtNombreCategoria.Size = new System.Drawing.Size(277, 23);
            this.txtNombreCategoria.TabIndex = 2;
            this.txtNombreCategoria.TabStop = false;
            this.txtNombreCategoria.UseSystemPasswordChar = false;
            // 
            // btnActualizarCategoria
            // 
            this.btnActualizarCategoria.AutoSize = true;
            this.btnActualizarCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarCategoria.Depth = 0;
            this.btnActualizarCategoria.Icon = null;
            this.btnActualizarCategoria.Location = new System.Drawing.Point(52, 317);
            this.btnActualizarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarCategoria.Name = "btnActualizarCategoria";
            this.btnActualizarCategoria.Primary = true;
            this.btnActualizarCategoria.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarCategoria.TabIndex = 3;
            this.btnActualizarCategoria.Text = "ACTUALIZAR";
            this.btnActualizarCategoria.UseVisualStyleBackColor = true;
            this.btnActualizarCategoria.Click += new System.EventHandler(this.btnActualizarCategoria_Click);
            // 
            // btnSalirCategoria
            // 
            this.btnSalirCategoria.AutoSize = true;
            this.btnSalirCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirCategoria.Depth = 0;
            this.btnSalirCategoria.Icon = null;
            this.btnSalirCategoria.Location = new System.Drawing.Point(226, 317);
            this.btnSalirCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirCategoria.Name = "btnSalirCategoria";
            this.btnSalirCategoria.Primary = true;
            this.btnSalirCategoria.Size = new System.Drawing.Size(58, 36);
            this.btnSalirCategoria.TabIndex = 4;
            this.btnSalirCategoria.Text = "SALIR";
            this.btnSalirCategoria.UseVisualStyleBackColor = true;
            this.btnSalirCategoria.Click += new System.EventHandler(this.btnSalirCategoria_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Snow;
            this.lblCodigo.Depth = 0;
            this.lblCodigo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodigo.Location = new System.Drawing.Point(48, 165);
            this.lblCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 19);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "CODIGO:";
            // 
            // epValidarCampos
            // 
            this.epValidarCampos.ContainerControl = this;
            // 
            // FrmEditarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 375);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnSalirCategoria);
            this.Controls.Add(this.btnActualizarCategoria);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblTituloCategoria);
            this.Name = "FrmEditarCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATEGORIAS";
            this.Load += new System.EventHandler(this.FrmEditarCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epValidarCampos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirCategoria;
        private MaterialSkin.Controls.MaterialLabel lblCodigo;
        private System.Windows.Forms.ErrorProvider epValidarCampos;
    }
}