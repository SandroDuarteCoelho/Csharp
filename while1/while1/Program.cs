using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int valor;
            float soma = 0;
            Console.WriteLine("\nInsira 6 valores inteiros:  ");

            /* 
            while (cont<6)
            {
                valor = int.Parse(Console.ReadLine());
                //soma = soma + valor;  
                soma += valor;
                cont++;
            }
            Console.Write("\nMedia= "+soma/ cont);
            

            
            do

            {
                valor = int.Parse(Console.ReadLine());
                //soma = soma + valor;  
                soma += valor;
                cont++;
            } while (cont < 6);
            Console.Write("\nMedia= " + soma / cont);*/

            for ( cont = 0; cont < 6; cont++)
            {
                valor = int.Parse(Console.ReadLine());
                //soma = soma + valor;  
                soma += valor;
            }
            Console.Write("\nMedia= " + soma / cont);

            Console.ReadKey();
        }
    }
}
