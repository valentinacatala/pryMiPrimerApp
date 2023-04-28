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
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lstTipo = new System.Windows.Forms.ComboBox();
            this.lstCantidad = new System.Windows.Forms.ComboBox();
            this.lstNombre = new System.Windows.Forms.ComboBox();
            this.chkCaduca = new System.Windows.Forms.CheckBox();
            this.lstFechaDeVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDeVencimiento = new System.Windows.Forms.Label();
            this.mrcCategorias = new System.Windows.Forms.GroupBox();
            this.lstProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.mrcCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipo.Location = new System.Drawing.Point(12, 83);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(30, 16);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCantidad.Location = new System.Drawing.Point(11, 167);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 16);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(11, 128);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(48, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lstTipo
            // 
            this.lstTipo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTipo.FormattingEnabled = true;
            this.lstTipo.Items.AddRange(new object[] {
            "Lacteo",
            "Verdura",
            "Fruta",
            "Perecedero",
            "Otro"});
            this.lstTipo.Location = new System.Drawing.Point(73, 80);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(121, 24);
            this.lstTipo.TabIndex = 4;
            this.lstTipo.SelectedIndexChanged += new System.EventHandler(this.lstTipo_SelectedIndexChanged);
            // 
            // lstCantidad
            // 
            this.lstCantidad.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCantidad.FormattingEnabled = true;
            this.lstCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "13",
            "14",
            "15"});
            this.lstCantidad.Location = new System.Drawing.Point(73, 162);
            this.lstCantidad.Name = "lstCantidad";
            this.lstCantidad.Size = new System.Drawing.Size(121, 24);
            this.lstCantidad.TabIndex = 5;
            // 
            // lstNombre
            // 
            this.lstNombre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNombre.FormattingEnabled = true;
            this.lstNombre.Items.AddRange(new object[] {
            "Huevo",
            "Leche",
            "Queso",
            "Naranja",
            "Mandarina",
            "Banana",
            "Manzana",
            "Frutilla",
            "Lechuga",
            "Tomate",
            "Cebolla",
            "Papa",
            "Galleta",
            "Arroz",
            "Fideos",
            "Otro"});
            this.lstNombre.Location = new System.Drawing.Point(73, 123);
            this.lstNombre.Name = "lstNombre";
            this.lstNombre.Size = new System.Drawing.Size(121, 24);
            this.lstNombre.TabIndex = 6;
            // 
            // chkCaduca
            // 
            this.chkCaduca.AutoSize = true;
            this.chkCaduca.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCaduca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkCaduca.Location = new System.Drawing.Point(14, 204);
            this.chkCaduca.Name = "chkCaduca";
            this.chkCaduca.Size = new System.Drawing.Size(66, 20);
            this.chkCaduca.TabIndex = 7;
            this.chkCaduca.Text = "Caduca";
            this.chkCaduca.UseVisualStyleBackColor = true;
            // 
            // lstFechaDeVencimiento
            // 
            this.lstFechaDeVencimiento.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFechaDeVencimiento.Location = new System.Drawing.Point(131, 243);
            this.lstFechaDeVencimiento.Name = "lstFechaDeVencimiento";
            this.lstFechaDeVencimiento.Size = new System.Drawing.Size(200, 22);
            this.lstFechaDeVencimiento.TabIndex = 8;
            // 
            // lblFechaDeVencimiento
            // 
            this.lblFechaDeVencimiento.AutoSize = true;
            this.lblFechaDeVencimiento.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeVencimiento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechaDeVencimiento.Location = new System.Drawing.Point(11, 247);
            this.lblFechaDeVencimiento.Name = "lblFechaDeVencimiento";
            this.lblFechaDeVencimiento.Size = new System.Drawing.Size(122, 16);
            this.lblFechaDeVencimiento.TabIndex = 9;
            this.lblFechaDeVencimiento.Text = "Fecha de vencimiento";
            // 
            // mrcCategorias
            // 
            this.mrcCategorias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mrcCategorias.Controls.Add(this.lstProducto);
            this.mrcCategorias.Controls.Add(this.lblProducto);
            this.mrcCategorias.Controls.Add(this.lblTipo);
            this.mrcCategorias.Controls.Add(this.lstFechaDeVencimiento);
            this.mrcCategorias.Controls.Add(this.lblFechaDeVencimiento);
            this.mrcCategorias.Controls.Add(this.lstTipo);
            this.mrcCategorias.Controls.Add(this.lblNombre);
            this.mrcCategorias.Controls.Add(this.chkCaduca);
            this.mrcCategorias.Controls.Add(this.lstNombre);
            this.mrcCategorias.Controls.Add(this.lstCantidad);
            this.mrcCategorias.Controls.Add(this.lblCantidad);
            this.mrcCategorias.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcCategorias.ForeColor = System.Drawing.Color.Peru;
            this.mrcCategorias.Location = new System.Drawing.Point(16, 11);
            this.mrcCategorias.Name = "mrcCategorias";
            this.mrcCategorias.Size = new System.Drawing.Size(336, 287);
            this.mrcCategorias.TabIndex = 10;
            this.mrcCategorias.TabStop = false;
            this.mrcCategorias.Text = "Categorias";
            // 
            // lstProducto
            // 
            this.lstProducto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.Items.AddRange(new object[] {
            "Comida",
            "Limpieza",
            "Medicamento",
            "Otro"});
            this.lstProducto.Location = new System.Drawing.Point(73, 38);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(121, 24);
            this.lstProducto.TabIndex = 11;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProducto.Location = new System.Drawing.Point(11, 38);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(56, 16);
            this.lblProducto.TabIndex = 10;
            this.lblProducto.Text = "Producto";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.Color.White;
            this.cmdGuardar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(157, 320);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(87, 31);
            this.cmdGuardar.TabIndex = 11;
            this.cmdGuardar.Text = "GUARDAR";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCancelar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(250, 320);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(87, 31);
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "CANCELAR";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(362, 369);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.mrcCategorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlacena";
            this.Text = "Alacena";
            this.mrcCategorias.ResumeLayout(false);
            this.mrcCategorias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox lstTipo;
        private System.Windows.Forms.ComboBox lstCantidad;
        private System.Windows.Forms.ComboBox lstNombre;
        private System.Windows.Forms.CheckBox chkCaduca;
        private System.Windows.Forms.DateTimePicker lstFechaDeVencimiento;
        private System.Windows.Forms.Label lblFechaDeVencimiento;
        private System.Windows.Forms.GroupBox mrcCategorias;
        private System.Windows.Forms.ComboBox lstProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCancelar;
    }
}