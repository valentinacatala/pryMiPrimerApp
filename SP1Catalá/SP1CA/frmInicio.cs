using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1CA
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin ventanafrmLogin = new frmLogin();
            ventanafrmLogin.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
