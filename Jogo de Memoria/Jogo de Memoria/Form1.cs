using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_de_Memoria
{
    public partial class Form1 : Form
    {
        // Random para escolher aleatoriamente os icons da tabela
        Random rdm = new Random();

        // Uma lista pode conter numeros, texto, valores true/false ou outros objetos.
        // Uma lista não tem dimensõ fixa (pode aumentar ou diminuir)
        List<string> icons = new List<string>()
            {
                "b","b","e","e","j","j","h","h","$","$","L","L","l","l",",",","
            };

        // Estas labels não foram criadas com new por isso nao têm existencia, e estão a referenciar null (nada)
        Label PrimeiraClk = null;
        Label SegundaClk = null;

        public Form1()
        {
            InitializeComponent();
            AtribuirIcons();
        }

        private void AtribuirIcons()
        {
            // Repetir as ações para cada label (16)
            foreach(Control ctrl in tableLayoutPanel1.Controls)
            {
                // Converte o objeto ctrl para label
                Label iconlabel = ctrl as Label;
                // Verifica se a conversão foi bem feita
                if(iconlabel!= null)
                {
                    // Gera um numero aleatório para indexar um dos elementos da lista
                    int rdmindex = rdm.Next(icons.Count);
                    // Atribui o elemento à label
                    iconlabel.Text = icons[rdmindex];
                    // Remove o elemento atribuido da lista
                    icons.RemoveAt(rdmindex);
                    // Esconder os icons
                    iconlabel.ForeColor = iconlabel.BackColor;

                }
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            // Converte o objeto sender para label
            Label labelClk = sender as Label;
            if (labelClk != null)
            {
                 if (labelClk.ForeColor == Color.Black)
                    return; // label ja tinha sido clicada
                // Vai revelar icon mudando a cor do texto
              //  labelClk.ForeColor = Color.Black;

                // Se for true é a primeira label a ser clicada
                if (PrimeiraClk==null)
                {
                    PrimeiraClk = labelClk;
                    PrimeiraClk.ForeColor = Color.Black;
                    return;
                }

               // Chegou aqui porque a 1ª label já foi clicada e houve clique noutra label
                SegundaClk = labelClk;
                SegundaClk.ForeColor = Color.Black;
                if (FimJogo())
                {
                    MessageBox.Show("Parabéns", "Terminou");
                    Close();
                }

                if (PrimeiraClk.Text == SegundaClk.Text)
                {
                    PrimeiraClk = null;
                    SegundaClk = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Entrou com um tick desencadeado pelo start no outro método. Vai parar para poder desencadear um novo tick.
            timer1.Stop();
            // Esconder as labels
            PrimeiraClk.ForeColor = PrimeiraClk.BackColor;
            SegundaClk.ForeColor = SegundaClk.BackColor;

            
            

            // Reiniciar as variáveis de referência para tornar a detetar as próximas labels
            PrimeiraClk = null;
            SegundaClk = null;
        }

        private bool FimJogo()
        {
            foreach(Control ctr in tableLayoutPanel1.Controls)
            {
                Label lbl = ctr as Label; 
                if (lbl!= null)
                {
                    if (lbl.ForeColor == lbl.BackColor)
                        return false;
                    
                }
            }
            return true;
        }
    }
}
