using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tela_Cadastro_Visitante
{
    public partial class Calculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text = ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text); //transforma o texto para receber o resultado
            txtResultado.Text = ""; //limpa o resultado, aguardando o proximo digito
            operacao = "+"; //se operação for = + realiza soma
            lblOperacao.Text = "+"; //atribui na label colocada na txtResultado o sinal de +
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text);
            txtResultado.Text = "";
            operacao = "-";
            lblOperacao.Text = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text);
            txtResultado.Text = "";
            operacao = "*";
            lblOperacao.Text = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text);
            txtResultado.Text = "";
            operacao = "/";
            lblOperacao.Text = "/";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text); //guardando o valor2 digitado depois de escolher a operação
            
            if(operacao == "+")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2); //convertendo decimal para string, pois o txtResultado suporta apenas string
            }
            else if(operacao == "-")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "*")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        
    }
}
