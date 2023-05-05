using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_de_dois
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("\t\t\tQUAL O MAIOR ENTRE DOIS NÚMEROS");
            Console.WriteLine("\nInsira o primeiro número inteiro:");
            n1=int.Parse(Console.ReadLine ());
            Console.WriteLine("Insira o segundo número inteiro");
            n2 = int.Parse(Console.ReadLine());
            if (n1>n2)
            {
                Console.WriteLine("O maior é o "+n1);
            }
            else
                if (n1 < n2)
                {
                    Console.WriteLine("O maior é o " + n2);
                }
                else
                Console.WriteLine("São iguais");

            Console.ReadKey();
        }
    }
}
