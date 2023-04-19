namespace Pantallas_Sistema_facturación
{
    partial class FrmListaEmpleados
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
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.idEmpleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmpleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarEmpleado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrarEmpleado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSalirEmpleados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevoEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTituloEmpleados = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleados,
            this.NombreEmpleados,
            this.documentoEmpleado,
            this.telefonoEmpleado,
            this.btnEditarEmpleado,
            this.btnBorrarEmpleado});
            this.dgEmpleados.Location = new System.Drawing.Point(90, 195);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.Size = new System.Drawing.Size(794, 282);
            this.dgEmpleados.TabIndex = 11;
            this.dgEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpleados_CellContentClick);
            // 
            // idEmpleados
            // 
            this.idEmpleados.HeaderText = "ID";
            this.idEmpleados.Name = "idEmpleados";
            this.idEmpleados.Width = 80;
            // 
            // NombreEmpleados
            // 
            this.NombreEmpleados.HeaderText = "NOMBRE";
            this.NombreEmpleados.Name = "NombreEmpleados";
            this.NombreEmpleados.Width = 300;
            // 
            // documentoEmpleado
            // 
            this.documentoEmpleado.HeaderText = "DOCUMENTO";
            this.documentoEmpleado.Name = "documentoEmpleado";
            // 
            // telefonoEmpleado
            // 
            this.telefonoEmpleado.HeaderText = "TELEFONO";
            this.telefonoEmpleado.Name = "telefonoEmpleado";
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.HeaderText = "EDITAR";
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditarEmpleado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditarEmpleado.Text = "EDITAR";
            this.btnEditarEmpleado.UseColumnTextForButtonValue = true;
            this.btnEditarEmpleado.Width = 80;
            // 
            // btnBorrarEmpleado
            // 
            this.btnBorrarEmpleado.HeaderText = "BORRAR";
            this.btnBorrarEmpleado.Name = "btnBorrarEmpleado";
            this.btnBorrarEmpleado.Text = "BORRAR";
            this.btnBorrarEmpleado.UseColumnTextForButtonValue = true;
            this.btnBorrarEmpleado.Width = 80;
            // 
            // btnSalirEmpleados
            // 
            this.btnSalirEmpleados.AutoSize = true;
            this.btnSalirEmpleados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirEmpleados.Depth = 0;
            this.btnSalirEmpleados.Icon = null;
            this.btnSalirEmpleados.Location = new System.Drawing.Point(826, 502);
            this.btnSalirEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirEmpleados.Name = "btnSalirEmpleados";
            this.btnSalirEmpleados.Primary = true;
            this.btnSalirEmpleados.Size = new System.Drawing.Size(58, 36);
            this.btnSalirEmpleados.TabIndex = 10;
            this.btnSalirEmpleados.Text = "SALIR";
            this.btnSalirEmpleados.UseVisualStyleBackColor = true;
            this.btnSalirEmpleados.Click += new System.EventHandler(this.btnSalirEmpleados_Click);
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.AutoSize = true;
            this.btnNuevoEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoEmpleado.Depth = 0;
            this.btnNuevoEmpleado.Icon = null;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(800, 119);
            this.btnNuevoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Primary = true;
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(66, 36);
            this.btnNuevoEmpleado.TabIndex = 9;
            this.btnNuevoEmpleado.Text = "NUEVO";
            this.btnNuevoEmpleado.UseVisualStyleBackColor = true;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.AutoSize = true;
            this.btnBuscarEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarEmpleado.Depth = 0;
            this.btnBuscarEmpleado.Icon = null;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(453, 119);
            this.btnBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Primary = true;
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarEmpleado.TabIndex = 8;
            this.btnBuscarEmpleado.Text = "BUSCAR";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.Depth = 0;
            this.txtBuscarEmpleado.Hint = "Buscar Empleado";
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(90, 132);
            this.txtBuscarEmpleado.MaxLength = 32767;
            this.txtBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.PasswordChar = '\0';
            this.txtBuscarEmpleado.SelectedText = "";
            this.txtBuscarEmpleado.SelectionLength = 0;
            this.txtBuscarEmpleado.SelectionStart = 0;
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(329, 23);
            this.txtBuscarEmpleado.TabIndex = 7;
            this.txtBuscarEmpleado.TabStop = false;
            this.txtBuscarEmpleado.UseSystemPasswordChar = false;
            // 
            // lblTituloEmpleados
            // 
            this.lblTituloEmpleados.AutoSize = true;
            this.lblTituloEmpleados.Depth = 0;
            this.lblTituloEmpleados.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloEmpleados.Location = new System.Drawing.Point(367, 59);
            this.lblTituloEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloEmpleados.Name = "lblTituloEmpleados";
            this.lblTituloEmpleados.Size = new System.Drawing.Size(224, 19);
            this.lblTituloEmpleados.TabIndex = 6;
            this.lblTituloEmpleados.Text = "ADMINISTRACIÓN EMPLEADOS";
            // 
            // FrmListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 582);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.btnSalirEmpleados);
            this.Controls.Add(this.btnNuevoEmpleado);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.txtBuscarEmpleado);
            this.Controls.Add(this.lblTituloEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaEmpleados";
            this.Load += new System.EventHandler(this.FrmListaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmpleados;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirEmpleados;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblTituloEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoEmpleado;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditarEmpleado;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrarEmpleado;
    }
}