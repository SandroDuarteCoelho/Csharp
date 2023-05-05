using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        double valor1=0, valor2=0;
        int op=0, f=0, r=0;


        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Opera_Click(object sender, EventArgs e)
        {
            
            if (r==1) valor1 = Double.Parse(textBox1.Text);

            Button btn2 = sender as Button;
            if (btn2.Text == "Cub")
            {
                textBox1.Text = Math.Pow(valor1, 3).ToString();
                valor1 = 0;
            }
            if (btn2.Text == "Qua")
            {
                textBox1.Text = Math.Pow(valor1, 2).ToString();
                valor1 = 0;
            }

            if (btn2.Text == "Sin")
            {
                textBox1.Text = Math.Sin((valor1 * Math.PI) / 180).ToString();
                valor1 = 0;
            }
            if (btn2.Text == "Cos")
            {
                textBox1.Text = Math.Cos((valor1 * Math.PI) / 180).ToString();
                valor1 = 0;
            }
            if (btn2.Text == "Tan")
            {
                textBox1.Text = Math.Tan((valor1 * Math.PI) / 180).ToString();
                valor1 = 0;
            }
            if (btn2.Text == "1/x")
            {
                textBox1.Text = (1 / valor1).ToString();
                valor1 = 0;
            }
            if (btn2.Text == "Rz")
            {
                textBox1.Text = Math.Sqrt(valor1).ToString();
                valor1 = 0;
            }

           

           
            if (btn2.Text == "+")
            {
         
                textBox1.Text = textBox1.Text + btn2.Text;
                op = 1;
            }

            if (btn2.Text == "-")
            {

                textBox1.Text = textBox1.Text + btn2.Text;
                op = 2;
            }

            if (btn2.Text == "*")
            {

                textBox1.Text = textBox1.Text + btn2.Text;
                op = 3;
            }

            if (btn2.Text == "/")
            {

                textBox1.Text = textBox1.Text + btn2.Text;
                op = 4;
            }

            if (btn2.Text == "Pot")
            {
                textBox1.Text = textBox1.Text + btn2.Text;
                op = 5;

            }

            if (btn2.Text == "Div")
            {
                textBox1.Text = textBox1.Text + btn2.Text;
                op = 6;
            }

            if (btn2.Text == "Md")
            {
                textBox1.Text = textBox1.Text + btn2.Text;
                op = 7;
            }

            
            if (btn2.Text == "Bin")
            {
          
                textBox1.Text = Convert.ToString((int)valor1, 2);
                valor1 = 0;
            }

            if (btn2.Text == "Dec")
            {
               //textBox1.Text = Convert.ToInt32(valor1, 2).ToString();
              
            }

            f = 1; // Pode apagar expressão para introduzir o 2º número 
        }



        private void Resultado_Click(object sender, EventArgs e)
        {
     
            Button resultado = sender as Button;
            
            if (op == 1) textBox1.Text = (valor1 + valor2).ToString();
            if (op == 2) textBox1.Text = (valor1 - valor2).ToString();
            if (op == 3) textBox1.Text = (valor1 * valor2).ToString();
            if (op == 4) textBox1.Text = (valor1 / valor2).ToString();
            if (op == 5) textBox1.Text = Math.Pow(valor1, valor2).ToString();
            if (op == 6) textBox1.Text = Math.Round(valor1 / valor2).ToString();
            if (op == 7) textBox1.Text = (valor1 % valor2).ToString();
            r = 1; // Usar o resultado para fazer nova conta
            f = 0;
            op = 0;
            
        }

        private void botao_click(object sender, EventArgs e)
        {
            r = 0;

            Button btn = sender as Button;
            if (btn.Text == "C") 
            {
                textBox1.Text = "";
                valor1 = valor2 = r = 0;
            }
            else
            {


                if (op == 0) 
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                    valor1 = Double.Parse(textBox1.Text);
                }
                else
                {
                    if ((f == 1) && (r==0))
                    {
                        textBox1.Text = "";
                        textBox1.Text = textBox1.Text + btn.Text;
                        valor2 = Double.Parse(textBox1.Text);
                        f = 0;
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + btn.Text;
                        valor2 = Double.Parse(textBox1.Text);
                    }
                 
                }
            }
            
        }
    }
}
