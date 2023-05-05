using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualizador_de_Imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Mostra uma imagem na PictureBox


        private void btn_mostrar_Click_1(object sender, EventArgs e)
        {
            // Abre a caixa de diálogo OpenFileDialogue e se premiu OK carrega na PictureBox o ficheiro selecionado
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(openFileDialog1.FileName);
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btn_mudarfundo_Click(object sender, EventArgs e)
        {
            // Abre a caixa de diálog ColorDiag e se premir OK coloca na PictureBox a cor de fundo selecionada
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close(); // Fecha o formulário
            //this.Close();
        }

        // Ajusta ou coloca a imagem em modo normal
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
