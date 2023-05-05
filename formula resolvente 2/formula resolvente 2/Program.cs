using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formula_resolvente_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            double R1, R2, aux;
            do
            {
                Console.Clear();
                Console.WriteLine("\nFormula Resolvente: Insira os valores de a, b, c:   ");
                a = float.Parse(Console.ReadLine());
                b = float.Parse(Console.ReadLine());
                c = float.Parse(Console.ReadLine());
                if (a!=0) //Posso aplicar a formula resolvente
                {
                    aux = Math.Pow(b, 2)-4*a*c;
                    if (aux>0) // 2 raizes reais
                    {
                        R1 = (-b + Math.Sqrt(aux)/(2*a));
                        R2 = (-b + Math.Sqrt(aux)/(2*a));
                        Console.WriteLine("\n\t R1={0} \n\t R2={1}", Math.Round(R1,2), Math.Round(R2,2));
                    }
                    else
                        if (aux==0)
                        {
                            R1 = -b / (2 * a);
                            Console.WriteLine("\n\t R1=R2={0} ", R1);
                        }
                        else
                            Console.WriteLine("\n\t Números complexos");
                }
                else
                    Console.WriteLine("\nNão posso aplicar a Formula Resolvente\n");

                Console.WriteLine("\nContinuar (S/N)?:   ");

            } while (Console.ReadLine().ToUpper() == "S");

            Console.ReadKey();

        }
    }
}
