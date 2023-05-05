using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, resultado=1;

            //Multiplicar os primeiros N números inteiros positivos(factorial de N), sendo N definido pelo utilizador:

            Console.Write("Qual o factorial que quer fazer: ");
            num = int.Parse(Console.ReadLine());

            //Console.WriteLine($"resultado: {resultado}");
            for (int i = num; i > 0; i--)
            {
                //Console.WriteLine(i);
                resultado = resultado * i;
            }
            Console.WriteLine($"Fatorial de {num} é {resultado}");

            Console.ReadKey(); 

        }
    }
}
