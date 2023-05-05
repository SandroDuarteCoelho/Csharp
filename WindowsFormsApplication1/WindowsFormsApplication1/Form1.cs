using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Bitmap imgcar1 = new Bitmap(Properties.Resources.images);
        Bitmap imgcar2 = new Bitmap(Properties.Resources.images__1_);

        #region Variaveis
        private int lin;
        private int col;
        private int inicX;
        private int inicY;
        private int dimquad;

        private int[,] ArrayPista;

        private int coordcarX;
        private int coordcarY;

        Random rdm = new Random();

        private int coordcarX2;
        private int coordcarY2;

        #endregion


        private void IniciarJogo()
        {
            lin = 25;
            col = 7;
            inicX = 30;
            inicY = 30;
            dimquad = 15;
            ArrayPista = new int[lin, col];
            LimparArray();
            //    ArrayPista[0, 1] = 1;
            //    ArrayPista[3, 5] = 2;
            coordcarX = coordcarY = 0;
            // DesenharCarro(coordcarX, coordcarY, 1);
            // Coordenadas do carro avariado
            coordcarX2 = rdm.Next(23);
            coordcarY2 = (rdm.Next(23) % 2 == 0 ? 0 : 4);
            timer1.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
            IniciarJogo();
        }

        private void DesenharPista(Graphics g)
        {
            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    g.DrawRectangle(new Pen(Brushes.Brown), inicX + j * dimquad, inicY + i * dimquad, dimquad, dimquad);
                    /* Desenha carro preenchendo as quadriculas
                                        if (ArrayPista[i, j] == 1)
                                            g.FillRectangle(Brushes.Red, inicX + j * dimquad, inicY + i * dimquad, dimquad, dimquad);

                                        if (ArrayPista[i, j] == 2)
                                            g.FillRectangle(Brushes.Blue, inicX + j * dimquad, inicY + i * dimquad, dimquad, dimquad);
                    */
                    if (ArrayPista[i, j] == 1)
                    {
                        g.DrawImage(imgcar1, inicX + j * dimquad, inicY + i * dimquad, dimquad * 3, dimquad * 4);
                    }

                    if (ArrayPista[i, j] == 2)
                    {
                        g.DrawImage(imgcar2, inicX + j * dimquad, inicY + i * dimquad, dimquad * 3, dimquad * 4);
                    }


              }
                
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DesenharPista(e.Graphics);
        }

        private void LimparArray()
        {
            for (int i = 0; i < lin; i++)
                for (int j = 0; j < col; j++)
                    ArrayPista[i, j] = 0;
        }

        private void DesenharCarro(int x, int y, int valor)
        {
            DesenharQuadricula(x, y, valor);
        }
        /*
        private void DesenharCarro(int valor)
        {
            ArrayPista[0, 1] = valor;
            ArrayPista[1, 0] = valor;
            ArrayPista[1, 1] = valor;
            ArrayPista[1, 2] = valor;
            ArrayPista[2, 1] = valor;
            ArrayPista[3, 0] = valor;
            ArrayPista[3, 1] = valor;
            ArrayPista[3, 2] = valor;
        }
        */
        /*
        private void DesenharCarro(int x, int y, int valor)
        {
            DesenharQuadricula(x, y+1, valor);
            DesenharQuadricula(x+1, y, valor);
            DesenharQuadricula(x+1, y+1, valor);
            DesenharQuadricula(x+1, y+2, valor);
            DesenharQuadricula(x+2, y+1, valor);
            DesenharQuadricula(x+3, y, valor);
            DesenharQuadricula(x+3, y+1, valor);
            DesenharQuadricula(x+3, y+2, valor);
        }
        */

        private void DesenharQuadricula(int x, int y, int valor)
        {
            if (x >= 0 && x < lin && y >= 0 && y < col)
                ArrayPista[x, y] = valor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LimparArray();
            DesenharCarro(coordcarX, coordcarY, 1);
            DesenharCarro(coordcarX2, coordcarY2, 2);
            Invalidate();
            coordcarX++;
            if (coordcarX == lin)
            {
                coordcarX = 0;
                // Vai colocar aleatoriamente o carro na pista 1 (valor 0) se o nº gerado for par e na pista 2 (valor 4) se for impar
                coordcarY = (rdm.Next(25) % 2 == 0 ? 0 : 4);

            }
            FimJogo();
        }

        private void Tecla_Dir(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && coordcarY == 4)
                coordcarY = 0;
            else if (e.KeyCode == Keys.Right && coordcarY == 0)
                coordcarY = 4;
            coordcarX2 = rdm.Next(23);
        }

        private void FimJogo()
        {
            if (coordcarX +3 > coordcarX2 && coordcarY == coordcarY2)
            {
                timer1.Enabled = false;
                var res= MessageBox.Show("espatifou o carro","Continuar jogo?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                    IniciarJogo();
                else
                    Close();
                
            }
        }
    }
}
