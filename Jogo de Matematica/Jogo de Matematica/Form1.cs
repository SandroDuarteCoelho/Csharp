using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_de_Matematica
{
    public partial class Form1 : Form
    {
        // SoundPlayer para assinalar que o jogador acertou
        System.Media.SoundPlayer Acabou = new System.Media.SoundPlayer(@"c:\Windows\Media\tada.wav");

        // SoundPlayer para assinalar que o jogador perdeu
        System.Media.SoundPlayer Perdeu = new System.Media.SoundPlayer(@"c:\Windows\Media\notify.wav");

        // Cria o objeto rdm da classe Random que gera numeros aleatoriamente
        Random rdm = new Random();

        int soma1, soma2; // valores para realizar a soma
        int subtracao1, subtracao2; // valores para realizar a subtracao
        int multiplicacao1, multiplicacao2; // valores para realizar a multiplicacao
        int divisao1, divisao2; // valores para realizar a divisao

        int tempofalta; // tempo que falta para acabar o jogo

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Verificar())
            {
                timer1.Stop();
                Acabou.Play();
                MessageBox.Show("Parabens", "Acertou");
                IniciarJogo.Enabled = true;
            }
            else if (tempofalta>0)
            {
                tempofalta--;
                TempoFalta.Text = tempofalta + " segundos";
                
                // Chama atenção para os ultimos 5 segundos
                if (tempofalta<=5)
                {
                    TempoFalta.BackColor = Color.Yellow;
                    TempoFalta.ForeColor = Color.Red;
                }
            }
            else
            {
                timer1.Stop();
                Perdeu.Play();
                MessageBox.Show("Não conseguiu terminar", "Acabou o tempo");
                ResultadoAdicao.Value = soma1 + soma2;
                ResultadoSubtracao.Value = subtracao1 - subtracao2;
                ResultadoMultiplicacao.Value = multiplicacao1 * multiplicacao2;
                ResultadoDivisao.Value = divisao1 / divisao2;
                IniciarJogo.Enabled = true;
            }
        }

        private void Enter_Resposta(object sender, EventArgs e)
        {
            NumericUpDown res = sender as NumericUpDown;
            if (res != null)
            {
                int dimres = res.Value.ToString().Length;
                res.Select(0, dimres);
            }
        }

        private bool Verificar()
        {
            if ((soma1 + soma2 == ResultadoAdicao.Value)&&(subtracao1-subtracao2==ResultadoSubtracao.Value)&&(multiplicacao1*multiplicacao2==ResultadoMultiplicacao.Value)&&(divisao1/divisao2==ResultadoDivisao.Value))
                return true;
            else
                return false;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void IniciarJogo_Click(object sender, EventArgs e)
        {
            InicioJogo();
            IniciarJogo.Enabled = false; // desativa o botao iniciar depois de pressionado
        }

        /// <summary>
        /// Inicia o jogo preenchendo os valores para as operações
        /// </summary>
        private void InicioJogo()
        {
            // Repõe a cor do texto e a cor de fundo
            TempoFalta.ForeColor = DefaultForeColor;
            TempoFalta.BackColor = DefaultBackColor;

            // Preenche os valores para as variaveis criadas aleatoriamente (entre 0 e 50)
            soma1 = rdm.Next(51);
            soma2 = rdm.Next(51);
            subtracao1 = rdm.Next(20);
            subtracao2 = rdm.Next(20);
            multiplicacao1 = rdm.Next(1,20);
            multiplicacao2 = rdm.Next(1,20);
            divisao1 = rdm.Next(1,20);
            divisao2 = rdm.Next(1,20);

            // Converte para string os dois valores armazenados em soma1 e soma2, etc.
            SomaEsquerda.Text = soma1.ToString();
            SomaDireita.Text = soma2.ToString();
            SubtracaoEsquerda.Text = subtracao1.ToString();
            SubtracaoDireita.Text = subtracao2.ToString();
            MultiplicacaoEsquerda.Text = multiplicacao1.ToString();
            MultiplicacaoDireita.Text = multiplicacao2.ToString();
            DivisaoEsquerda.Text = divisao1.ToString();
            DivisaoDireita.Text = divisao2.ToString();


            // Inicializa com zero o valor do NumericUpDown
            ResultadoAdicao.Value = 0;
            ResultadoSubtracao.Value = 0;
            ResultadoMultiplicacao.Value = 0;
            ResultadoDivisao.Value = 0;

            tempofalta = 20;
            TempoFalta.Text = "20 segundos";
            timer1.Start();
        }
    }
}
