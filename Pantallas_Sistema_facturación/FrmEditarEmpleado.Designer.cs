namespace Pantallas_Sistema_facturación
{
    partial class FrmEditarEmpleado
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
            this.TxtIdEmpleado = new System.Windows.Forms.TextBox();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblTituloEditarEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.TxtEmailEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtTelefonoEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDireccionEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDocumentoEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombreEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblRolEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaIngreso = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaRetiro = new MaterialSkin.Controls.MaterialLabel();
            this.lblDatosAdicionales = new MaterialSkin.Controls.MaterialLabel();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.dtmFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtmFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.txtDatosAdicionales = new System.Windows.Forms.RichTextBox();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtIdEmpleado
            // 
            this.TxtIdEmpleado.Location = new System.Drawing.Point(37, 121);
            this.TxtIdEmpleado.Name = "TxtIdEmpleado";
            this.TxtIdEmpleado.Size = new System.Drawing.Size(25, 20);
            this.TxtIdEmpleado.TabIndex = 18;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(487, 490);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.AutoSize = true;
            this.btnActualizarEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarEmpleado.Depth = 0;
            this.btnActualizarEmpleado.Icon = null;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(45, 466);
            this.btnActualizarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Primary = true;
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarEmpleado.TabIndex = 16;
            this.btnActualizarEmpleado.Text = "ACTUALIZAR";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = true;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblTituloEditarEmpleado
            // 
            this.lblTituloEditarEmpleado.AutoSize = true;
            this.lblTituloEditarEmpleado.Depth = 0;
            this.lblTituloEditarEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloEditarEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloEditarEmpleado.Location = new System.Drawing.Point(100, 88);
            this.lblTituloEditarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloEditarEmpleado.Name = "lblTituloEditarEmpleado";
            this.lblTituloEditarEmpleado.Size = new System.Drawing.Size(48, 19);
            this.lblTituloEditarEmpleado.TabIndex = 15;
            this.lblTituloEditarEmpleado.Text = "Titulo";
            // 
            // TxtEmailEmpleado
            // 
            this.TxtEmailEmpleado.Depth = 0;
            this.TxtEmailEmpleado.Hint = "Email";
            this.TxtEmailEmpleado.Location = new System.Drawing.Point(37, 327);
            this.TxtEmailEmpleado.MaxLength = 32767;
            this.TxtEmailEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtEmailEmpleado.Name = "TxtEmailEmpleado";
            this.TxtEmailEmpleado.PasswordChar = '\0';
            this.TxtEmailEmpleado.SelectedText = "";
            this.TxtEmailEmpleado.SelectionLength = 0;
            this.TxtEmailEmpleado.SelectionStart = 0;
            this.TxtEmailEmpleado.Size = new System.Drawing.Size(75, 23);
            this.TxtEmailEmpleado.TabIndex = 14;
            this.TxtEmailEmpleado.TabStop = false;
            this.TxtEmailEmpleado.UseSystemPasswordChar = false;
            // 
            // TxtTelefonoEmpleado
            // 
            this.TxtTelefonoEmpleado.Depth = 0;
            this.TxtTelefonoEmpleado.Hint = "Telefono";
            this.TxtTelefonoEmpleado.Location = new System.Drawing.Point(37, 288);
            this.TxtTelefonoEmpleado.MaxLength = 32767;
            this.TxtTelefonoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTelefonoEmpleado.Name = "TxtTelefonoEmpleado";
            this.TxtTelefonoEmpleado.PasswordChar = '\0';
            this.TxtTelefonoEmpleado.SelectedText = "";
            this.TxtTelefonoEmpleado.SelectionLength = 0;
            this.TxtTelefonoEmpleado.SelectionStart = 0;
            this.TxtTelefonoEmpleado.Size = new System.Drawing.Size(111, 23);
            this.TxtTelefonoEmpleado.TabIndex = 13;
            this.TxtTelefonoEmpleado.TabStop = false;
            this.TxtTelefonoEmpleado.UseSystemPasswordChar = false;
            // 
            // TxtDireccionEmpleado
            // 
            this.TxtDireccionEmpleado.Depth = 0;
            this.TxtDireccionEmpleado.Hint = "Dirección";
            this.TxtDireccionEmpleado.Location = new System.Drawing.Point(37, 246);
            this.TxtDireccionEmpleado.MaxLength = 32767;
            this.TxtDireccionEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDireccionEmpleado.Name = "TxtDireccionEmpleado";
            this.TxtDireccionEmpleado.PasswordChar = '\0';
            this.TxtDireccionEmpleado.SelectedText = "";
            this.TxtDireccionEmpleado.SelectionLength = 0;
            this.TxtDireccionEmpleado.SelectionStart = 0;
            this.TxtDireccionEmpleado.Size = new System.Drawing.Size(189, 23);
            this.TxtDireccionEmpleado.TabIndex = 12;
            this.TxtDireccionEmpleado.TabStop = false;
            this.TxtDireccionEmpleado.UseSystemPasswordChar = false;
            // 
            // TxtDocumentoEmpleado
            // 
            this.TxtDocumentoEmpleado.Depth = 0;
            this.TxtDocumentoEmpleado.Hint = "Documento";
            this.TxtDocumentoEmpleado.Location = new System.Drawing.Point(37, 205);
            this.TxtDocumentoEmpleado.MaxLength = 32767;
            this.TxtDocumentoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDocumentoEmpleado.Name = "TxtDocumentoEmpleado";
            this.TxtDocumentoEmpleado.PasswordChar = '\0';
            this.TxtDocumentoEmpleado.SelectedText = "";
            this.TxtDocumentoEmpleado.SelectionLength = 0;
            this.TxtDocumentoEmpleado.SelectionStart = 0;
            this.TxtDocumentoEmpleado.Size = new System.Drawing.Size(111, 23);
            this.TxtDocumentoEmpleado.TabIndex = 11;
            this.TxtDocumentoEmpleado.TabStop = false;
            this.TxtDocumentoEmpleado.UseSystemPasswordChar = false;
            // 
            // TxtNombreEmpleado
            // 
            this.TxtNombreEmpleado.Depth = 0;
            this.TxtNombreEmpleado.Hint = "Nombre Empleado";
            this.TxtNombreEmpleado.Location = new System.Drawing.Point(37, 167);
            this.TxtNombreEmpleado.MaxLength = 32767;
            this.TxtNombreEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombreEmpleado.Name = "TxtNombreEmpleado";
            this.TxtNombreEmpleado.PasswordChar = '\0';
            this.TxtNombreEmpleado.SelectedText = "";
            this.TxtNombreEmpleado.SelectionLength = 0;
            this.TxtNombreEmpleado.SelectionStart = 0;
            this.TxtNombreEmpleado.Size = new System.Drawing.Size(250, 23);
            this.TxtNombreEmpleado.TabIndex = 10;
            this.TxtNombreEmpleado.TabStop = false;
            this.TxtNombreEmpleado.UseSystemPasswordChar = false;
            // 
            // lblRolEmpleado
            // 
            this.lblRolEmpleado.AutoSize = true;
            this.lblRolEmpleado.Depth = 0;
            this.lblRolEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRolEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRolEmpleado.Location = new System.Drawing.Point(321, 171);
            this.lblRolEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRolEmpleado.Name = "lblRolEmpleado";
            this.lblRolEmpleado.Size = new System.Drawing.Size(102, 19);
            this.lblRolEmpleado.TabIndex = 19;
            this.lblRolEmpleado.Text = "Rol Empleado";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Depth = 0;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaIngreso.Location = new System.Drawing.Point(320, 209);
            this.lblFechaIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(103, 19);
            this.lblFechaIngreso.TabIndex = 20;
            this.lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // lblFechaRetiro
            // 
            this.lblFechaRetiro.AutoSize = true;
            this.lblFechaRetiro.Depth = 0;
            this.lblFechaRetiro.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaRetiro.Location = new System.Drawing.Point(321, 250);
            this.lblFechaRetiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaRetiro.Name = "lblFechaRetiro";
            this.lblFechaRetiro.Size = new System.Drawing.Size(93, 19);
            this.lblFechaRetiro.TabIndex = 21;
            this.lblFechaRetiro.Text = "Fecha Retiro";
            // 
            // lblDatosAdicionales
            // 
            this.lblDatosAdicionales.AutoSize = true;
            this.lblDatosAdicionales.Depth = 0;
            this.lblDatosAdicionales.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDatosAdicionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatosAdicionales.Location = new System.Drawing.Point(320, 288);
            this.lblDatosAdicionales.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDatosAdicionales.Name = "lblDatosAdicionales";
            this.lblDatosAdicionales.Size = new System.Drawing.Size(156, 19);
            this.lblDatosAdicionales.TabIndex = 22;
            this.lblDatosAdicionales.Text = "DATOS ADICIONALES";
            // 
            // cboRol
            // 
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(437, 171);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(121, 21);
            this.cboRol.TabIndex = 23;
            // 
            // dtmFechaIngreso
            // 
            this.dtmFechaIngreso.Location = new System.Drawing.Point(437, 209);
            this.dtmFechaIngreso.Name = "dtmFechaIngreso";
            this.dtmFechaIngreso.Size = new System.Drawing.Size(121, 20);
            this.dtmFechaIngreso.TabIndex = 24;
            // 
            // dtmFechaRetiro
            // 
            this.dtmFechaRetiro.Location = new System.Drawing.Point(437, 248);
            this.dtmFechaRetiro.Name = "dtmFechaRetiro";
            this.dtmFechaRetiro.Size = new System.Drawing.Size(121, 20);
            this.dtmFechaRetiro.TabIndex = 25;
            // 
            // txtDatosAdicionales
            // 
            this.txtDatosAdicionales.Location = new System.Drawing.Point(324, 310);
            this.txtDatosAdicionales.Name = "txtDatosAdicionales";
            this.txtDatosAdicionales.Size = new System.Drawing.Size(221, 137);
            this.txtDatosAdicionales.TabIndex = 26;
            this.txtDatosAdicionales.Text = "";
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // FrmEditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 554);
            this.Controls.Add(this.txtDatosAdicionales);
            this.Controls.Add(this.dtmFechaRetiro);
            this.Controls.Add(this.dtmFechaIngreso);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.lblDatosAdicionales);
            this.Controls.Add(this.lblFechaRetiro);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblRolEmpleado);
            this.Controls.Add(this.TxtIdEmpleado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizarEmpleado);
            this.Controls.Add(this.lblTituloEditarEmpleado);
            this.Controls.Add(this.TxtEmailEmpleado);
            this.Controls.Add(this.TxtTelefonoEmpleado);
            this.Controls.Add(this.TxtDireccionEmpleado);
            this.Controls.Add(this.TxtDocumentoEmpleado);
            this.Controls.Add(this.TxtNombreEmpleado);
            this.Name = "FrmEditarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPLEADOS";
            this.Load += new System.EventHandler(this.FrmEditarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIdEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblTituloEditarEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtEmailEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTelefonoEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDireccionEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDocumentoEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombreEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblRolEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblFechaIngreso;
        private MaterialSkin.Controls.MaterialLabel lblFechaRetiro;
        private MaterialSkin.Controls.MaterialLabel lblDatosAdicionales;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.DateTimePicker dtmFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtmFechaRetiro;
        private System.Windows.Forms.RichTextBox txtDatosAdicionales;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}