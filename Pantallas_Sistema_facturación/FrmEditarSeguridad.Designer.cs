namespace Pantallas_Sistema_facturación
{
    partial class FrmEditarSeguridad
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
            this.btnEditarSalirSeguridad = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarSeguridad = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblEditarEmpleadoSeguridad = new MaterialSkin.Controls.MaterialLabel();
            this.cboEditarEmpleado = new System.Windows.Forms.ComboBox();
            this.txtEditarClaveSeguridad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEditarUsuarioSeguridad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTituloEditarSeguridad = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnEditarSalirSeguridad
            // 
            this.btnEditarSalirSeguridad.AutoSize = true;
            this.btnEditarSalirSeguridad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarSalirSeguridad.Depth = 0;
            this.btnEditarSalirSeguridad.Icon = null;
            this.btnEditarSalirSeguridad.Location = new System.Drawing.Point(319, 371);
            this.btnEditarSalirSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarSalirSeguridad.Name = "btnEditarSalirSeguridad";
            this.btnEditarSalirSeguridad.Primary = true;
            this.btnEditarSalirSeguridad.Size = new System.Drawing.Size(58, 36);
            this.btnEditarSalirSeguridad.TabIndex = 27;
            this.btnEditarSalirSeguridad.Text = "SALIR";
            this.btnEditarSalirSeguridad.UseVisualStyleBackColor = true;
            this.btnEditarSalirSeguridad.Click += new System.EventHandler(this.btnEditarSalir_Click);
            // 
            // btnActualizarSeguridad
            // 
            this.btnActualizarSeguridad.AutoSize = true;
            this.btnActualizarSeguridad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarSeguridad.Depth = 0;
            this.btnActualizarSeguridad.Icon = null;
            this.btnActualizarSeguridad.Location = new System.Drawing.Point(67, 371);
            this.btnActualizarSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarSeguridad.Name = "btnActualizarSeguridad";
            this.btnActualizarSeguridad.Primary = true;
            this.btnActualizarSeguridad.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarSeguridad.TabIndex = 26;
            this.btnActualizarSeguridad.Text = "ACTUALIZAR";
            this.btnActualizarSeguridad.UseVisualStyleBackColor = true;
            this.btnActualizarSeguridad.Click += new System.EventHandler(this.btnActualizarSeguridad_Click);
            // 
            // lblEditarEmpleadoSeguridad
            // 
            this.lblEditarEmpleadoSeguridad.AutoSize = true;
            this.lblEditarEmpleadoSeguridad.Depth = 0;
            this.lblEditarEmpleadoSeguridad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEditarEmpleadoSeguridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEditarEmpleadoSeguridad.Location = new System.Drawing.Point(34, 148);
            this.lblEditarEmpleadoSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEditarEmpleadoSeguridad.Name = "lblEditarEmpleadoSeguridad";
            this.lblEditarEmpleadoSeguridad.Size = new System.Drawing.Size(74, 19);
            this.lblEditarEmpleadoSeguridad.TabIndex = 23;
            this.lblEditarEmpleadoSeguridad.Text = "Categoria";
            // 
            // cboEditarEmpleado
            // 
            this.cboEditarEmpleado.FormattingEnabled = true;
            this.cboEditarEmpleado.Location = new System.Drawing.Point(133, 149);
            this.cboEditarEmpleado.Name = "cboEditarEmpleado";
            this.cboEditarEmpleado.Size = new System.Drawing.Size(253, 21);
            this.cboEditarEmpleado.TabIndex = 22;
            // 
            // txtEditarClaveSeguridad
            // 
            this.txtEditarClaveSeguridad.Depth = 0;
            this.txtEditarClaveSeguridad.Hint = "Clave";
            this.txtEditarClaveSeguridad.Location = new System.Drawing.Point(38, 260);
            this.txtEditarClaveSeguridad.MaxLength = 32767;
            this.txtEditarClaveSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEditarClaveSeguridad.Name = "txtEditarClaveSeguridad";
            this.txtEditarClaveSeguridad.PasswordChar = '\0';
            this.txtEditarClaveSeguridad.SelectedText = "";
            this.txtEditarClaveSeguridad.SelectionLength = 0;
            this.txtEditarClaveSeguridad.SelectionStart = 0;
            this.txtEditarClaveSeguridad.Size = new System.Drawing.Size(216, 23);
            this.txtEditarClaveSeguridad.TabIndex = 17;
            this.txtEditarClaveSeguridad.TabStop = false;
            this.txtEditarClaveSeguridad.UseSystemPasswordChar = false;
            // 
            // txtEditarUsuarioSeguridad
            // 
            this.txtEditarUsuarioSeguridad.Depth = 0;
            this.txtEditarUsuarioSeguridad.Hint = "Usuario";
            this.txtEditarUsuarioSeguridad.Location = new System.Drawing.Point(38, 214);
            this.txtEditarUsuarioSeguridad.MaxLength = 32767;
            this.txtEditarUsuarioSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEditarUsuarioSeguridad.Name = "txtEditarUsuarioSeguridad";
            this.txtEditarUsuarioSeguridad.PasswordChar = '\0';
            this.txtEditarUsuarioSeguridad.SelectedText = "";
            this.txtEditarUsuarioSeguridad.SelectionLength = 0;
            this.txtEditarUsuarioSeguridad.SelectionStart = 0;
            this.txtEditarUsuarioSeguridad.Size = new System.Drawing.Size(216, 23);
            this.txtEditarUsuarioSeguridad.TabIndex = 16;
            this.txtEditarUsuarioSeguridad.TabStop = false;
            this.txtEditarUsuarioSeguridad.UseSystemPasswordChar = false;
            // 
            // lblTituloEditarSeguridad
            // 
            this.lblTituloEditarSeguridad.AutoSize = true;
            this.lblTituloEditarSeguridad.Depth = 0;
            this.lblTituloEditarSeguridad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloEditarSeguridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloEditarSeguridad.Location = new System.Drawing.Point(129, 98);
            this.lblTituloEditarSeguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloEditarSeguridad.Name = "lblTituloEditarSeguridad";
            this.lblTituloEditarSeguridad.Size = new System.Drawing.Size(161, 19);
            this.lblTituloEditarSeguridad.TabIndex = 14;
            this.lblTituloEditarSeguridad.Text = "INGRESAR PRODUCTO";
            // 
            // FrmEditarSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.btnEditarSalirSeguridad);
            this.Controls.Add(this.btnActualizarSeguridad);
            this.Controls.Add(this.lblEditarEmpleadoSeguridad);
            this.Controls.Add(this.cboEditarEmpleado);
            this.Controls.Add(this.txtEditarClaveSeguridad);
            this.Controls.Add(this.txtEditarUsuarioSeguridad);
            this.Controls.Add(this.lblTituloEditarSeguridad);
            this.Name = "FrmEditarSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEGURIDAD";
            this.Load += new System.EventHandler(this.FrmEditarSeguridad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnEditarSalirSeguridad;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarSeguridad;
        private MaterialSkin.Controls.MaterialLabel lblEditarEmpleadoSeguridad;
        private System.Windows.Forms.ComboBox cboEditarEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEditarClaveSeguridad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEditarUsuarioSeguridad;
        private MaterialSkin.Controls.MaterialLabel lblTituloEditarSeguridad;
    }
}