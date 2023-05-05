namespace Jogo_de_Matematica
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
            this.components = new System.ComponentModel.Container();
            this.label_Texto = new System.Windows.Forms.Label();
            this.TempoFalta = new System.Windows.Forms.Label();
            this.SomaEsquerda = new System.Windows.Forms.Label();
            this.Mais = new System.Windows.Forms.Label();
            this.SomaDireita = new System.Windows.Forms.Label();
            this.SomaIgual = new System.Windows.Forms.Label();
            this.SubtracaoIgual = new System.Windows.Forms.Label();
            this.SubtracaoDireita = new System.Windows.Forms.Label();
            this.Menos = new System.Windows.Forms.Label();
            this.SubtracaoEsquerda = new System.Windows.Forms.Label();
            this.MultiplicacaoIgual = new System.Windows.Forms.Label();
            this.MultiplicacaoDireita = new System.Windows.Forms.Label();
            this.Multiplicacao = new System.Windows.Forms.Label();
            this.MultiplicacaoEsquerda = new System.Windows.Forms.Label();
            this.DivisaoIgual = new System.Windows.Forms.Label();
            this.DivisaoDireita = new System.Windows.Forms.Label();
            this.Divisao = new System.Windows.Forms.Label();
            this.DivisaoEsquerda = new System.Windows.Forms.Label();
            this.ResultadoAdicao = new System.Windows.Forms.NumericUpDown();
            this.ResultadoSubtracao = new System.Windows.Forms.NumericUpDown();
            this.ResultadoMultiplicacao = new System.Windows.Forms.NumericUpDown();
            this.ResultadoDivisao = new System.Windows.Forms.NumericUpDown();
            this.IniciarJogo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoAdicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoSubtracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoMultiplicacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoDivisao)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Texto
            // 
            this.label_Texto.AutoSize = true;
            this.label_Texto.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Texto.Location = new System.Drawing.Point(78, 35);
            this.label_Texto.Name = "label_Texto";
            this.label_Texto.Size = new System.Drawing.Size(67, 19);
            this.label_Texto.TabIndex = 0;
            this.label_Texto.Text = "Faltam:";
            // 
            // TempoFalta
            // 
            this.TempoFalta.AutoSize = true;
            this.TempoFalta.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempoFalta.Location = new System.Drawing.Point(250, 35);
            this.TempoFalta.Name = "TempoFalta";
            this.TempoFalta.Size = new System.Drawing.Size(0, 19);
            this.TempoFalta.TabIndex = 1;
            // 
            // SomaEsquerda
            // 
            this.SomaEsquerda.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SomaEsquerda.Location = new System.Drawing.Point(48, 105);
            this.SomaEsquerda.Name = "SomaEsquerda";
            this.SomaEsquerda.Size = new System.Drawing.Size(52, 31);
            this.SomaEsquerda.TabIndex = 2;
            this.SomaEsquerda.Text = "?";
            this.SomaEsquerda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mais
            // 
            this.Mais.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mais.Location = new System.Drawing.Point(106, 105);
            this.Mais.Name = "Mais";
            this.Mais.Size = new System.Drawing.Size(52, 31);
            this.Mais.TabIndex = 3;
            this.Mais.Text = "+";
            this.Mais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SomaDireita
            // 
            this.SomaDireita.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SomaDireita.Location = new System.Drawing.Point(167, 105);
            this.SomaDireita.Name = "SomaDireita";
            this.SomaDireita.Size = new System.Drawing.Size(52, 31);
            this.SomaDireita.TabIndex = 4;
            this.SomaDireita.Text = "?";
            this.SomaDireita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SomaIgual
            // 
            this.SomaIgual.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SomaIgual.Location = new System.Drawing.Point(225, 105);
            this.SomaIgual.Name = "SomaIgual";
            this.SomaIgual.Size = new System.Drawing.Size(52, 31);
            this.SomaIgual.TabIndex = 5;
            this.SomaIgual.Text = "=";
            this.SomaIgual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubtracaoIgual
            // 
            this.SubtracaoIgual.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtracaoIgual.Location = new System.Drawing.Point(225, 156);
            this.SubtracaoIgual.Name = "SubtracaoIgual";
            this.SubtracaoIgual.Size = new System.Drawing.Size(52, 31);
            this.SubtracaoIgual.TabIndex = 9;
            this.SubtracaoIgual.Text = "=";
            this.SubtracaoIgual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubtracaoDireita
            // 
            this.SubtracaoDireita.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtracaoDireita.Location = new System.Drawing.Point(167, 156);
            this.SubtracaoDireita.Name = "SubtracaoDireita";
            this.SubtracaoDireita.Size = new System.Drawing.Size(52, 31);
            this.SubtracaoDireita.TabIndex = 8;
            this.SubtracaoDireita.Text = "?";
            this.SubtracaoDireita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menos
            // 
            this.Menos.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menos.Location = new System.Drawing.Point(106, 156);
            this.Menos.Name = "Menos";
            this.Menos.Size = new System.Drawing.Size(52, 31);
            this.Menos.TabIndex = 7;
            this.Menos.Text = "-";
            this.Menos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubtracaoEsquerda
            // 
            this.SubtracaoEsquerda.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtracaoEsquerda.Location = new System.Drawing.Point(48, 156);
            this.SubtracaoEsquerda.Name = "SubtracaoEsquerda";
            this.SubtracaoEsquerda.Size = new System.Drawing.Size(52, 31);
            this.SubtracaoEsquerda.TabIndex = 6;
            this.SubtracaoEsquerda.Text = "?";
            this.SubtracaoEsquerda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultiplicacaoIgual
            // 
            this.MultiplicacaoIgual.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicacaoIgual.Location = new System.Drawing.Point(225, 200);
            this.MultiplicacaoIgual.Name = "MultiplicacaoIgual";
            this.MultiplicacaoIgual.Size = new System.Drawing.Size(52, 31);
            this.MultiplicacaoIgual.TabIndex = 13;
            this.MultiplicacaoIgual.Text = "=";
            this.MultiplicacaoIgual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultiplicacaoDireita
            // 
            this.MultiplicacaoDireita.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicacaoDireita.Location = new System.Drawing.Point(167, 200);
            this.MultiplicacaoDireita.Name = "MultiplicacaoDireita";
            this.MultiplicacaoDireita.Size = new System.Drawing.Size(52, 31);
            this.MultiplicacaoDireita.TabIndex = 12;
            this.MultiplicacaoDireita.Text = "?";
            this.MultiplicacaoDireita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Multiplicacao
            // 
            this.Multiplicacao.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicacao.Location = new System.Drawing.Point(106, 200);
            this.Multiplicacao.Name = "Multiplicacao";
            this.Multiplicacao.Size = new System.Drawing.Size(52, 31);
            this.Multiplicacao.TabIndex = 11;
            this.Multiplicacao.Text = "x";
            this.Multiplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultiplicacaoEsquerda
            // 
            this.MultiplicacaoEsquerda.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicacaoEsquerda.Location = new System.Drawing.Point(48, 200);
            this.MultiplicacaoEsquerda.Name = "MultiplicacaoEsquerda";
            this.MultiplicacaoEsquerda.Size = new System.Drawing.Size(52, 31);
            this.MultiplicacaoEsquerda.TabIndex = 10;
            this.MultiplicacaoEsquerda.Text = "?";
            this.MultiplicacaoEsquerda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DivisaoIgual
            // 
            this.DivisaoIgual.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisaoIgual.Location = new System.Drawing.Point(225, 246);
            this.DivisaoIgual.Name = "DivisaoIgual";
            this.DivisaoIgual.Size = new System.Drawing.Size(52, 31);
            this.DivisaoIgual.TabIndex = 17;
            this.DivisaoIgual.Text = "=";
            this.DivisaoIgual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DivisaoDireita
            // 
            this.DivisaoDireita.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisaoDireita.Location = new System.Drawing.Point(167, 246);
            this.DivisaoDireita.Name = "DivisaoDireita";
            this.DivisaoDireita.Size = new System.Drawing.Size(52, 31);
            this.DivisaoDireita.TabIndex = 16;
            this.DivisaoDireita.Text = "?";
            this.DivisaoDireita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Divisao
            // 
            this.Divisao.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divisao.Location = new System.Drawing.Point(106, 246);
            this.Divisao.Name = "Divisao";
            this.Divisao.Size = new System.Drawing.Size(52, 31);
            this.Divisao.TabIndex = 15;
            this.Divisao.Text = "/";
            this.Divisao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DivisaoEsquerda
            // 
            this.DivisaoEsquerda.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisaoEsquerda.Location = new System.Drawing.Point(48, 246);
            this.DivisaoEsquerda.Name = "DivisaoEsquerda";
            this.DivisaoEsquerda.Size = new System.Drawing.Size(52, 31);
            this.DivisaoEsquerda.TabIndex = 14;
            this.DivisaoEsquerda.Text = "?";
            this.DivisaoEsquerda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultadoAdicao
            // 
            this.ResultadoAdicao.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoAdicao.Location = new System.Drawing.Point(283, 112);
            this.ResultadoAdicao.Name = "ResultadoAdicao";
            this.ResultadoAdicao.Size = new System.Drawing.Size(94, 20);
            this.ResultadoAdicao.TabIndex = 2;
            this.ResultadoAdicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ResultadoAdicao.Enter += new System.EventHandler(this.Enter_Resposta);
            // 
            // ResultadoSubtracao
            // 
            this.ResultadoSubtracao.DecimalPlaces = 1;
            this.ResultadoSubtracao.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoSubtracao.Location = new System.Drawing.Point(283, 162);
            this.ResultadoSubtracao.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.ResultadoSubtracao.Name = "ResultadoSubtracao";
            this.ResultadoSubtracao.Size = new System.Drawing.Size(94, 20);
            this.ResultadoSubtracao.TabIndex = 3;
            this.ResultadoSubtracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ResultadoSubtracao.Enter += new System.EventHandler(this.Enter_Resposta);
            // 
            // ResultadoMultiplicacao
            // 
            this.ResultadoMultiplicacao.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoMultiplicacao.Location = new System.Drawing.Point(283, 206);
            this.ResultadoMultiplicacao.Name = "ResultadoMultiplicacao";
            this.ResultadoMultiplicacao.Size = new System.Drawing.Size(94, 20);
            this.ResultadoMultiplicacao.TabIndex = 4;
            this.ResultadoMultiplicacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ResultadoMultiplicacao.Enter += new System.EventHandler(this.Enter_Resposta);
            // 
            // ResultadoDivisao
            // 
            this.ResultadoDivisao.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoDivisao.Location = new System.Drawing.Point(283, 252);
            this.ResultadoDivisao.Name = "ResultadoDivisao";
            this.ResultadoDivisao.Size = new System.Drawing.Size(94, 20);
            this.ResultadoDivisao.TabIndex = 5;
            this.ResultadoDivisao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ResultadoDivisao.Enter += new System.EventHandler(this.Enter_Resposta);
            // 
            // IniciarJogo
            // 
            this.IniciarJogo.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarJogo.Location = new System.Drawing.Point(93, 313);
            this.IniciarJogo.Name = "IniciarJogo";
            this.IniciarJogo.Size = new System.Drawing.Size(126, 45);
            this.IniciarJogo.TabIndex = 1;
            this.IniciarJogo.Text = "Iniciar Jogo";
            this.IniciarJogo.UseVisualStyleBackColor = true;
            this.IniciarJogo.Click += new System.EventHandler(this.IniciarJogo_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 417);
            this.Controls.Add(this.IniciarJogo);
            this.Controls.Add(this.ResultadoDivisao);
            this.Controls.Add(this.ResultadoMultiplicacao);
            this.Controls.Add(this.ResultadoSubtracao);
            this.Controls.Add(this.ResultadoAdicao);
            this.Controls.Add(this.DivisaoIgual);
            this.Controls.Add(this.DivisaoDireita);
            this.Controls.Add(this.Divisao);
            this.Controls.Add(this.DivisaoEsquerda);
            this.Controls.Add(this.MultiplicacaoIgual);
            this.Controls.Add(this.MultiplicacaoDireita);
            this.Controls.Add(this.Multiplicacao);
            this.Controls.Add(this.MultiplicacaoEsquerda);
            this.Controls.Add(this.SubtracaoIgual);
            this.Controls.Add(this.SubtracaoDireita);
            this.Controls.Add(this.Menos);
            this.Controls.Add(this.SubtracaoEsquerda);
            this.Controls.Add(this.SomaIgual);
            this.Controls.Add(this.SomaDireita);
            this.Controls.Add(this.Mais);
            this.Controls.Add(this.SomaEsquerda);
            this.Controls.Add(this.TempoFalta);
            this.Controls.Add(this.label_Texto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo de Matematica";
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoAdicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoSubtracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoMultiplicacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoDivisao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Texto;
        private System.Windows.Forms.Label TempoFalta;
        private System.Windows.Forms.Label SomaEsquerda;
        private System.Windows.Forms.Label Mais;
        private System.Windows.Forms.Label SomaDireita;
        private System.Windows.Forms.Label SomaIgual;
        private System.Windows.Forms.Label SubtracaoIgual;
        private System.Windows.Forms.Label SubtracaoDireita;
        private System.Windows.Forms.Label Menos;
        private System.Windows.Forms.Label SubtracaoEsquerda;
        private System.Windows.Forms.Label MultiplicacaoIgual;
        private System.Windows.Forms.Label MultiplicacaoDireita;
        private System.Windows.Forms.Label Multiplicacao;
        private System.Windows.Forms.Label MultiplicacaoEsquerda;
        private System.Windows.Forms.Label DivisaoIgual;
        private System.Windows.Forms.Label DivisaoDireita;
        private System.Windows.Forms.Label Divisao;
        private System.Windows.Forms.Label DivisaoEsquerda;
        private System.Windows.Forms.NumericUpDown ResultadoAdicao;
        private System.Windows.Forms.NumericUpDown ResultadoSubtracao;
        private System.Windows.Forms.NumericUpDown ResultadoMultiplicacao;
        private System.Windows.Forms.NumericUpDown ResultadoDivisao;
        private System.Windows.Forms.Button IniciarJogo;
        private System.Windows.Forms.Timer timer1;
    }
}

