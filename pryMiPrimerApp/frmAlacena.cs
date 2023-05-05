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
    public partial class frmAlacena : Form
    {
        //declaracion de variables
        string varProducto, varLugar, varTipo;

        int varCantidad;

        DateTime varFechaDeVencimiento;

        public frmAlacena()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            varLugar = txtLugar.Text;
            varProducto = lstProducto.Text;
            varCantidad = Convert.ToInt32(nudCantidad.Value);
            //varCantidad= int.Parse(nudCantidad.Value);
            varTipo = "";
            varFechaDeVencimiento = dtpFechaDeVencimiento.Value;

            lstAlacena.Items.Add(varLugar + varProducto + varCantidad);
        }
        private void dtpFechaDeVencimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstAlacena_Enter(object sender, EventArgs e)
        {

        }

        private void frmAlacena_Load(object sender, EventArgs e)
        {
            lstProducto.Items.Add("Azucar");
            lstProducto.Items.Add("Huevos");
            lstProducto.Items.Add("Leche");
            lstProducto.Items.Add("Trapo");
            lstProducto.Items.Add("Ibupofreno");
            lstProducto.Items.Add("Galletas");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
