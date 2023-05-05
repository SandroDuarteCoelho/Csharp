using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Exemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Um click no botão Saudar desencadeia um método que manipula o evento Click.
        // O método coloca o texto indicado na propriedade Text da TextBox.
        private void btn_Saudar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Benvindos aos Formulários!   Os botões são fixes";
        }

        private void btn_despedir_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Adeus... As caixas de texto são chatas!!";
            label2.Text = "Eu sou uma label!!!";
        }
    }
}
