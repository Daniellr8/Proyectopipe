namespace Pantallas_Sistema_facturación
{
    partial class FrmEditarCliente
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
            this.TxtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTituloEditarCliente = new MaterialSkin.Controls.MaterialLabel();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new MaterialSkin.Controls.MaterialLabel();
            this.epValidarClientes = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epValidarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Depth = 0;
            this.TxtNombre.Hint = "Nombre Cliente";
            this.TxtNombre.Location = new System.Drawing.Point(46, 186);
            this.TxtNombre.MaxLength = 32767;
            this.TxtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.SelectionLength = 0;
            this.TxtNombre.SelectionStart = 0;
            this.TxtNombre.Size = new System.Drawing.Size(250, 23);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.UseSystemPasswordChar = false;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Depth = 0;
            this.TxtDocumento.Hint = "Documento";
            this.TxtDocumento.Location = new System.Drawing.Point(46, 215);
            this.TxtDocumento.MaxLength = 32767;
            this.TxtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.PasswordChar = '\0';
            this.TxtDocumento.SelectedText = "";
            this.TxtDocumento.SelectionLength = 0;
            this.TxtDocumento.SelectionStart = 0;
            this.TxtDocumento.Size = new System.Drawing.Size(111, 23);
            this.TxtDocumento.TabIndex = 1;
            this.TxtDocumento.TabStop = false;
            this.TxtDocumento.UseSystemPasswordChar = false;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Depth = 0;
            this.TxtDireccion.Hint = "Dirección";
            this.TxtDireccion.Location = new System.Drawing.Point(46, 244);
            this.TxtDireccion.MaxLength = 32767;
            this.TxtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.PasswordChar = '\0';
            this.TxtDireccion.SelectedText = "";
            this.TxtDireccion.SelectionLength = 0;
            this.TxtDireccion.SelectionStart = 0;
            this.TxtDireccion.Size = new System.Drawing.Size(189, 23);
            this.TxtDireccion.TabIndex = 2;
            this.TxtDireccion.TabStop = false;
            this.TxtDireccion.UseSystemPasswordChar = false;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Depth = 0;
            this.TxtTelefono.Hint = "Telefono";
            this.TxtTelefono.Location = new System.Drawing.Point(46, 273);
            this.TxtTelefono.MaxLength = 32767;
            this.TxtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.PasswordChar = '\0';
            this.TxtTelefono.SelectedText = "";
            this.TxtTelefono.SelectionLength = 0;
            this.TxtTelefono.SelectionStart = 0;
            this.TxtTelefono.Size = new System.Drawing.Size(111, 23);
            this.TxtTelefono.TabIndex = 3;
            this.TxtTelefono.TabStop = false;
            this.TxtTelefono.UseSystemPasswordChar = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Depth = 0;
            this.TxtEmail.Hint = "Email";
            this.TxtEmail.Location = new System.Drawing.Point(46, 302);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.Size = new System.Drawing.Size(75, 23);
            this.TxtEmail.TabIndex = 4;
            this.TxtEmail.TabStop = false;
            this.TxtEmail.UseSystemPasswordChar = false;
            // 
            // lblTituloEditarCliente
            // 
            this.lblTituloEditarCliente.AutoSize = true;
            this.lblTituloEditarCliente.Depth = 0;
            this.lblTituloEditarCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloEditarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloEditarCliente.Location = new System.Drawing.Point(109, 87);
            this.lblTituloEditarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloEditarCliente.Name = "lblTituloEditarCliente";
            this.lblTituloEditarCliente.Size = new System.Drawing.Size(48, 19);
            this.lblTituloEditarCliente.TabIndex = 5;
            this.lblTituloEditarCliente.Text = "Titulo";
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(76, 369);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(266, 369);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(76, 148);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(25, 20);
            this.TxtIdCliente.TabIndex = 9;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Depth = 0;
            this.lblIdCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIdCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdCliente.Location = new System.Drawing.Point(42, 149);
            this.lblIdCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(31, 19);
            this.lblIdCliente.TabIndex = 10;
            this.lblIdCliente.Text = "ID: ";
            // 
            // epValidarClientes
            // 
            this.epValidarClientes.ContainerControl = this;
            // 
            // FrmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.TxtIdCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblTituloEditarCliente);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.TxtNombre);
            this.Name = "FrmEditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.FrmEditarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epValidarClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtEmail;
        private MaterialSkin.Controls.MaterialLabel lblTituloEditarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private MaterialSkin.Controls.MaterialLabel lblIdCliente;
        private System.Windows.Forms.ErrorProvider epValidarClientes;
    }
}