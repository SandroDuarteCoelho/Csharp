namespace Form_Exemplo
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
            this.btn_Saudar = new System.Windows.Forms.Button();
            this.btn_despedir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Mensagem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Saudar
            // 
            this.btn_Saudar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Saudar.Location = new System.Drawing.Point(55, 118);
            this.btn_Saudar.Name = "btn_Saudar";
            this.btn_Saudar.Size = new System.Drawing.Size(75, 23);
            this.btn_Saudar.TabIndex = 0;
            this.btn_Saudar.Text = "Saudação";
            this.btn_Saudar.UseVisualStyleBackColor = false;
            this.btn_Saudar.Click += new System.EventHandler(this.btn_Saudar_Click);
            // 
            // btn_despedir
            // 
            this.btn_despedir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_despedir.Location = new System.Drawing.Point(55, 179);
            this.btn_despedir.Name = "btn_despedir";
            this.btn_despedir.Size = new System.Drawing.Size(75, 23);
            this.btn_despedir.TabIndex = 1;
            this.btn_despedir.Text = "Despedida";
            this.btn_despedir.UseVisualStyleBackColor = false;
            this.btn_despedir.Click += new System.EventHandler(this.btn_despedir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 121);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 42);
            this.textBox1.TabIndex = 2;
            // 
            // lbl_Mensagem
            // 
            this.lbl_Mensagem.AutoSize = true;
            this.lbl_Mensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_Mensagem.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mensagem.Location = new System.Drawing.Point(52, 43);
            this.lbl_Mensagem.Name = "lbl_Mensagem";
            this.lbl_Mensagem.Size = new System.Drawing.Size(403, 19);
            this.lbl_Mensagem.TabIndex = 3;
            this.lbl_Mensagem.Text = "Prima um botão para selecionar uma mensagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 295);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Mensagem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_despedir);
            this.Controls.Add(this.btn_Saudar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Botões e Caixas de Texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Saudar;
        private System.Windows.Forms.Button btn_despedir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Mensagem;
        private System.Windows.Forms.Label label2;
    }
}

