using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta_bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int opção, n;

            //instancia uma conta usando a construtora com parametros (numero conta, saldo)
            Conta sandro = new Conta(12345, 300);
            

            Console.WriteLine("Multibanco - Operações");
            Console.WriteLine("1-Consultar");
            Console.WriteLine("2-Levantar");
            Console.WriteLine("3-Depositar");
            Console.WriteLine("4-Transferir");
            opção = int.Parse(Console.ReadLine()); ;
            switch (opção)
            {
                case 1:
                    {
                        Console.WriteLine("\n1-Consultar\nInsira o nib: ");
                        n = int.Parse(Console.ReadLine());

                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("2-Levantar");
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("3-Depositar");
                        break;
                    }

                case 4:
                    {
                        Console.WriteLine("4-Transferir");
                        break;
                    }

                default:
                    break;
            }


            Console.ReadKey();

        }
    }
}


