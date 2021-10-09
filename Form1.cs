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
            if (numero1.Text != "" && numero2.Text != "")
            {
                double num1 = Convert.ToDouble(numero1.Text);
                double num2 = Convert.ToDouble(numero2.Text);
                string result = (num1 + num2).ToString();
                lbresultado.Text = result;
            }
            else
            {
                lbresultado.Text = "Campo vazio";
            }
        }

        private void btSubtracao_Click(object sender, EventArgs e)
        {
            if (numero1.Text != "" && numero2.Text != "")
            {
                double num1 = Convert.ToDouble(numero1.Text);
                double num2 = Convert.ToDouble(numero2.Text);
                string result = (num1 - num2).ToString();
                lbresultado.Text = result;
            }
            else 
            {
                lbresultado.Text = "Campo vazio";
            }
        }

        private void btMultiplicacao_Click(object sender, EventArgs e)
        {
            if (numero1.Text != "" && numero2.Text != "")
            {
                double num1 = Convert.ToDouble(numero1.Text);
                double num2 = Convert.ToDouble(numero2.Text);
                string result = (num1 * num2).ToString();
                lbresultado.Text = result;
            }
            else
            {
                lbresultado.Text = "Campo vazio";
            }
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            if (numero1.Text != "" && numero2.Text != "")
            {
                if (numero2.Text != "0")
                {
                    double num1 = Convert.ToDouble(numero1.Text);
                    double num2 = Convert.ToDouble(numero2.Text);
                    string result = (num1 / num2).ToString();
                    lbresultado.Text = result;

                }
                else
                {
                    lbresultado.Text = "Não pode dividir por 0!";
                }
            }
            else
            {
                lbresultado.Text = "Campo vazio";
            }
        }

            private void numero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.LetraVirgula(sender, e);
        }

        private void numero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.LetraVirgula(sender, e);
        }
    }
}
