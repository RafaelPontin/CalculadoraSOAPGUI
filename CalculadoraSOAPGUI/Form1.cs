using CalculadoraSOAPGUI.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSOAPGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculoServiceClient calculoServiceClient = new CalculoServiceClient();
            decimal total = calculoServiceClient.Dividir(Convert.ToDecimal(txtNum1.Text), Convert.ToDecimal(txtNum2.Text));
            txtTotal.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculoServiceClient calculoServiceClient = new CalculoServiceClient();
            decimal total = calculoServiceClient.Somar(Convert.ToDecimal(txtNum1.Text), Convert.ToDecimal(txtNum2.Text));
            txtTotal.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculoServiceClient calculoServiceClient = new CalculoServiceClient();
            decimal total = calculoServiceClient.Multiplicar(Convert.ToDecimal(txtNum1.Text), Convert.ToDecimal(txtNum2.Text));
            txtTotal.Text = total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalculoServiceClient calculoServiceClient = new CalculoServiceClient();
            decimal total = calculoServiceClient.Subtrair(Convert.ToDecimal(txtNum1.Text), Convert.ToDecimal(txtNum2.Text));
            txtTotal.Text = total.ToString();
        }
    }
}
