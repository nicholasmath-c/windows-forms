using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Interface
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Operacao operacao = new Operacao();
            double.TryParse(txtValor1.Text, out double val1);
            double.TryParse(txtValor2.Text, out double val2);
            int.TryParse(txtPar.Text, out int par);
            double resultado = 0;

            if (rdbPar.Checked)
            {
                if (!operacao.VerificarCampoVazio(txtPar.Text))
                {
                    if (operacao.VerificarPar(par))
                        MessageBox.Show("O número " + par.ToString() + " é par.");
                    else
                        MessageBox.Show("O número " + par.ToString() + " é ímpar.");
                }
                else
                {
                    MessageBox.Show("O campo relacionado a verificação do número par não pode estar nulo.");
                    return;
                }
            }
            else
            {
                if(!operacao.VerificarCampoVazio(txtValor1.Text) || !operacao.VerificarCampoVazio(txtValor2.Text))
                {
                    if (rdbSomar.Checked)
                        resultado = operacao.Somar(val1, val2);
                    else if (rdbSubtrair.Checked)
                        resultado = operacao.Subtrair(val1, val2);
                    else if (rdbMultiplicar.Checked)
                        resultado = operacao.Multiplicar(val1, val2);
                    else if (rdbDividir.Checked)
                        resultado = operacao.Dividir(val1, val2);
                    else if (rdbRetangulo.Checked)
                        resultado = operacao.CalcularAreaRetangulo(val1, val2);
                    else if (rdbQuadrado.Checked)
                        resultado = operacao.CalcularAreaQuadrado(val1, val2);
                    else if (rdbTriangulo.Checked)
                        resultado = operacao.CalcularAreaTriangulo(val1, val2);
                    else if (rdbIMC.Checked)
                        resultado = operacao.CalcularIMC(val1, val2);

                    MessageBox.Show(resultado.ToString());
                }
                else
                {
                    MessageBox.Show("Os campos 'Valor 1' e 'Valor 2' não podem estar vazios.");
                    return;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparControles();
        }

        public void LimparControles()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)(item)).Text = string.Empty;
                }
                if (item is RadioButton)
                {
                    ((RadioButton)(item)).Checked = false;
                }
            }
        }
    }
}
