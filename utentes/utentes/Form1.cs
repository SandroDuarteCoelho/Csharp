using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            ADICIONAR form2 = new ADICIONAR();
            // Apresenta o formulário chamado
            form2.Show();
        }

        private void btn_Lista_Click(object sender, EventArgs e)
        {
            LISTA form2 = new LISTA();
            // Apresenta o formulário chamado
            form2.Show();
        }

        private void btn_Diário_Click(object sender, EventArgs e)
        {
            DIARIO form2 = new DIARIO();
            // Apresenta o formulário chamado
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox p = new PictureBox();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                  p.Load(openFileDialog1.FileName);
            p.SizeMode = PictureBoxSizeMode.AutoSize;
            this.BackgroundImage = p.Image;
        }

    
    }
}
