using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1CA
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            int intentos = 0;

            if ((txtUsuario.Text=="Adm")& (txtContraseña.Text=="@1a"))
            {
                lstModulo.Items.Add("ADM");
                lstModulo.Items.Add("COM");
                lstModulo.Items.Add("VTA");

                this.Hide();
                frmInicio f = new frmInicio();
                f.ShowDialog();
                this.Show();
            }
            else if ((txtUsuario.Text=="John")& (txtContraseña.Text== "*2b"))
            {
                lstModulo.Items.Add("SIST");

                this.Hide();
                frmInicio f = new frmInicio();
                f.ShowDialog();
                this.Show();
            }
            else if ((txtUsuario.Text=="Ceci") & (txtContraseña.Text=="@3c"))
            {
                lstModulo.Items.Add("ADM");
                lstModulo.Items.Add("VTA");

                this.Hide();
                frmInicio f = new frmInicio();
                f.ShowDialog();
                this.Show();
            }
            else if ((txtUsuario.Text=="God")& (txtContraseña.Text=="@#4d"))
            {
                lstModulo.Items.Add("ADM");
                lstModulo.Items.Add("SIST");
                lstModulo.Items.Add("COM");
                lstModulo.Items.Add("VTA");

                this.Hide();
                frmInicio f = new frmInicio();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                intentos++;
                if (intentos==2)
                {
                    this.Close();
                }
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '#';
            txtContraseña.UseSystemPasswordChar = true;
        }
    }
}
