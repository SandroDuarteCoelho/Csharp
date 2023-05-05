using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formula_resolvente
{
    class Program
    {
        static void Main(string[] args)
        {
            double r1, r2, aux;
            int a, b, c;
            Console.WriteLine("\t\t\tFORMULA RESOLVENTE");
            Console.Write("\n\nInsira o valor de a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("\nInsira o valor de b:");
            b = int.Parse(Console.ReadLine());
            Console.Write("\nInsira o valor de c:");
            c = int.Parse(Console.ReadLine());

            if (a==0)
            {
                Console.Write("\nNão é possivel aplicar Fórmula Resolvente");
            }
            else
            {
                aux = (b * b) - 4 * a * c;
                if (aux>0)
                {
                    r1 = (-b - Math.Sqrt(aux)) / (2 * a);
                    r2 = (-b + Math.Sqrt(aux)) / (2 * a);
                    Console.Write("\nRaiz 1= "+r1+"\tRaiz 2= "+r2);
                }
                else
                {
                    if (aux==0)
                    {
                        r1 = -b / (2 * a);
                        Console.Write("\nRaiz 1= " + r1+"\té raiz dupla");
                    }
                    else
                    {
                        Console.Write("\nRaizes complexas");
                    }
                }
            }
            
                                 
            Console.ReadKey();
        }
    }
}
