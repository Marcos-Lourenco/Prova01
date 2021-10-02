using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaProgramação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btAdicao_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(numero1.Text);
            double num2 = Convert.ToDouble(numero2.Text);
            string result = (num1 + num2).ToString();
            lbresultado.Text = result;
        }

        private void btSubtracao_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(numero1.Text);
            double num2 = Convert.ToDouble(numero2.Text);
            string result = (num1 - num2).ToString();
            lbresultado.Text = result;
        }

        private void btMultiplicacao_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(numero1.Text);
            double num2 = Convert.ToDouble(numero2.Text);
            string result = (num1 * num2).ToString();
            lbresultado.Text = result;
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(numero1.Text);
            double num2 = Convert.ToDouble(numero2.Text);
            string result = (num1 / num2).ToString();
            lbresultado.Text = result;
        }
    }
}
