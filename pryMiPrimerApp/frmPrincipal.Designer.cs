namespace pryMiPrimerApp
{
    partial class frmPrincipal
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
            this.cmdAlacena = new System.Windows.Forms.Button();
            this.cmdFinanzas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAlacena
            // 
            this.cmdAlacena.BackColor = System.Drawing.Color.BurlyWood;
            this.cmdAlacena.Font = new System.Drawing.Font("Baby Pumpkin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAlacena.Location = new System.Drawing.Point(13, 29);
            this.cmdAlacena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAlacena.Name = "cmdAlacena";
            this.cmdAlacena.Size = new System.Drawing.Size(566, 198);
            this.cmdAlacena.TabIndex = 0;
            this.cmdAlacena.Text = "ALACENA";
            this.cmdAlacena.UseVisualStyleBackColor = false;
            this.cmdAlacena.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdFinanzas
            // 
            this.cmdFinanzas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdFinanzas.Font = new System.Drawing.Font("Baby Pumpkin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFinanzas.Location = new System.Drawing.Point(13, 256);
            this.cmdFinanzas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdFinanzas.Name = "cmdFinanzas";
            this.cmdFinanzas.Size = new System.Drawing.Size(566, 198);
            this.cmdFinanzas.TabIndex = 1;
            this.cmdFinanzas.Text = "FINANZAS";
            this.cmdFinanzas.UseVisualStyleBackColor = false;
            this.cmdFinanzas.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 478);
            this.Controls.Add(this.cmdFinanzas);
            this.Controls.Add(this.cmdAlacena);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAlacena;
        private System.Windows.Forms.Button cmdFinanzas;
    }
}