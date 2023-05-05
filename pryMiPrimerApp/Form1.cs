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
    public partial class formGestionDeGastosMensuales : Form
    {
        private decimal varMonto;
        private decimal varDeposito;
        private decimal varAlquiler;
        private decimal varImpuestos;
        private decimal varComida;

        public formGestionDeGastosMensuales()
        {
            InitializeComponent();
        }

        private void formGestionDeGastosMensuales_Load(object sender, EventArgs e)
        {
            //declaracion de variables
            decimal varDeposito, varAlquiler, varImpuestos, varComida, varMonto;

            //inicializar variables
            varAlquiler = 0;
            varDeposito = 0;
            varImpuestos = 0;
            varComida = 0;
            varMonto = 0;

        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            varDeposito = Convert.ToDecimal(txtDeposito.Text);
            varAlquiler = Convert.ToDecimal(txtAlquiler.Text);
            varImpuestos = Convert.ToDecimal(txtImpuestos.Text);
            varComida = Convert.ToDecimal(txtComida.Text);
            varMonto = Convert.ToDecimal(txtComida.Text);

            varMonto = varDeposito - (varAlquiler + varImpuestos + varComida + varMonto);
            lblCalculo.Text = varMonto.ToString();

            //concatenar
            lblCalculo.Text = "Resultado: " + varMonto.ToString();
        }

    }
}
