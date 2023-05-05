using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_de_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("\t\t\tQUAL O MAIOR ENTRE TRÊS NÚMEROS");
            Console.WriteLine("\nInsira o primeiro número inteiro:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número inteiro");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro número inteiro");
            n3 = int.Parse(Console.ReadLine());
            if (n1 == n2 && n2==n3)
            {
                Console.WriteLine("São iguais");
            }
            else
                if (n1 > n2)
                {
                    if (n1 > n3)
                    {
                        Console.WriteLine("O maior é o " + n1);
                    }
                    else
                    Console.WriteLine("O maior é o " + n3);
                }
                else
                {
                if (n2>n3)
                {
                    Console.WriteLine("O maior é o " + n2);
                }
                else
                    Console.WriteLine("O maior é o " + n3);
            }
            
            

            Console.ReadKey();
        }
    }
}
