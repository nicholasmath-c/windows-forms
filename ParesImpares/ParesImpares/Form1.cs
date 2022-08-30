using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParesImpares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int inicio, fim;
            string resultado = null;

            if (txtInicio.Text != "" && txtFim.Text != "") 
            {
                if (int.TryParse(txtInicio.Text, out inicio) && int.TryParse(txtFim.Text, out fim))
                {
                    if (inicio >= 0 && fim >= 0)
                    {
                        if (inicio <= fim)
                        {
                            if (rdbPar.Checked)
                            {
                                for (int i = inicio; i <= fim; i++)
                                {
                                    if (i % 2 == 0)
                                    {
                                        if (i == inicio || i == inicio + 1)
                                        {
                                            resultado = i.ToString();
                                        }
                                        else
                                        {
                                            resultado += ", " + i.ToString();
                                        }
                                    }
                                }

                                txtResultado.Text = resultado;
                            }
                            else if (rdbImpar.Checked)
                            {
                                for (int i = inicio; i <= fim; i++)
                                {
                                    if (i % 2 != 0)
                                    {
                                        if (i == inicio || i == inicio+1)
                                        {
                                            resultado = i.ToString();
                                        }
                                        else
                                        {
                                            resultado += ", " + i.ToString();
                                        }
                                    }
                                }

                                txtResultado.Text = resultado;
                            }
                            else
                            {
                                MessageBox.Show("Marque o campo Par ou Ímpar para exibir o resultado.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("O início precisa possuir um valor menor que o fim.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Os valores devem ser positivos.");
                    }
                }
                else
                {
                    MessageBox.Show("Insira apenas valores numéricos inteiros.");
                    txtInicio.Clear();
                    txtFim.Clear();
                }
            }
            else
            {
                MessageBox.Show("Preencha os valores de início e fim.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtInicio.Clear();
            txtFim.Clear();
            txtResultado.Clear();
            rdbPar.Checked = false;
            rdbImpar.Checked = false;
        }
    }
}
