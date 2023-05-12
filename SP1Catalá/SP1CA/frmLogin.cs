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

            if ((txtUsuario.Text == "Administrador" &&
            txtContraseña.Text == "adm135$")
            (txtUsuario.Text == "Operador" &&
            txtContraseña.Text == "ope246$"))

            {
                this.Hide();//oculta este formulario
            frmInicio f = new frmInicio(); //crea el formulario
            f.ShowDialog(); //visualiza y ejecuta el formulario
            this.Show(); //visualiza nuevamente el formulario
            }
            {
            MessageBox.Show("Datos incorrectos.Acceso Denegado");
            intentos++;
                if (intentos == 3) ;
            }
            {
                this.Close();
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
