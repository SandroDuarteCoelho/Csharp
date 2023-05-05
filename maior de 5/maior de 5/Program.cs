using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_de_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, aux;
            Console.WriteLine("\t\t\tQUAL O MAIOR ENTRE CINCO NÚMEROS");
            Console.WriteLine("\nInsira o primeiro número inteiro:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número inteiro");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro número inteiro");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o quarto número inteiro");
            n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o quinto número inteiro");
            n5 = int.Parse(Console.ReadLine());
            aux = n1;

            if (n2 > aux)
            {
                aux=n2;
            }

            if (n3 > aux)
            {
                aux = n3;
            }

            if (n4 > aux)
            {
                aux = n4;
            }

            if (n5 > aux)
            {
                aux = n5;
            }

            Console.WriteLine("O maior é o " + aux);
                

            
            Console.ReadKey();
        }
    }
}
