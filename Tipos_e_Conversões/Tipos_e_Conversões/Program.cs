using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_e_Conversões
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mais variáveis
            decimal dec = 123.8976m;    // decimal com 29 casas de precisão (cálculos financeiros)
            float ft1 = 2.45f;          // float com 7 casas de precisão
            double db1 = 2415.12;       //double com 15 casas de precisão
            int n, n1 = 1234567253;
            n = n1 * 3;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("\n\tn1={0}   e   n={1}", n1, n);
            //CONVERSÃO IMPLÍCITA: quando o valor a armazenar cabe na variável sem ser truncado
            long n2 = n1;   // Inteiro longo
            Console.WriteLine("\n\tn2={0}   e   n={1}", n1, n2*3);

            // CONVERSÃO EXPLICITA: tendo consciencia de possível perda de dados
            double db2 = 342.265;
            int num = (int)db2;
            Console.WriteLine("\n\tdb2={0}   e   num={1}", db2, num);

            int nt1 = 12, np = 50;
            Console.WriteLine("\n\tA percentagem de pessoas que não gosta de café = {0}%", (float)nt1/np*100);
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            string nomeH, nomeM, idadeH, idadeM;
            Console.Write("\n\tInsira o nome do homem: ");
            nomeH = Console.ReadLine();
            Console.Write("\n\tInsira o nome da mulher: ");
            nomeM = Console.ReadLine();
            Console.Write("\n\tInsira a idade do {0}: ", nomeH);
            idadeH = Console.ReadLine();
            Console.Write("\n\tInsira a idade da {0}: ", nomeM);
            idadeM = Console.ReadLine();
            Console.ResetColor();
            Console.Clear();

            double media = (Convert.ToDouble(idadeH) + Convert.ToDouble(idadeM)) / 2;
            Console.Write("\n\tA média das idades é {0} ", media);

            Console.ReadKey();

        }
    }
}
