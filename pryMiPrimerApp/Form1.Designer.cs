namespace pryMiPrimerApp
{
    partial class formGestionDeGastosMensuales
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGestionDeGastosMensuales));
            this.mrcIngreso = new System.Windows.Forms.GroupBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.mrcGastosFijos = new System.Windows.Forms.GroupBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.mrcGastosVarios = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.mrcIngreso.SuspendLayout();
            this.mrcGastosFijos.SuspendLayout();
            this.mrcGastosVarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcIngreso
            // 
            this.mrcIngreso.Controls.Add(this.txtDeposito);
            this.mrcIngreso.Controls.Add(this.lblDeposito);
            this.mrcIngreso.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcIngreso.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mrcIngreso.Location = new System.Drawing.Point(44, 15);
            this.mrcIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcIngreso.Name = "mrcIngreso";
            this.mrcIngreso.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcIngreso.Size = new System.Drawing.Size(437, 123);
            this.mrcIngreso.TabIndex = 0;
            this.mrcIngreso.TabStop = false;
            this.mrcIngreso.Text = "INGRESO";
            // 
            // txtDeposito
            // 
            this.txtDeposito.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposito.Location = new System.Drawing.Point(141, 44);
            this.txtDeposito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(181, 30);
            this.txtDeposito.TabIndex = 1;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeposito.Location = new System.Drawing.Point(36, 52);
            this.lblDeposito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(82, 22);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "DEPOSITO";
            // 
            // mrcGastosFijos
            // 
            this.mrcGastosFijos.Controls.Add(this.txtComida);
            this.mrcGastosFijos.Controls.Add(this.txtImpuestos);
            this.mrcGastosFijos.Controls.Add(this.txtAlquiler);
            this.mrcGastosFijos.Controls.Add(this.lblComida);
            this.mrcGastosFijos.Controls.Add(this.lblImpuestos);
            this.mrcGastosFijos.Controls.Add(this.lblAlquiler);
            this.mrcGastosFijos.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosFijos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mrcGastosFijos.Location = new System.Drawing.Point(44, 174);
            this.mrcGastosFijos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcGastosFijos.Name = "mrcGastosFijos";
            this.mrcGastosFijos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcGastosFijos.Size = new System.Drawing.Size(437, 172);
            this.mrcGastosFijos.TabIndex = 1;
            this.mrcGastosFijos.TabStop = false;
            this.mrcGastosFijos.Text = "GASTOS FIJOS";
            // 
            // txtComida
            // 
            this.txtComida.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComida.Location = new System.Drawing.Point(141, 121);
            this.txtComida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(181, 30);
            this.txtComida.TabIndex = 5;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuestos.Location = new System.Drawing.Point(141, 78);
            this.txtImpuestos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(181, 30);
            this.txtImpuestos.TabIndex = 4;
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlquiler.Location = new System.Drawing.Point(141, 34);
            this.txtAlquiler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(181, 30);
            this.txtAlquiler.TabIndex = 3;
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblComida.Location = new System.Drawing.Point(35, 127);
            this.lblComida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(68, 22);
            this.lblComida.TabIndex = 2;
            this.lblComida.Text = "COMIDA";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblImpuestos.Location = new System.Drawing.Point(33, 84);
            this.lblImpuestos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(93, 22);
            this.lblImpuestos.TabIndex = 1;
            this.lblImpuestos.Text = "IMPUESTOS";
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquiler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAlquiler.Location = new System.Drawing.Point(35, 41);
            this.lblAlquiler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(82, 22);
            this.lblAlquiler.TabIndex = 0;
            this.lblAlquiler.Text = "ALQUILER";
            // 
            // mrcGastosVarios
            // 
            this.mrcGastosVarios.Controls.Add(this.txtMonto);
            this.mrcGastosVarios.Controls.Add(this.lblMonto);
            this.mrcGastosVarios.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosVarios.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mrcGastosVarios.Location = new System.Drawing.Point(44, 391);
            this.mrcGastosVarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcGastosVarios.Name = "mrcGastosVarios";
            this.mrcGastosVarios.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcGastosVarios.Size = new System.Drawing.Size(437, 123);
            this.mrcGastosVarios.TabIndex = 2;
            this.mrcGastosVarios.TabStop = false;
            this.mrcGastosVarios.Text = "GASTOS  VARIOS";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(141, 44);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(181, 30);
            this.txtMonto.TabIndex = 1;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMonto.Location = new System.Drawing.Point(36, 53);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(64, 22);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "MONTO";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(167, 545);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(156, 43);
            this.cmdCancelar.TabIndex = 3;
            this.cmdCancelar.Text = "CANCELAR";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalcular.Location = new System.Drawing.Point(325, 545);
            this.cmdCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(156, 43);
            this.cmdCalcular.TabIndex = 4;
            this.cmdCalcular.Text = "CALCULAR";
            this.cmdCalcular.UseVisualStyleBackColor = false;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // lblCalculo
            // 
            this.lblCalculo.AutoSize = true;
            this.lblCalculo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculo.Location = new System.Drawing.Point(40, 602);
            this.lblCalculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(25, 24);
            this.lblCalculo.TabIndex = 5;
            this.lblCalculo.Text = "   ";
            // 
            // formGestionDeGastosMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(503, 653);
            this.Controls.Add(this.lblCalculo);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.mrcGastosVarios);
            this.Controls.Add(this.mrcGastosFijos);
            this.Controls.Add(this.mrcIngreso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formGestionDeGastosMensuales";
            this.Text = "Gestion de Gastos Mensuales";
            this.Load += new System.EventHandler(this.formGestionDeGastosMensuales_Load);
            this.mrcIngreso.ResumeLayout(false);
            this.mrcIngreso.PerformLayout();
            this.mrcGastosFijos.ResumeLayout(false);
            this.mrcGastosFijos.PerformLayout();
            this.mrcGastosVarios.ResumeLayout(false);
            this.mrcGastosVarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcIngreso;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.GroupBox mrcGastosFijos;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.GroupBox mrcGastosVarios;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.Label lblCalculo;
    }
}

