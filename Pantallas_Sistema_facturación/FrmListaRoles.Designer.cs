namespace Pantallas_Sistema_facturación
{
    partial class FrmListaRoles
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
            this.dgRoles = new System.Windows.Forms.DataGridView();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarRoles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrarRoles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSalirRoles = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevoRoles = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarRoles = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarRoles = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTituloRoles = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRoles
            // 
            this.dgRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRol,
            this.idEmpleado,
            this.roles,
            this.btnEditarRoles,
            this.btnBorrarRoles});
            this.dgRoles.Location = new System.Drawing.Point(161, 201);
            this.dgRoles.Name = "dgRoles";
            this.dgRoles.Size = new System.Drawing.Size(524, 292);
            this.dgRoles.TabIndex = 11;
            this.dgRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRoles_CellContentClick);
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "ID";
            this.IdRol.Name = "IdRol";
            this.IdRol.Width = 80;
            // 
            // idEmpleado
            // 
            this.idEmpleado.HeaderText = "EMPLEADO";
            this.idEmpleado.Name = "idEmpleado";
            // 
            // roles
            // 
            this.roles.HeaderText = "ROL";
            this.roles.Name = "roles";
            // 
            // btnEditarRoles
            // 
            this.btnEditarRoles.HeaderText = "EDITAR";
            this.btnEditarRoles.Name = "btnEditarRoles";
            this.btnEditarRoles.Text = "EDITAR";
            this.btnEditarRoles.UseColumnTextForButtonValue = true;
            // 
            // btnBorrarRoles
            // 
            this.btnBorrarRoles.HeaderText = "BORRAR";
            this.btnBorrarRoles.Name = "btnBorrarRoles";
            this.btnBorrarRoles.Text = "BORRAR";
            this.btnBorrarRoles.UseColumnTextForButtonValue = true;
            // 
            // btnSalirRoles
            // 
            this.btnSalirRoles.AutoSize = true;
            this.btnSalirRoles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirRoles.Depth = 0;
            this.btnSalirRoles.Icon = null;
            this.btnSalirRoles.Location = new System.Drawing.Point(850, 507);
            this.btnSalirRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirRoles.Name = "btnSalirRoles";
            this.btnSalirRoles.Primary = true;
            this.btnSalirRoles.Size = new System.Drawing.Size(58, 36);
            this.btnSalirRoles.TabIndex = 10;
            this.btnSalirRoles.Text = "SALIR";
            this.btnSalirRoles.UseVisualStyleBackColor = true;
            this.btnSalirRoles.Click += new System.EventHandler(this.btnSalirRoles_Click);
            // 
            // btnNuevoRoles
            // 
            this.btnNuevoRoles.AutoSize = true;
            this.btnNuevoRoles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoRoles.Depth = 0;
            this.btnNuevoRoles.Icon = null;
            this.btnNuevoRoles.Location = new System.Drawing.Point(691, 304);
            this.btnNuevoRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoRoles.Name = "btnNuevoRoles";
            this.btnNuevoRoles.Primary = true;
            this.btnNuevoRoles.Size = new System.Drawing.Size(66, 36);
            this.btnNuevoRoles.TabIndex = 9;
            this.btnNuevoRoles.Text = "NUEVO";
            this.btnNuevoRoles.UseVisualStyleBackColor = true;
            this.btnNuevoRoles.Click += new System.EventHandler(this.btnNuevoRoles_Click);
            // 
            // btnBuscarRoles
            // 
            this.btnBuscarRoles.AutoSize = true;
            this.btnBuscarRoles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarRoles.Depth = 0;
            this.btnBuscarRoles.Icon = null;
            this.btnBuscarRoles.Location = new System.Drawing.Point(691, 119);
            this.btnBuscarRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarRoles.Name = "btnBuscarRoles";
            this.btnBuscarRoles.Primary = true;
            this.btnBuscarRoles.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarRoles.TabIndex = 8;
            this.btnBuscarRoles.Text = "BUSCAR";
            this.btnBuscarRoles.UseVisualStyleBackColor = true;
            this.btnBuscarRoles.Click += new System.EventHandler(this.btnBuscarRoles_Click);
            // 
            // txtBuscarRoles
            // 
            this.txtBuscarRoles.Depth = 0;
            this.txtBuscarRoles.Hint = "Buscar Roles";
            this.txtBuscarRoles.Location = new System.Drawing.Point(231, 132);
            this.txtBuscarRoles.MaxLength = 32767;
            this.txtBuscarRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarRoles.Name = "txtBuscarRoles";
            this.txtBuscarRoles.PasswordChar = '\0';
            this.txtBuscarRoles.SelectedText = "";
            this.txtBuscarRoles.SelectionLength = 0;
            this.txtBuscarRoles.SelectionStart = 0;
            this.txtBuscarRoles.Size = new System.Drawing.Size(395, 23);
            this.txtBuscarRoles.TabIndex = 7;
            this.txtBuscarRoles.TabStop = false;
            this.txtBuscarRoles.UseSystemPasswordChar = false;
            // 
            // lblTituloRoles
            // 
            this.lblTituloRoles.AutoSize = true;
            this.lblTituloRoles.Depth = 0;
            this.lblTituloRoles.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloRoles.Location = new System.Drawing.Point(310, 58);
            this.lblTituloRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloRoles.Name = "lblTituloRoles";
            this.lblTituloRoles.Size = new System.Drawing.Size(205, 38);
            this.lblTituloRoles.TabIndex = 6;
            this.lblTituloRoles.Text = "ADMINISTRACIÓN DE ROLES\r\n\r\n";
            // 
            // FrmListaRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 610);
            this.Controls.Add(this.dgRoles);
            this.Controls.Add(this.btnSalirRoles);
            this.Controls.Add(this.btnNuevoRoles);
            this.Controls.Add(this.btnBuscarRoles);
            this.Controls.Add(this.txtBuscarRoles);
            this.Controls.Add(this.lblTituloRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaRoles";
            this.Load += new System.EventHandler(this.FrmListaRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRoles;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirRoles;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoRoles;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarRoles;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarRoles;
        private MaterialSkin.Controls.MaterialLabel lblTituloRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn roles;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditarRoles;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrarRoles;
    }
}