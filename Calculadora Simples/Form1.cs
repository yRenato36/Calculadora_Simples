using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simples
{
    public partial class Calculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            /*primeiro ele recebeu o zero que foi definido
            depois ele apresenta novamente */

            //textResultado.Text = textResultado.Text + "0";
            textResultado.Text += "0";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";

        }

        private void bt3_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";

        }

        private void bt4_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";

        }

        private void bt5_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";

        }

        private void bt6_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";

        }

        private void bt7_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";

        }

        private void bt8_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";

        }

        private void bt9_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";

        }

        private void btPonto_Click(object sender, EventArgs e)
        {
            textResultado.Text += ".";

        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "Divisao";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Digite dois valores para efetuar a operação.", "Mensagem de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btMult_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "Multiplicacao";
                lblOperacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Digite dois valores para efetuar a operação.", "Mensagem de Aviaso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "Subtracao";
                lblOperacao.Text = "-";
            }
            else
            {                                             //coloca nome na caixa de diálogo //mostra um botão de OK      //Icone de aviso
                MessageBox.Show("Digite dois valores para efetuar a operação.", "Mensagem de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            if (valor1 == 0 && valor2 == 0)
            {
                MessageBox.Show("Digite dois valores para efetuar a operação.", "Mensagem de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                valor2 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {   /*faz o calculo de valor1 e valor 2, o resultado converte para string
                assim possibilitando apresentar no textBox textResultado*/
                    textResultado.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "Subtracao")
                {
                    textResultado.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "Multiplicacao")
                {
                    textResultado.Text = Convert.ToString(valor1 * valor2);
                }
                else
                {
                    textResultado.Text = Convert.ToString(valor1 / valor2);
                }
            }
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            //limpa os campos de texto
            textResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void btC_Click(object sender, EventArgs e)
        {
            //limpa as variáveis e o campos de texto
            valor1 = 0;
            valor2 = 0;
            textResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void lblOperacao_Click(object sender, EventArgs e)
        {

        }

        private void textResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                //essa variável armazena o valor digitano no textResultado
                //CultureInfo.InvariantCulture permite fazer operarções com ponto (.)            
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);

                //limpará o que foi digitado quando precionar o botão de +
                textResultado.Text = "";

                //quando o usuário apertou o botão de +, a variável recebou a string SOMA
                //isso serve para comparar o if/else, então é possível fazer a operação
                operacao = "SOMA";

                //informa qual operação está acontecendo no momento
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Digite dois valores para efetuar a operação.", "Mensagem de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
