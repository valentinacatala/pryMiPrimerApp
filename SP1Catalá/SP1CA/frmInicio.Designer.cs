namespace SP1CA
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.lblBienvenidoAlSistema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenidoAlSistema
            // 
            this.lblBienvenidoAlSistema.AutoSize = true;
            this.lblBienvenidoAlSistema.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBienvenidoAlSistema.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidoAlSistema.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBienvenidoAlSistema.Location = new System.Drawing.Point(50, 85);
            this.lblBienvenidoAlSistema.Name = "lblBienvenidoAlSistema";
            this.lblBienvenidoAlSistema.Size = new System.Drawing.Size(368, 48);
            this.lblBienvenidoAlSistema.TabIndex = 0;
            this.lblBienvenidoAlSistema.Text = "Bienvenido al Sistema";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 231);
            this.Controls.Add(this.lblBienvenidoAlSistema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenidoAlSistema;
    }
}