namespace Pantallas_Sistema_facturación
{
    partial class FrmListaCategorias
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
            this.lblTituloCategorias = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarCategorias = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevoCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgCategorias = new System.Windows.Forms.DataGridView();
            this.codigoCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCategorias
            // 
            this.lblTituloCategorias.AutoSize = true;
            this.lblTituloCategorias.Depth = 0;
            this.lblTituloCategorias.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloCategorias.Location = new System.Drawing.Point(370, 75);
            this.lblTituloCategorias.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloCategorias.Name = "lblTituloCategorias";
            this.lblTituloCategorias.Size = new System.Drawing.Size(250, 19);
            this.lblTituloCategorias.TabIndex = 0;
            this.lblTituloCategorias.Text = "ADMINISTRACIÓN DE CATEGORIAS";
            // 
            // txtBuscarCategorias
            // 
            this.txtBuscarCategorias.Depth = 0;
            this.txtBuscarCategorias.Hint = "Buscar Categoria";
            this.txtBuscarCategorias.Location = new System.Drawing.Point(190, 146);
            this.txtBuscarCategorias.MaxLength = 32767;
            this.txtBuscarCategorias.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarCategorias.Name = "txtBuscarCategorias";
            this.txtBuscarCategorias.PasswordChar = '\0';
            this.txtBuscarCategorias.SelectedText = "";
            this.txtBuscarCategorias.SelectionLength = 0;
            this.txtBuscarCategorias.SelectionStart = 0;
            this.txtBuscarCategorias.Size = new System.Drawing.Size(454, 23);
            this.txtBuscarCategorias.TabIndex = 1;
            this.txtBuscarCategorias.TabStop = false;
            this.txtBuscarCategorias.UseSystemPasswordChar = false;
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.AutoSize = true;
            this.btnBuscarCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarCategoria.Depth = 0;
            this.btnBuscarCategoria.Icon = null;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(742, 133);
            this.btnBuscarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Primary = true;
            this.btnBuscarCategoria.Size = new System.Drawing.Size(74, 36);
            this.btnBuscarCategoria.TabIndex = 2;
            this.btnBuscarCategoria.Text = "BUSCAR";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnNuevoCategoria
            // 
            this.btnNuevoCategoria.AutoSize = true;
            this.btnNuevoCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoCategoria.Depth = 0;
            this.btnNuevoCategoria.Icon = null;
            this.btnNuevoCategoria.Location = new System.Drawing.Point(750, 312);
            this.btnNuevoCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoCategoria.Name = "btnNuevoCategoria";
            this.btnNuevoCategoria.Primary = true;
            this.btnNuevoCategoria.Size = new System.Drawing.Size(66, 36);
            this.btnNuevoCategoria.TabIndex = 3;
            this.btnNuevoCategoria.Text = "NUEVO";
            this.btnNuevoCategoria.UseVisualStyleBackColor = true;
            this.btnNuevoCategoria.Click += new System.EventHandler(this.btnNuevoCategoria_Click);
            // 
            // btnSalirCategoria
            // 
            this.btnSalirCategoria.AutoSize = true;
            this.btnSalirCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirCategoria.Depth = 0;
            this.btnSalirCategoria.Icon = null;
            this.btnSalirCategoria.Location = new System.Drawing.Point(911, 526);
            this.btnSalirCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirCategoria.Name = "btnSalirCategoria";
            this.btnSalirCategoria.Primary = true;
            this.btnSalirCategoria.Size = new System.Drawing.Size(58, 36);
            this.btnSalirCategoria.TabIndex = 4;
            this.btnSalirCategoria.Text = "SALIR";
            this.btnSalirCategoria.UseVisualStyleBackColor = true;
            this.btnSalirCategoria.Click += new System.EventHandler(this.btnSalirCategoria_Click);
            // 
            // dgCategorias
            // 
            this.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCategoria,
            this.nombreCategoria,
            this.btnEditarCategoria,
            this.btnBorrarCategoria});
            this.dgCategorias.Location = new System.Drawing.Point(193, 215);
            this.dgCategorias.Name = "dgCategorias";
            this.dgCategorias.Size = new System.Drawing.Size(451, 292);
            this.dgCategorias.TabIndex = 5;
            this.dgCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategorias_CellContentClick);
            // 
            // codigoCategoria
            // 
            this.codigoCategoria.HeaderText = "CODIGO";
            this.codigoCategoria.Name = "codigoCategoria";
            // 
            // nombreCategoria
            // 
            this.nombreCategoria.HeaderText = "NOMBRE CATEGORIA";
            this.nombreCategoria.Name = "nombreCategoria";
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.HeaderText = "EDITAR";
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Text = "EDITAR";
            this.btnEditarCategoria.UseColumnTextForButtonValue = true;
            // 
            // btnBorrarCategoria
            // 
            this.btnBorrarCategoria.HeaderText = "BORRAR";
            this.btnBorrarCategoria.Name = "btnBorrarCategoria";
            this.btnBorrarCategoria.Text = "BORRAR";
            this.btnBorrarCategoria.UseColumnTextForButtonValue = true;
            // 
            // FrmListaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 589);
            this.Controls.Add(this.dgCategorias);
            this.Controls.Add(this.btnSalirCategoria);
            this.Controls.Add(this.btnNuevoCategoria);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.txtBuscarCategorias);
            this.Controls.Add(this.lblTituloCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaCategorias";
            this.Load += new System.EventHandler(this.FrmListaCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloCategorias;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarCategorias;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirCategoria;
        private System.Windows.Forms.DataGridView dgCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditarCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrarCategoria;
    }
}