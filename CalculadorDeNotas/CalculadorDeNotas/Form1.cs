using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadorDeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if ((txtNota1.Text != "") && (txtNota2.Text != "") && (txtNota3.Text != ""))
            {
                if ((imgAprovado.Visible == true) || (imgReprovado.Visible == true) || (imgRecuperacao.Visible == true))
                {
                    imgAprovado.Visible = false;
                    imgReprovado.Visible = false;
                    imgRecuperacao.Visible = false;
                }

                double nota1, nota2, nota3, media;
                nota1 = Convert.ToDouble(txtNota1.Text);
                nota2 = Convert.ToDouble(txtNota2.Text);
                nota3 = Convert.ToDouble(txtNota3.Text);

                media = (nota1 + nota2 + nota3) / 3;

                if (media >= 6)
                {
                    imgAprovado.Visible = true;
                }
                else if ((media >= 5) && (media < 6))
                {
                    imgRecuperacao.Visible = true;
                }
                else
                {
                    imgReprovado.Visible = true;
                }

                lblMedia.Text = media.ToString("#.#");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
    }
}
