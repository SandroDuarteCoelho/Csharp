using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cometário até ao fim da linha
            Console.WriteLine("Boa noite");
            int n1, n2;
            double n3, soma;
            Console.WriteLine("Insira o primeiro valor inteiro:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor inteiro:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro valor inteiro:");
            n3 = double.Parse(Console.ReadLine());
            soma = n1 + n2 + n3;
            Console.WriteLine("\n\n\tSoma="+soma);
            Console.WriteLine("\n\n\t"+n1+"+"+n2+ "+"+n3+"="+soma);
            string nome;
            int idade;
            Console.WriteLine("Insira o nome:   ");
            nome = Console.ReadLine();
            Console.WriteLine("Insira a idade:   ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("O seu nome é "+nome+" e tem "+idade+" anos.");
            int quociente;
            if (n2 != 0)
            {
                quociente = n1 / n2;
                Console.WriteLine("\nquociente= " + quociente);
            }
            else
                Console.WriteLine("\nDivisão impossível");

            Console.ReadKey();
        }
    }
}
