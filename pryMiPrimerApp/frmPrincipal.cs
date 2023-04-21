using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMiPrimerApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAlacena ventanaAlacena = new frmAlacena();

            ventanaAlacena.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formGestionDeGastosMensuales ventanaformGestionDeGastosMensuales = new formGestionDeGastosMensuales();

            ventanaformGestionDeGastosMensuales.ShowDialog();

        }
    }
}
