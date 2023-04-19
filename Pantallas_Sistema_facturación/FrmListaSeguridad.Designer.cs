namespace Pantallas_Sistema_facturación
{
    partial class FrmListaSeguridad
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
            this.btnEliminarUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConsultarUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblTituloSeguridad = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmpleadoListar = new MaterialSkin.Controls.MaterialLabel();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.txtUsuarioSeguridad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtClaveSeguridad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSalirSeguridad = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.AutoSize = true;
            this.btnEliminarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarUsuario.Depth = 0;
            this.btnEliminarUsuario.Icon = null;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(772, 258);
            this.btnEliminarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Primary = true;
            this.btnEliminarUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEliminarUsuario.Size = new System.Drawing.Size(83, 36);
            this.btnEliminarUsuario.TabIndex = 16;
            this.btnEliminarUsuario.Text = "ELIMINAR";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.AutoSize = true;
            this.btnActualizarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarUsuario.Depth = 0;
            this.btnActualizarUsuario.Icon = null;
            this.btnActualizarUsuario.Location = new System.Drawing.Point(772, 188);
            this.btnActualizarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Primary = true;
            this.btnActualizarUsuario.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarUsuario.TabIndex = 15;
            this.btnActualizarUsuario.Text = "ACTUALIZAR";
            this.btnActualizarUsuario.UseVisualStyleBackColor = true;
            this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizarUsuario_Click);
            // 
            // btnConsultarUsuario
            // 
            this.btnConsultarUsuario.AutoSize = true;
            this.btnConsultarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultarUsuario.Depth = 0;
            this.btnConsultarUsuario.Icon = null;
            this.btnConsultarUsuario.Location = new System.Drawing.Point(772, 122);
            this.btnConsultarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultarUsuario.Name = "btnConsultarUsuario";
            this.btnConsultarUsuario.Primary = true;
            this.btnConsultarUsuario.Size = new System.Drawing.Size(100, 36);
            this.btnConsultarUsuario.TabIndex = 14;
            this.btnConsultarUsuario.Text = "CONSULTAR";
            this.btnConsultarUsuario.UseVisualStyleBackColor = true;
            this.btnConsultarUsuario.Click += new System.EventHandler(this.btnConsultarUsuario_Click);
            // 
            // lblTituloSeguridad
            // 
            this.lblTituloSeguridad.AutoSize = true;
            this.lblTituloSeguridad.Depth = 0;
            this.lblTituloSeguridad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloSeguridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloSeguridad.Location = new System.Drawing.Point(410, 59);
            this.lblTituloSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloSeguridad.Name = "lblTituloSeguridad";
            this.lblTituloSeguridad.Size = new System.Drawing.Size(241, 19);
            this.lblTituloSeguridad.TabIndex = 12;
            this.lblTituloSeguridad.Text = "ADMINISTRACIÓN DE SEGURIDAD";
            // 
            // lblEmpleadoListar
            // 
            this.lblEmpleadoListar.AutoSize = true;
            this.lblEmpleadoListar.Depth = 0;
            this.lblEmpleadoListar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmpleadoListar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmpleadoListar.Location = new System.Drawing.Point(144, 139);
            this.lblEmpleadoListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleadoListar.Name = "lblEmpleadoListar";
            this.lblEmpleadoListar.Size = new System.Drawing.Size(95, 19);
            this.lblEmpleadoListar.TabIndex = 17;
            this.lblEmpleadoListar.Text = "EMPLEADO: ";
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(277, 140);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(336, 21);
            this.cboEmpleado.TabIndex = 18;
            // 
            // txtUsuarioSeguridad
            // 
            this.txtUsuarioSeguridad.Depth = 0;
            this.txtUsuarioSeguridad.Hint = "USUARÍO";
            this.txtUsuarioSeguridad.Location = new System.Drawing.Point(226, 230);
            this.txtUsuarioSeguridad.MaxLength = 32767;
            this.txtUsuarioSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuarioSeguridad.Name = "txtUsuarioSeguridad";
            this.txtUsuarioSeguridad.PasswordChar = '\0';
            this.txtUsuarioSeguridad.SelectedText = "";
            this.txtUsuarioSeguridad.SelectionLength = 0;
            this.txtUsuarioSeguridad.SelectionStart = 0;
            this.txtUsuarioSeguridad.Size = new System.Drawing.Size(362, 23);
            this.txtUsuarioSeguridad.TabIndex = 19;
            this.txtUsuarioSeguridad.TabStop = false;
            this.txtUsuarioSeguridad.UseSystemPasswordChar = false;
            // 
            // txtClaveSeguridad
            // 
            this.txtClaveSeguridad.Depth = 0;
            this.txtClaveSeguridad.Hint = "CLAVE";
            this.txtClaveSeguridad.Location = new System.Drawing.Point(226, 289);
            this.txtClaveSeguridad.MaxLength = 32767;
            this.txtClaveSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClaveSeguridad.Name = "txtClaveSeguridad";
            this.txtClaveSeguridad.PasswordChar = '\0';
            this.txtClaveSeguridad.SelectedText = "";
            this.txtClaveSeguridad.SelectionLength = 0;
            this.txtClaveSeguridad.SelectionStart = 0;
            this.txtClaveSeguridad.Size = new System.Drawing.Size(362, 23);
            this.txtClaveSeguridad.TabIndex = 20;
            this.txtClaveSeguridad.TabStop = false;
            this.txtClaveSeguridad.UseSystemPasswordChar = false;
            // 
            // btnSalirSeguridad
            // 
            this.btnSalirSeguridad.AutoSize = true;
            this.btnSalirSeguridad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirSeguridad.Depth = 0;
            this.btnSalirSeguridad.Icon = null;
            this.btnSalirSeguridad.Location = new System.Drawing.Point(772, 426);
            this.btnSalirSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirSeguridad.Name = "btnSalirSeguridad";
            this.btnSalirSeguridad.Primary = true;
            this.btnSalirSeguridad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSalirSeguridad.Size = new System.Drawing.Size(58, 36);
            this.btnSalirSeguridad.TabIndex = 21;
            this.btnSalirSeguridad.Text = "SALIR";
            this.btnSalirSeguridad.UseVisualStyleBackColor = true;
            this.btnSalirSeguridad.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // FrmListaSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 574);
            this.Controls.Add(this.btnSalirSeguridad);
            this.Controls.Add(this.txtClaveSeguridad);
            this.Controls.Add(this.txtUsuarioSeguridad);
            this.Controls.Add(this.cboEmpleado);
            this.Controls.Add(this.lblEmpleadoListar);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnActualizarUsuario);
            this.Controls.Add(this.btnConsultarUsuario);
            this.Controls.Add(this.lblTituloSeguridad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaSeguridad";
            this.Load += new System.EventHandler(this.FrmListaSeguridad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminarUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultarUsuario;
        private MaterialSkin.Controls.MaterialLabel lblTituloSeguridad;
        private MaterialSkin.Controls.MaterialLabel lblEmpleadoListar;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuarioSeguridad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClaveSeguridad;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirSeguridad;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}