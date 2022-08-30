using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoPerguntasRespostas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
        }

        public int panel = 1;

        

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (panel < 10)
            {
                panel++;
                lblPage.Text = panel.ToString();
                switch (panel)
                {
                    case 1: panel1.Visible = true; return;
                    case 2: panel2.Visible = true; return;
                    case 3: panel3.Visible = true; return;
                    case 4: panel4.Visible = true; return;
                    case 5: panel5.Visible = true; return;
                    case 6: panel6.Visible = true; return;
                    case 7: panel7.Visible = true; return;
                    case 8: panel8.Visible = true; return;
                    case 9: panel9.Visible = true; return;
                    case 10: panel10.Visible = true; return;
                }
            }
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            var resposta = new char[10];
            string resultado;

            //PERGUNTA 1
            if (rdbPergunta1Resposta1.Checked == true)
                resposta[0] = 'a';
            if (rdbPergunta1Resposta2.Checked == true)
                resposta[0] = 'b';
            if (rdbPergunta1Resposta3.Checked == true)
                resposta[0] = 'c';
            if (rdbPergunta1Resposta4.Checked == true)
                resposta[0] = 'd';
            if (rdbPergunta1Resposta5.Checked == true)
                resposta[0] = 'e';

            if (resposta[0] == 'c')
                resultado = "1 - Correta";
            else
                resultado = "1 - Incorreta";

            //PERGUNTA 2
            if (rdbPergunta2Resposta1.Checked == true)
                resposta[1] = 'a';
            if (rdbPergunta2Resposta2.Checked == true)
                resposta[1] = 'b';
            if (rdbPergunta2Resposta3.Checked == true)
                resposta[1] = 'c';
            if (rdbPergunta2Resposta4.Checked == true)
                resposta[1] = 'd';
            if (rdbPergunta2Resposta5.Checked == true)
                resposta[1] = 'e';

            if (resposta[1] == 'c')
                resultado += "\n2 - Correta";
            else
                resultado += "\n2 - Incorreta";

            //PERGUNTA 3
            if (rdbPergunta3Resposta1.Checked == true)
                resposta[2] = 'a';
            if (rdbPergunta3Resposta2.Checked == true)
                resposta[2] = 'b';
            if (rdbPergunta3Resposta3.Checked == true)
                resposta[2] = 'c';
            if (rdbPergunta3Resposta4.Checked == true)
                resposta[2] = 'd';
            if (rdbPergunta3Resposta5.Checked == true)
                resposta[2] = 'e';

            if (resposta[2] == 'a')
                resultado += "\n3 - Correta";
            else
                resultado += "\n3 - Incorreta";

            //PERGUNTA 4
            if (rdbPergunta4Resposta1.Checked == true)
                resposta[3] = 'a';
            if (rdbPergunta4Resposta2.Checked == true)
                resposta[3] = 'b';
            if (rdbPergunta4Resposta3.Checked == true)
                resposta[3] = 'c';
            if (rdbPergunta4Resposta4.Checked == true)
                resposta[3] = 'd';
            if (rdbPergunta4Resposta5.Checked == true)
                resposta[3] = 'e';

            if (resposta[3] == 'e')
                resultado += "\n4 - Correta";
            else
                resultado += "\n4 - Incorreta";

            //PERGUNTA 5
            if (rdbPergunta5Resposta1.Checked == true)
                resposta[4] = 'a';
            if (rdbPergunta5Resposta2.Checked == true)
                resposta[4] = 'b';
            if (rdbPergunta5Resposta3.Checked == true)
                resposta[4] = 'c';
            if (rdbPergunta5Resposta4.Checked == true)
                resposta[4] = 'd';
            if (rdbPergunta5Resposta5.Checked == true)
                resposta[4] = 'e';

            if (resposta[4] == 'b')
                resultado += "\n5 - Correta";
            else
                resultado += "\n5 - Incorreta";

            //PERGUNTA 6
            if (rdbPergunta6Resposta1.Checked == true)
                resposta[5] = 'a';
            if (rdbPergunta6Resposta2.Checked == true)
                resposta[5] = 'b';
            if (rdbPergunta6Resposta3.Checked == true)
                resposta[5] = 'c';
            if (rdbPergunta6Resposta4.Checked == true)
                resposta[5] = 'd';
            if (rdbPergunta6Resposta5.Checked == true)
                resposta[5] = 'e';

            if (resposta[5] == 'b')
                resultado += "\n6 - Correta";
            else
                resultado += "\n6 - Incorreta";

            //PERGUNTA 7
            if (rdbPergunta7Resposta1.Checked == true)
                resposta[6] = 'a';
            if (rdbPergunta7Resposta2.Checked == true)
                resposta[6] = 'b';
            if (rdbPergunta7Resposta3.Checked == true)
                resposta[6] = 'c';
            if (rdbPergunta7Resposta4.Checked == true)
                resposta[6] = 'd';
            if (rdbPergunta7Resposta5.Checked == true)
                resposta[6] = 'e';

            if (resposta[6] == 'c')
                resultado += "\n7 - Correta";
            else
                resultado += "\n7 - Incorreta";

            //PERGUNTA 8
            if (rdbPergunta8Resposta1.Checked == true)
                resposta[7] = 'a';
            if (rdbPergunta8Resposta2.Checked == true)
                resposta[7] = 'b';
            if (rdbPergunta8Resposta3.Checked == true)
                resposta[7] = 'c';
            if (rdbPergunta8Resposta4.Checked == true)
                resposta[7] = 'd';
            if (rdbPergunta8Resposta5.Checked == true)
                resposta[7] = 'e';

            if (resposta[7] == 'd')
                resultado += "\n8 - Correta";
            else
                resultado += "\n8 - Incorreta";

            //PERGUNTA 9
            if (rdbPergunta9Resposta1.Checked == true)
                resposta[8] = 'a';
            if (rdbPergunta9Resposta2.Checked == true)
                resposta[8] = 'b';
            if (rdbPergunta9Resposta3.Checked == true)
                resposta[8] = 'c';
            if (rdbPergunta9Resposta4.Checked == true)
                resposta[8] = 'd';
            if (rdbPergunta9Resposta5.Checked == true)
                resposta[8] = 'e';

            if (resposta[8] == 'a')
                resultado += "\n9 - Correta";
            else
                resultado += "\n9 - Incorreta";

            //PERGUNTA 10
            if (rdbPergunta10Resposta1.Checked == true)
                resposta[9] = 'a';
            if (rdbPergunta10Resposta2.Checked == true)
                resposta[9] = 'b';
            if (rdbPergunta10Resposta3.Checked == true)
                resposta[9] = 'c';
            if (rdbPergunta10Resposta4.Checked == true)
                resposta[9] = 'd';
            if (rdbPergunta10Resposta5.Checked == true)
                resposta[9] = 'e';

            if (resposta[9] == 'd')
                resultado += "\n10 - Correta";
            else
                resultado += "\n10 - Incorreta";

            MessageBox.Show(resultado);
        }
    }
}
