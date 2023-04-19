namespace Pantallas_Sistema_facturación
{
    partial class FrmEditarRoles
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
            this.btnSalirRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizarRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtNombreRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.lblTituloEditarRol = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescripcioRol = new MaterialSkin.Controls.MaterialLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirRol
            // 
            this.btnSalirRol.AutoSize = true;
            this.btnSalirRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirRol.Depth = 0;
            this.btnSalirRol.Icon = null;
            this.btnSalirRol.Location = new System.Drawing.Point(289, 437);
            this.btnSalirRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirRol.Name = "btnSalirRol";
            this.btnSalirRol.Primary = true;
            this.btnSalirRol.Size = new System.Drawing.Size(58, 36);
            this.btnSalirRol.TabIndex = 9;
            this.btnSalirRol.Text = "SALIR";
            this.btnSalirRol.UseVisualStyleBackColor = true;
            this.btnSalirRol.Click += new System.EventHandler(this.btnSalirRol_Click);
            // 
            // btnActualizarRol
            // 
            this.btnActualizarRol.AutoSize = true;
            this.btnActualizarRol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarRol.Depth = 0;
            this.btnActualizarRol.Icon = null;
            this.btnActualizarRol.Location = new System.Drawing.Point(70, 437);
            this.btnActualizarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarRol.Name = "btnActualizarRol";
            this.btnActualizarRol.Primary = true;
            this.btnActualizarRol.Size = new System.Drawing.Size(103, 36);
            this.btnActualizarRol.TabIndex = 8;
            this.btnActualizarRol.Text = "ACTUALIZAR";
            this.btnActualizarRol.UseVisualStyleBackColor = true;
            this.btnActualizarRol.Click += new System.EventHandler(this.btnActualizarRol_Click);
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Depth = 0;
            this.txtNombreRol.Hint = "Nombre del Rol";
            this.txtNombreRol.Location = new System.Drawing.Point(55, 193);
            this.txtNombreRol.MaxLength = 32767;
            this.txtNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.PasswordChar = '\0';
            this.txtNombreRol.SelectedText = "";
            this.txtNombreRol.SelectionLength = 0;
            this.txtNombreRol.SelectionStart = 0;
            this.txtNombreRol.Size = new System.Drawing.Size(277, 23);
            this.txtNombreRol.TabIndex = 7;
            this.txtNombreRol.TabStop = false;
            this.txtNombreRol.UseSystemPasswordChar = false;
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(55, 143);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(28, 20);
            this.txtRol.TabIndex = 6;
            // 
            // lblTituloEditarRol
            // 
            this.lblTituloEditarRol.AutoSize = true;
            this.lblTituloEditarRol.BackColor = System.Drawing.Color.Snow;
            this.lblTituloEditarRol.Depth = 0;
            this.lblTituloEditarRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloEditarRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloEditarRol.Location = new System.Drawing.Point(113, 109);
            this.lblTituloEditarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloEditarRol.Name = "lblTituloEditarRol";
            this.lblTituloEditarRol.Size = new System.Drawing.Size(165, 19);
            this.lblTituloEditarRol.TabIndex = 5;
            this.lblTituloEditarRol.Text = "INGRESAR NUEVO ROL";
            // 
            // lblDescripcioRol
            // 
            this.lblDescripcioRol.AutoSize = true;
            this.lblDescripcioRol.BackColor = System.Drawing.Color.Snow;
            this.lblDescripcioRol.Depth = 0;
            this.lblDescripcioRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescripcioRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescripcioRol.Location = new System.Drawing.Point(51, 243);
            this.lblDescripcioRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcioRol.Name = "lblDescripcioRol";
            this.lblDescripcioRol.Size = new System.Drawing.Size(204, 19);
            this.lblDescripcioRol.TabIndex = 10;
            this.lblDescripcioRol.Text = "Descripción detallada del Rol";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(55, 277);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(277, 96);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // FrmEditarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 503);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblDescripcioRol);
            this.Controls.Add(this.btnSalirRol);
            this.Controls.Add(this.btnActualizarRol);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.lblTituloEditarRol);
            this.Name = "FrmEditarRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROLES";
            this.Load += new System.EventHandler(this.FrmEditarRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalirRol;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreRol;
        private System.Windows.Forms.TextBox txtRol;
        private MaterialSkin.Controls.MaterialLabel lblTituloEditarRol;
        private MaterialSkin.Controls.MaterialLabel lblDescripcioRol;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}