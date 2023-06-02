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
        private int errores;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;
            string modulo = lstModulo.Text;
            frmInicio inicio = new frmInicio();
            switch (usuario)
            {
                case "Administrador":
                    if (contrasena == "@la" && (modulo == "ADM" || modulo == "COM" || modulo == "VTA" ))
                    {
                        errores = 0;
                        this.Hide();
                        inicio.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrectas para el modulo seleccionado");
                        errores++;
                    }
                    break;
                case "John":
                    if (contrasena == "*2b" && modulo == "SIST")
                    {
                        errores = 0;
                        this.Hide();
                        inicio.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrectas para el modulo seleccionado");
                        errores++;
                    }
                    break;
                case "Ceci":
                    if (contrasena == "*@3c" && (modulo =="ADM" || modulo == "VTA"))
                    {
                        errores = 0;
                        this.Hide();
                        inicio.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrectas para el modulo seleccionado");
                        errores++;
                    }
                    break;
                case "God":
                    if (contrasena == "*@#4d" && (modulo == "ADM" || modulo == "COM" || modulo == "VTA" || modulo == "SIST"))
                    {
                        errores = 0;
                        this.Hide();
                        inicio.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrectas para el modulo seleccionado");
                        errores++;
                    }
                    break;
            }

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtContraseña.
        }
    }
}
