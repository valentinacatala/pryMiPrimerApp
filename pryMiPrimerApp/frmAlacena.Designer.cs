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
            this.lstLugar = new System.Windows.Forms.ComboBox();
            this.txtLugar = new System.Windows.Forms.Label();
            this.optComida = new System.Windows.Forms.RadioButton();
            this.optMedicamento = new System.Windows.Forms.RadioButton();
            this.optLimpieza = new System.Windows.Forms.RadioButton();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lstProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
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
            this.chkCaduca.Location = new System.Drawing.Point(12, 244);
            this.chkCaduca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCaduca.Name = "chkCaduca";
            this.chkCaduca.Size = new System.Drawing.Size(84, 26);
            this.chkCaduca.TabIndex = 7;
            this.chkCaduca.Text = "Caduca";
            this.chkCaduca.UseVisualStyleBackColor = true;
            // 
            // dtpFechaDeVencimiento
            // 
            this.dtpFechaDeVencimiento.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDeVencimiento.Location = new System.Drawing.Point(177, 282);
            this.dtpFechaDeVencimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDeVencimiento.Name = "dtpFechaDeVencimiento";
            this.dtpFechaDeVencimiento.Size = new System.Drawing.Size(265, 26);
            this.dtpFechaDeVencimiento.TabIndex = 8;
            this.dtpFechaDeVencimiento.ValueChanged += new System.EventHandler(this.dtpFechaDeVencimiento_ValueChanged);
            // 
            // lblFechaDeVencimiento
            // 
            this.lblFechaDeVencimiento.AutoSize = true;
            this.lblFechaDeVencimiento.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeVencimiento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechaDeVencimiento.Location = new System.Drawing.Point(8, 286);
            this.lblFechaDeVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDeVencimiento.Name = "lblFechaDeVencimiento";
            this.lblFechaDeVencimiento.Size = new System.Drawing.Size(161, 22);
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
            this.mrcCategorias.Location = new System.Drawing.Point(21, 14);
            this.mrcCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcCategorias.Name = "mrcCategorias";
            this.mrcCategorias.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcCategorias.Size = new System.Drawing.Size(448, 329);
            this.mrcCategorias.TabIndex = 10;
            this.mrcCategorias.TabStop = false;
            this.mrcCategorias.Text = "Categorias";
            // 
            // lstLugar
            // 
            this.lstLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLugar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLugar.FormattingEnabled = true;
            this.lstLugar.Items.AddRange(new object[] {
            "Heladera",
            "Alacena",
            "Baño"});
            this.lstLugar.Location = new System.Drawing.Point(97, 144);
            this.lstLugar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstLugar.Name = "lstLugar";
            this.lstLugar.Size = new System.Drawing.Size(160, 28);
            this.lstLugar.TabIndex = 19;
            // 
            // txtLugar
            // 
            this.txtLugar.AutoSize = true;
            this.txtLugar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLugar.Location = new System.Drawing.Point(16, 148);
            this.txtLugar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(51, 22);
            this.txtLugar.TabIndex = 18;
            this.txtLugar.Text = "Lugar";
            // 
            // optComida
            // 
            this.optComida.AutoSize = true;
            this.optComida.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optComida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optComida.Location = new System.Drawing.Point(168, 44);
            this.optComida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optComida.Name = "optComida";
            this.optComida.Size = new System.Drawing.Size(85, 25);
            this.optComida.TabIndex = 17;
            this.optComida.TabStop = true;
            this.optComida.Text = "Comida";
            this.optComida.UseVisualStyleBackColor = true;
            // 
            // optMedicamento
            // 
            this.optMedicamento.AutoSize = true;
            this.optMedicamento.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMedicamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optMedicamento.Location = new System.Drawing.Point(281, 44);
            this.optMedicamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optMedicamento.Name = "optMedicamento";
            this.optMedicamento.Size = new System.Drawing.Size(128, 25);
            this.optMedicamento.TabIndex = 16;
            this.optMedicamento.TabStop = true;
            this.optMedicamento.Text = "Medicamento";
            this.optMedicamento.UseVisualStyleBackColor = true;
            // 
            // optLimpieza
            // 
            this.optLimpieza.AutoSize = true;
            this.optLimpieza.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optLimpieza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optLimpieza.Location = new System.Drawing.Point(20, 44);
            this.optLimpieza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optLimpieza.Name = "optLimpieza";
            this.optLimpieza.Size = new System.Drawing.Size(93, 25);
            this.optLimpieza.TabIndex = 15;
            this.optLimpieza.TabStop = true;
            this.optLimpieza.Text = "Limpieza";
            this.optLimpieza.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoSize = true;
            this.txtCantidad.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCantidad.Location = new System.Drawing.Point(16, 193);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(72, 22);
            this.txtCantidad.TabIndex = 14;
            this.txtCantidad.Text = "Cantidad";
            this.txtCantidad.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(97, 187);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(147, 30);
            this.nudCantidad.TabIndex = 13;
            // 
            // lstProducto
            // 
            this.lstProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstProducto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.Location = new System.Drawing.Point(97, 95);
            this.lstProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(160, 28);
            this.lstProducto.TabIndex = 11;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProducto.Location = new System.Drawing.Point(15, 98);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(74, 22);
            this.lblProducto.TabIndex = 10;
            this.lblProducto.Text = "Producto";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.Color.White;
            this.cmdGuardar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(189, 350);
            this.cmdGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(116, 38);
            this.cmdGuardar.TabIndex = 11;
            this.cmdGuardar.Text = "GUARDAR";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCancelar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(313, 350);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(116, 38);
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "CANCELAR";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // lstAlacena
            // 
            this.lstAlacena.FormattingEnabled = true;
            this.lstAlacena.ItemHeight = 16;
            this.lstAlacena.Location = new System.Drawing.Point(41, 420);
            this.lstAlacena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAlacena.Name = "lstAlacena";
            this.lstAlacena.Size = new System.Drawing.Size(395, 116);
            this.lstAlacena.TabIndex = 13;
            this.lstAlacena.SelectedIndexChanged += new System.EventHandler(this.lstAlacena_SelectedIndexChanged);
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(480, 555);
            this.Controls.Add(this.lstAlacena);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.mrcCategorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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