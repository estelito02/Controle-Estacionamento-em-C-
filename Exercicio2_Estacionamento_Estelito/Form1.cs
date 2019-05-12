using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2_Estacionamento_Estelito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        controle X = new controle();

        private void btnabrir_Click(object sender, EventArgs e)
        {
            X.TotalVagas1 = int.Parse(txtVagas.Text);
            X.QtdeVeiculos1 = 0;


            btnEntrada.Enabled = true;
            btnSaida.Enabled = true;
            txtVagas.Enabled = true;
            btnabrir.Enabled = true;

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            X.AddVeiculos();
            lblnumerovagas.Text = X.QtdeVeiculos1.ToString();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            X.RemoveVeiculos();
            lblnumerovagas.Text = X.QtdeVeiculos1.ToString();
        }
    }
}
