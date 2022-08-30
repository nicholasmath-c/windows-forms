using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadorDeIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if ((txtPeso.Text != "") && (txtAltura.Text != "")) 
            {
                if ((imgMagreza.Visible == true) || (imgNormal.Visible == true) || (imgSobrepeso.Visible == true) || (imgObesidade.Visible == true) || (imgObesidadeGrave.Visible == true))
                {
                    imgMagreza.Visible = false;
                    imgNormal.Visible = false;
                    imgSobrepeso.Visible = false;
                    imgObesidade.Visible = false;
                    imgObesidadeGrave.Visible = false;
                }

                double altura, peso, imc;
                string classificacao = "a";

                altura = Convert.ToDouble(txtAltura.Text);
                peso = Convert.ToDouble(txtPeso.Text);

                imc = peso / (altura * altura);

                if (imc < 18.5)
                {
                    classificacao = "Magreza";
                    imgMagreza.Visible = true;
                }
                else if ((imc >= 18.5) && (imc <= 24.9))
                {
                    classificacao = "Normal";
                    imgNormal.Visible = true;
                }
                else if ((imc >= 25) && (imc <= 29.9))
                {
                    classificacao = "Sobrepeso";
                    imgSobrepeso.Visible = true;
                }
                else if ((imc >= 30) && (imc <= 39.9))
                {
                    classificacao = "Obesidade";
                    imgObesidade.Visible = true;
                }
                else if(imc > 39.9)
                {
                    classificacao = "Obesidade Grave";
                    imgObesidadeGrave.Visible = true;
                }

                lblIMC.Text = imc.ToString("#.#");
                lblClassificacao.Text = classificacao;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
    }
}
