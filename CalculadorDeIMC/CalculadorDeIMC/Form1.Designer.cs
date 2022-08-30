
namespace CalculadorDeIMC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblIMC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.imgMagreza = new System.Windows.Forms.PictureBox();
            this.imgNormal = new System.Windows.Forms.PictureBox();
            this.imgSobrepeso = new System.Windows.Forms.PictureBox();
            this.imgObesidade = new System.Windows.Forms.PictureBox();
            this.imgObesidadeGrave = new System.Windows.Forms.PictureBox();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgMagreza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSobrepeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgObesidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgObesidadeGrave)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.ForeColor = System.Drawing.Color.White;
            this.lblIMC.Location = new System.Drawing.Point(646, 19);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(25, 30);
            this.lblIMC.TabIndex = 20;
            this.lblIMC.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(579, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "IMC:";
            // 
            // txtPeso
            // 
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeso.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.txtPeso.Location = new System.Drawing.Point(108, 266);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(164, 26);
            this.txtPeso.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Peso:";
            // 
            // txtAltura
            // 
            this.txtAltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAltura.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.txtAltura.Location = new System.Drawing.Point(118, 208);
            this.txtAltura.Multiline = true;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(164, 26);
            this.txtAltura.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Altura:";
            // 
            // btnCalc
            // 
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnCalc.FlatAppearance.BorderSize = 2;
            this.btnCalc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(61, 350);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(226, 48);
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "CALCULAR";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // imgMagreza
            // 
            this.imgMagreza.Image = ((System.Drawing.Image)(resources.GetObject("imgMagreza.Image")));
            this.imgMagreza.Location = new System.Drawing.Point(392, 89);
            this.imgMagreza.Name = "imgMagreza";
            this.imgMagreza.Size = new System.Drawing.Size(464, 461);
            this.imgMagreza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMagreza.TabIndex = 21;
            this.imgMagreza.TabStop = false;
            this.imgMagreza.Visible = false;
            // 
            // imgNormal
            // 
            this.imgNormal.Image = ((System.Drawing.Image)(resources.GetObject("imgNormal.Image")));
            this.imgNormal.Location = new System.Drawing.Point(392, 89);
            this.imgNormal.Name = "imgNormal";
            this.imgNormal.Size = new System.Drawing.Size(464, 461);
            this.imgNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNormal.TabIndex = 22;
            this.imgNormal.TabStop = false;
            this.imgNormal.Visible = false;
            // 
            // imgSobrepeso
            // 
            this.imgSobrepeso.Image = ((System.Drawing.Image)(resources.GetObject("imgSobrepeso.Image")));
            this.imgSobrepeso.Location = new System.Drawing.Point(392, 89);
            this.imgSobrepeso.Name = "imgSobrepeso";
            this.imgSobrepeso.Size = new System.Drawing.Size(464, 461);
            this.imgSobrepeso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSobrepeso.TabIndex = 23;
            this.imgSobrepeso.TabStop = false;
            this.imgSobrepeso.Visible = false;
            // 
            // imgObesidade
            // 
            this.imgObesidade.Image = ((System.Drawing.Image)(resources.GetObject("imgObesidade.Image")));
            this.imgObesidade.Location = new System.Drawing.Point(392, 89);
            this.imgObesidade.Name = "imgObesidade";
            this.imgObesidade.Size = new System.Drawing.Size(464, 461);
            this.imgObesidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgObesidade.TabIndex = 24;
            this.imgObesidade.TabStop = false;
            this.imgObesidade.Visible = false;
            // 
            // imgObesidadeGrave
            // 
            this.imgObesidadeGrave.Image = ((System.Drawing.Image)(resources.GetObject("imgObesidadeGrave.Image")));
            this.imgObesidadeGrave.Location = new System.Drawing.Point(392, 89);
            this.imgObesidadeGrave.Name = "imgObesidadeGrave";
            this.imgObesidadeGrave.Size = new System.Drawing.Size(464, 461);
            this.imgObesidadeGrave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgObesidadeGrave.TabIndex = 25;
            this.imgObesidadeGrave.TabStop = false;
            this.imgObesidadeGrave.Visible = false;
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassificacao.ForeColor = System.Drawing.Color.White;
            this.lblClassificacao.Location = new System.Drawing.Point(646, 56);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(110, 30);
            this.lblClassificacao.TabIndex = 27;
            this.lblClassificacao.Text = "Nenhuma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(441, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 30);
            this.label5.TabIndex = 26;
            this.label5.Text = "CLASSIFICAÇÃO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(894, 590);
            this.Controls.Add(this.lblClassificacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imgObesidadeGrave);
            this.Controls.Add(this.imgObesidade);
            this.Controls.Add(this.imgSobrepeso);
            this.Controls.Add(this.imgNormal);
            this.Controls.Add(this.imgMagreza);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador de IMC";
            ((System.ComponentModel.ISupportInitialize)(this.imgMagreza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSobrepeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgObesidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgObesidadeGrave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.PictureBox imgMagreza;
        private System.Windows.Forms.PictureBox imgNormal;
        private System.Windows.Forms.PictureBox imgSobrepeso;
        private System.Windows.Forms.PictureBox imgObesidade;
        private System.Windows.Forms.PictureBox imgObesidadeGrave;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.Label label5;
    }
}

