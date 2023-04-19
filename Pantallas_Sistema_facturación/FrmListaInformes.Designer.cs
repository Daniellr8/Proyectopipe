namespace Pantallas_Sistema_facturación
{
    partial class FrmListaInformes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaInformes));
            this.lblTituloInformes = new MaterialSkin.Controls.MaterialLabel();
            this.lblSeleccioneInforme = new MaterialSkin.Controls.MaterialLabel();
            this.lblOrdenarPor = new MaterialSkin.Controls.MaterialLabel();
            this.cboSeleccioneInforme = new System.Windows.Forms.ComboBox();
            this.cboOrdenarPor = new System.Windows.Forms.ComboBox();
            this.lblFechaFinal = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.rdbEnPantalla = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbdPdf = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbdExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnGenerarInforme = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalirGeneradorInformes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloInformes
            // 
            this.lblTituloInformes.AutoSize = true;
            this.lblTituloInformes.Depth = 0;
            this.lblTituloInformes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloInformes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloInformes.Location = new System.Drawing.Point(362, 55);
            this.lblTituloInformes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloInformes.Name = "lblTituloInformes";
            this.lblTituloInformes.Size = new System.Drawing.Size(324, 19);
            this.lblTituloInformes.TabIndex = 0;
            this.lblTituloInformes.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            // 
            // lblSeleccioneInforme
            // 
            this.lblSeleccioneInforme.AutoSize = true;
            this.lblSeleccioneInforme.Depth = 0;
            this.lblSeleccioneInforme.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSeleccioneInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSeleccioneInforme.Location = new System.Drawing.Point(102, 125);
            this.lblSeleccioneInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSeleccioneInforme.Name = "lblSeleccioneInforme";
            this.lblSeleccioneInforme.Size = new System.Drawing.Size(161, 19);
            this.lblSeleccioneInforme.TabIndex = 1;
            this.lblSeleccioneInforme.Text = "SELCCIONE INFORME:";
            // 
            // lblOrdenarPor
            // 
            this.lblOrdenarPor.AutoSize = true;
            this.lblOrdenarPor.Depth = 0;
            this.lblOrdenarPor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOrdenarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrdenarPor.Location = new System.Drawing.Point(548, 125);
            this.lblOrdenarPor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrdenarPor.Name = "lblOrdenarPor";
            this.lblOrdenarPor.Size = new System.Drawing.Size(113, 19);
            this.lblOrdenarPor.TabIndex = 2;
            this.lblOrdenarPor.Text = "ORDENAR POR:";
            // 
            // cboSeleccioneInforme
            // 
            this.cboSeleccioneInforme.FormattingEnabled = true;
            this.cboSeleccioneInforme.Location = new System.Drawing.Point(291, 123);
            this.cboSeleccioneInforme.Name = "cboSeleccioneInforme";
            this.cboSeleccioneInforme.Size = new System.Drawing.Size(199, 21);
            this.cboSeleccioneInforme.TabIndex = 3;
            // 
            // cboOrdenarPor
            // 
            this.cboOrdenarPor.FormattingEnabled = true;
            this.cboOrdenarPor.Location = new System.Drawing.Point(684, 123);
            this.cboOrdenarPor.Name = "cboOrdenarPor";
            this.cboOrdenarPor.Size = new System.Drawing.Size(199, 21);
            this.cboOrdenarPor.TabIndex = 4;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Depth = 0;
            this.lblFechaFinal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaFinal.Location = new System.Drawing.Point(517, 169);
            this.lblFechaFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(106, 19);
            this.lblFechaFinal.TabIndex = 6;
            this.lblFechaFinal.Text = "FECHA FINAL:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Depth = 0;
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaInicio.Location = new System.Drawing.Point(155, 170);
            this.lblFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(108, 19);
            this.lblFechaInicio.TabIndex = 7;
            this.lblFechaInicio.Text = "FECHA INICIO:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(291, 170);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(171, 20);
            this.dtpFechaInicio.TabIndex = 8;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(653, 168);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(170, 20);
            this.dtpFechaFinal.TabIndex = 9;
            // 
            // rdbEnPantalla
            // 
            this.rdbEnPantalla.AutoSize = true;
            this.rdbEnPantalla.Depth = 0;
            this.rdbEnPantalla.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbEnPantalla.Location = new System.Drawing.Point(313, 219);
            this.rdbEnPantalla.Margin = new System.Windows.Forms.Padding(0);
            this.rdbEnPantalla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbEnPantalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbEnPantalla.Name = "rdbEnPantalla";
            this.rdbEnPantalla.Ripple = true;
            this.rdbEnPantalla.Size = new System.Drawing.Size(97, 30);
            this.rdbEnPantalla.TabIndex = 10;
            this.rdbEnPantalla.TabStop = true;
            this.rdbEnPantalla.Text = "En pantalla";
            this.rdbEnPantalla.UseVisualStyleBackColor = true;
            // 
            // rbdPdf
            // 
            this.rbdPdf.AutoSize = true;
            this.rbdPdf.Depth = 0;
            this.rbdPdf.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbdPdf.Location = new System.Drawing.Point(460, 219);
            this.rbdPdf.Margin = new System.Windows.Forms.Padding(0);
            this.rbdPdf.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbdPdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbdPdf.Name = "rbdPdf";
            this.rbdPdf.Ripple = true;
            this.rbdPdf.Size = new System.Drawing.Size(54, 30);
            this.rbdPdf.TabIndex = 11;
            this.rbdPdf.TabStop = true;
            this.rbdPdf.Text = "PDF";
            this.rbdPdf.UseVisualStyleBackColor = true;
            // 
            // rbdExcel
            // 
            this.rbdExcel.AutoSize = true;
            this.rbdExcel.Depth = 0;
            this.rbdExcel.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbdExcel.Location = new System.Drawing.Point(583, 219);
            this.rbdExcel.Margin = new System.Windows.Forms.Padding(0);
            this.rbdExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbdExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbdExcel.Name = "rbdExcel";
            this.rbdExcel.Ripple = true;
            this.rbdExcel.Size = new System.Drawing.Size(62, 30);
            this.rbdExcel.TabIndex = 12;
            this.rbdExcel.TabStop = true;
            this.rbdExcel.Text = "Excel";
            this.rbdExcel.UseVisualStyleBackColor = true;
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.AutoSize = true;
            this.btnGenerarInforme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerarInforme.Depth = 0;
            this.btnGenerarInforme.Icon = null;
            this.btnGenerarInforme.Location = new System.Drawing.Point(346, 280);
            this.btnGenerarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Primary = true;
            this.btnGenerarInforme.Size = new System.Drawing.Size(144, 36);
            this.btnGenerarInforme.TabIndex = 13;
            this.btnGenerarInforme.Text = "GENERAR INFORME";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // btnSalirGeneradorInformes
            // 
            this.btnSalirGeneradorInformes.AutoSize = true;
            this.btnSalirGeneradorInformes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalirGeneradorInformes.Depth = 0;
            this.btnSalirGeneradorInformes.Icon = null;
            this.btnSalirGeneradorInformes.Location = new System.Drawing.Point(565, 280);
            this.btnSalirGeneradorInformes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalirGeneradorInformes.Name = "btnSalirGeneradorInformes";
            this.btnSalirGeneradorInformes.Primary = true;
            this.btnSalirGeneradorInformes.Size = new System.Drawing.Size(58, 36);
            this.btnSalirGeneradorInformes.TabIndex = 14;
            this.btnSalirGeneradorInformes.Text = "SALIR";
            this.btnSalirGeneradorInformes.UseVisualStyleBackColor = true;
            this.btnSalirGeneradorInformes.Click += new System.EventHandler(this.btnSalirGeneradorInformes_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(159, 337);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(192, 192);
            this.axAcroPDF1.TabIndex = 15;
            // 
            // FrmListaInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 531);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.btnSalirGeneradorInformes);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.rbdExcel);
            this.Controls.Add(this.rbdPdf);
            this.Controls.Add(this.rdbEnPantalla);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.cboOrdenarPor);
            this.Controls.Add(this.cboSeleccioneInforme);
            this.Controls.Add(this.lblOrdenarPor);
            this.Controls.Add(this.lblSeleccioneInforme);
            this.Controls.Add(this.lblTituloInformes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaInformes";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloInformes;
        private MaterialSkin.Controls.MaterialLabel lblSeleccioneInforme;
        private MaterialSkin.Controls.MaterialLabel lblOrdenarPor;
        private System.Windows.Forms.ComboBox cboSeleccioneInforme;
        private System.Windows.Forms.ComboBox cboOrdenarPor;
        private MaterialSkin.Controls.MaterialLabel lblFechaFinal;
        private MaterialSkin.Controls.MaterialLabel lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private MaterialSkin.Controls.MaterialRadioButton rdbEnPantalla;
        private MaterialSkin.Controls.MaterialRadioButton rbdPdf;
        private MaterialSkin.Controls.MaterialRadioButton rbdExcel;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerarInforme;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalirGeneradorInformes;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}