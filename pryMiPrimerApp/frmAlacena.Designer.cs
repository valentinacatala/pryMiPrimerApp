namespace pryMiPrimerApp
{
    partial class frmAlacena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlacena));
            this.chkCaduca = new System.Windows.Forms.CheckBox();
            this.dtpFechaDeVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDeVencimiento = new System.Windows.Forms.Label();
            this.mrcCategorias = new System.Windows.Forms.GroupBox();
            this.lstProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.optLimpieza = new System.Windows.Forms.RadioButton();
            this.optMedicamento = new System.Windows.Forms.RadioButton();
            this.optComida = new System.Windows.Forms.RadioButton();
            this.txtLugar = new System.Windows.Forms.Label();
            this.lstLugar = new System.Windows.Forms.ComboBox();
            this.lstAlacena = new System.Windows.Forms.ListBox();
            this.mrcCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // chkCaduca
            // 
            this.chkCaduca.AutoSize = true;
            this.chkCaduca.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCaduca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkCaduca.Location = new System.Drawing.Point(9, 198);
            this.chkCaduca.Name = "chkCaduca";
            this.chkCaduca.Size = new System.Drawing.Size(66, 20);
            this.chkCaduca.TabIndex = 7;
            this.chkCaduca.Text = "Caduca";
            this.chkCaduca.UseVisualStyleBackColor = true;
            // 
            // dtpFechaDeVencimiento
            // 
            this.dtpFechaDeVencimiento.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDeVencimiento.Location = new System.Drawing.Point(130, 227);
            this.dtpFechaDeVencimiento.Name = "dtpFechaDeVencimiento";
            this.dtpFechaDeVencimiento.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaDeVencimiento.TabIndex = 8;
            this.dtpFechaDeVencimiento.ValueChanged += new System.EventHandler(this.dtpFechaDeVencimiento_ValueChanged);
            // 
            // lblFechaDeVencimiento
            // 
            this.lblFechaDeVencimiento.AutoSize = true;
            this.lblFechaDeVencimiento.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeVencimiento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechaDeVencimiento.Location = new System.Drawing.Point(6, 232);
            this.lblFechaDeVencimiento.Name = "lblFechaDeVencimiento";
            this.lblFechaDeVencimiento.Size = new System.Drawing.Size(122, 16);
            this.lblFechaDeVencimiento.TabIndex = 9;
            this.lblFechaDeVencimiento.Text = "Fecha de vencimiento";
            // 
            // mrcCategorias
            // 
            this.mrcCategorias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mrcCategorias.Controls.Add(this.lstLugar);
            this.mrcCategorias.Controls.Add(this.txtLugar);
            this.mrcCategorias.Controls.Add(this.optComida);
            this.mrcCategorias.Controls.Add(this.optMedicamento);
            this.mrcCategorias.Controls.Add(this.optLimpieza);
            this.mrcCategorias.Controls.Add(this.txtCantidad);
            this.mrcCategorias.Controls.Add(this.nudCantidad);
            this.mrcCategorias.Controls.Add(this.lstProducto);
            this.mrcCategorias.Controls.Add(this.lblProducto);
            this.mrcCategorias.Controls.Add(this.dtpFechaDeVencimiento);
            this.mrcCategorias.Controls.Add(this.lblFechaDeVencimiento);
            this.mrcCategorias.Controls.Add(this.chkCaduca);
            this.mrcCategorias.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcCategorias.ForeColor = System.Drawing.Color.Peru;
            this.mrcCategorias.Location = new System.Drawing.Point(16, 11);
            this.mrcCategorias.Name = "mrcCategorias";
            this.mrcCategorias.Size = new System.Drawing.Size(336, 267);
            this.mrcCategorias.TabIndex = 10;
            this.mrcCategorias.TabStop = false;
            this.mrcCategorias.Text = "Categorias";
            // 
            // lstProducto
            // 
            this.lstProducto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.Location = new System.Drawing.Point(73, 77);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(121, 24);
            this.lstProducto.TabIndex = 11;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProducto.Location = new System.Drawing.Point(11, 80);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(56, 16);
            this.lblProducto.TabIndex = 10;
            this.lblProducto.Text = "Producto";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.Color.White;
            this.cmdGuardar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(142, 284);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(87, 31);
            this.cmdGuardar.TabIndex = 11;
            this.cmdGuardar.Text = "GUARDAR";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCancelar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(235, 284);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(87, 31);
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "CANCELAR";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(73, 152);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(110, 26);
            this.nudCantidad.TabIndex = 13;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoSize = true;
            this.txtCantidad.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCantidad.Location = new System.Drawing.Point(12, 157);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(55, 16);
            this.txtCantidad.TabIndex = 14;
            this.txtCantidad.Text = "Cantidad";
            this.txtCantidad.Click += new System.EventHandler(this.label1_Click);
            // 
            // optLimpieza
            // 
            this.optLimpieza.AutoSize = true;
            this.optLimpieza.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optLimpieza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optLimpieza.Location = new System.Drawing.Point(15, 36);
            this.optLimpieza.Name = "optLimpieza";
            this.optLimpieza.Size = new System.Drawing.Size(75, 21);
            this.optLimpieza.TabIndex = 15;
            this.optLimpieza.TabStop = true;
            this.optLimpieza.Text = "Limpieza";
            this.optLimpieza.UseVisualStyleBackColor = true;
            // 
            // optMedicamento
            // 
            this.optMedicamento.AutoSize = true;
            this.optMedicamento.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMedicamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optMedicamento.Location = new System.Drawing.Point(211, 36);
            this.optMedicamento.Name = "optMedicamento";
            this.optMedicamento.Size = new System.Drawing.Size(101, 21);
            this.optMedicamento.TabIndex = 16;
            this.optMedicamento.TabStop = true;
            this.optMedicamento.Text = "Medicamento";
            this.optMedicamento.UseVisualStyleBackColor = true;
            // 
            // optComida
            // 
            this.optComida.AutoSize = true;
            this.optComida.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optComida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optComida.Location = new System.Drawing.Point(126, 36);
            this.optComida.Name = "optComida";
            this.optComida.Size = new System.Drawing.Size(68, 21);
            this.optComida.TabIndex = 17;
            this.optComida.TabStop = true;
            this.optComida.Text = "Comida";
            this.optComida.UseVisualStyleBackColor = true;
            // 
            // txtLugar
            // 
            this.txtLugar.AutoSize = true;
            this.txtLugar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLugar.Location = new System.Drawing.Point(12, 120);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(38, 16);
            this.txtLugar.TabIndex = 18;
            this.txtLugar.Text = "Lugar";
            // 
            // lstLugar
            // 
            this.lstLugar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLugar.FormattingEnabled = true;
            this.lstLugar.Items.AddRange(new object[] {
            "Heladera",
            "Alacena",
            "Baño"});
            this.lstLugar.Location = new System.Drawing.Point(73, 117);
            this.lstLugar.Name = "lstLugar";
            this.lstLugar.Size = new System.Drawing.Size(121, 24);
            this.lstLugar.TabIndex = 19;
            // 
            // lstAlacena
            // 
            this.lstAlacena.FormattingEnabled = true;
            this.lstAlacena.Location = new System.Drawing.Point(31, 341);
            this.lstAlacena.Name = "lstAlacena";
            this.lstAlacena.Size = new System.Drawing.Size(297, 95);
            this.lstAlacena.TabIndex = 13;
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(360, 451);
            this.Controls.Add(this.lstAlacena);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.mrcCategorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlacena";
            this.Text = "Alacena";
            this.Load += new System.EventHandler(this.frmAlacena_Load);
            this.mrcCategorias.ResumeLayout(false);
            this.mrcCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chkCaduca;
        private System.Windows.Forms.DateTimePicker dtpFechaDeVencimiento;
        private System.Windows.Forms.Label lblFechaDeVencimiento;
        private System.Windows.Forms.GroupBox mrcCategorias;
        private System.Windows.Forms.ComboBox lstProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Label txtCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.RadioButton optComida;
        private System.Windows.Forms.RadioButton optMedicamento;
        private System.Windows.Forms.RadioButton optLimpieza;
        private System.Windows.Forms.ComboBox lstLugar;
        private System.Windows.Forms.Label txtLugar;
        private System.Windows.Forms.ListBox lstAlacena;
    }
}