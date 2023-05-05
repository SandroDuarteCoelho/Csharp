using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escolha_multipla
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.Write("Escreva um número entre 1 e 7 e devolverá o dia da semana: ");
            dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1: Console.WriteLine(dia+" corresponde a Domingo"); break;
                case 2: Console.WriteLine(dia + " corresponde a Segunda-feira"); break;
                case 3: Console.WriteLine(dia + " corresponde a Terça-feira"); break;
                case 4: Console.WriteLine(dia + " corresponde a Quarta-feira"); break;
                case 5: Console.WriteLine(dia + " corresponde a Quinta-feira"); break;
                case 6: Console.WriteLine(dia + " corresponde a Sexta-feira"); break;
                case 7: Console.WriteLine(dia + " corresponde a Sábado"); break;
                default: Console.WriteLine("\nNão corresponde a nenhum dia da semana."); break;
            }

            Console.ReadKey();
        }
    }
}
