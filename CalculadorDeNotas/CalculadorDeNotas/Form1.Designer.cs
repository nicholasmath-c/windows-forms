
namespace CalculadorDeNotas
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.imgAprovado = new System.Windows.Forms.PictureBox();
            this.imgReprovado = new System.Windows.Forms.PictureBox();
            this.imgRecuperacao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAprovado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReprovado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecuperacao)).BeginInit();
            this.SuspendLayout();
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
            this.btnCalc.Location = new System.Drawing.Point(64, 352);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(226, 48);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "CALCULAR";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota 1:";
            // 
            // txtNota1
            // 
            this.txtNota1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNota1.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.txtNota1.Location = new System.Drawing.Point(126, 148);
            this.txtNota1.Multiline = true;
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(164, 26);
            this.txtNota1.TabIndex = 2;
            // 
            // txtNota2
            // 
            this.txtNota2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNota2.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.txtNota2.Location = new System.Drawing.Point(126, 206);
            this.txtNota2.Multiline = true;
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(164, 26);
            this.txtNota2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nota 2:";
            // 
            // txtNota3
            // 
            this.txtNota3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNota3.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.txtNota3.Location = new System.Drawing.Point(126, 266);
            this.txtNota3.Multiline = true;
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(164, 26);
            this.txtNota3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(584, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "MÉDIA:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.ForeColor = System.Drawing.Color.White;
            this.lblMedia.Location = new System.Drawing.Point(681, 28);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(25, 30);
            this.lblMedia.TabIndex = 8;
            this.lblMedia.Text = "0";
            // 
            // imgAprovado
            // 
            this.imgAprovado.Enabled = false;
            this.imgAprovado.Image = ((System.Drawing.Image)(resources.GetObject("imgAprovado.Image")));
            this.imgAprovado.Location = new System.Drawing.Point(420, 88);
            this.imgAprovado.Name = "imgAprovado";
            this.imgAprovado.Size = new System.Drawing.Size(464, 461);
            this.imgAprovado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAprovado.TabIndex = 9;
            this.imgAprovado.TabStop = false;
            this.imgAprovado.Visible = false;
            // 
            // imgReprovado
            // 
            this.imgReprovado.Image = ((System.Drawing.Image)(resources.GetObject("imgReprovado.Image")));
            this.imgReprovado.Location = new System.Drawing.Point(420, 88);
            this.imgReprovado.Name = "imgReprovado";
            this.imgReprovado.Size = new System.Drawing.Size(464, 461);
            this.imgReprovado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgReprovado.TabIndex = 10;
            this.imgReprovado.TabStop = false;
            this.imgReprovado.Visible = false;
            // 
            // imgRecuperacao
            // 
            this.imgRecuperacao.Image = ((System.Drawing.Image)(resources.GetObject("imgRecuperacao.Image")));
            this.imgRecuperacao.Location = new System.Drawing.Point(420, 88);
            this.imgRecuperacao.Name = "imgRecuperacao";
            this.imgRecuperacao.Size = new System.Drawing.Size(464, 461);
            this.imgRecuperacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRecuperacao.TabIndex = 11;
            this.imgRecuperacao.TabStop = false;
            this.imgRecuperacao.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(933, 583);
            this.Controls.Add(this.imgRecuperacao);
            this.Controls.Add(this.imgReprovado);
            this.Controls.Add(this.imgAprovado);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Média";
            ((System.ComponentModel.ISupportInitialize)(this.imgAprovado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReprovado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecuperacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.PictureBox imgAprovado;
        private System.Windows.Forms.PictureBox imgReprovado;
        private System.Windows.Forms.PictureBox imgRecuperacao;
    }
}

