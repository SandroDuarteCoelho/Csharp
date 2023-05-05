using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_final
{
    class Program
    {
        static void Main(string[] args)
        {
            int opção, operação;
            double valor1, valor2;
            string bin;
            do
            { 
            Console.Clear();
            Console.WriteLine("\t\t\t\tCALCULADORA\n");
            Console.WriteLine("\t 0. Sair");
            Console.WriteLine("\t 1. Operações aritméticas básicas (+, -, *, /)");
            Console.WriteLine("\t 2. Quadrado de um número");
            Console.WriteLine("\t 3. Cubo de um número");
            Console.WriteLine("\t 4. Potência");
            Console.WriteLine("\t 5. Inverso de um número");
            Console.WriteLine("\t 6. Percentagem");
            Console.WriteLine("\t 7. Raiz quadrada de um número");
            Console.WriteLine("\t 8. Seno");
            Console.WriteLine("\t 9. Cosseno");
            Console.WriteLine("\t10. Tangente");
            Console.WriteLine("\t11. Bin – converter decimal para binário");
            Console.WriteLine("\t12. Dec – Converter binário para decimal");
            Console.WriteLine("\t13. Mod – Resto da divisão inteira");
            Console.WriteLine("\t14. Div – Quociente da divisão inteira");
            opção = int.Parse(Console.ReadLine());

                if (opção != 0)
                {
                    Console.Clear();
                    switch (opção)
                    {
                        case 1: // Operações aritméticas básicas (+, -, *, /)
                            {
                                Console.WriteLine("\t\tOperações aritméticas básicas (+, -, *, /)\n");
                                Console.WriteLine("\tEscolha uma operação\n\n\t1.Soma\t2. Subtração\t3. Multiplicação\t4. Divisão");
                                operação = int.Parse(Console.ReadLine());
                                switch (operação)
                                {
                                    case 1: // Soma
                                        {
                                            Console.WriteLine("\n\nSoma ==> Insira dois valores:");
                                            valor1 = int.Parse(Console.ReadLine());
                                            valor2 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("\t{0} + {1} = {2}", valor1, valor2, valor1 + valor2);
                                            break;
                                        }
                                    case 2: // Subtração
                                        {
                                            Console.WriteLine("\n\nSubtração ==> Insira dois valores:");
                                            valor1 = int.Parse(Console.ReadLine());
                                            valor2 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("\t{0} - {1} = {2}", valor1, valor2, valor1 - valor2);
                                            break;
                                        }
                                    case 3: // Multiplicação
                                        {
                                            Console.WriteLine("\n\nMultiplicação ==> Insira dois valores:");
                                            valor1 = int.Parse(Console.ReadLine());
                                            valor2 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("\t{0} x {1} = {2}", valor1, valor2, valor1 * valor2);
                                            break;
                                        }
                                    case 4: // Divisão
                                        {
                                            Console.WriteLine("\n\nDivisão ==> Insira dois valores:");
                                            valor1 = int.Parse(Console.ReadLine());
                                            valor2 = int.Parse(Console.ReadLine());
                                            if (valor2==0)
                                                Console.WriteLine("\tDivisão impossivel");
                                            else
                                                Console.WriteLine("\t{0} / {1} = {2}", valor1, valor2, valor1 / valor2);

                                            break;
                                        }
                                }


                                break;
                            }
                        case 2: // Quadrado de um número
                            {
                                Console.Write("\t\tQuadrado de um número\n");
                                Console.Write("\n\t\tInsira um número:");
                                valor1 = int.Parse(Console.ReadLine());
                                Console.Write("\n\t\tO quadrado de {0} é {1}", valor1, Math.Pow(valor1,2));
                                break;
                            }
                        case 3: // Cubo de um número
                            {
                                Console.WriteLine("\t\tCubo de um número\n");
                                Console.Write("\n\t\tInsira um número:");
                                valor1 = int.Parse(Console.ReadLine());
                                Console.Write("\n\t\tO cubo de {0} é {1}", valor1, Math.Pow(valor1, 3));
                                break;
                            }
                        case 4: // Potência
                            {
                                Console.WriteLine("\t\tPotência\n");
                                Console.Write("\n\t\tInsira um número:");
                                valor1 = int.Parse(Console.ReadLine());
                                Console.Write("\n\t\tInsira qual a potência:");
                                valor2 = int.Parse(Console.ReadLine());
                                Console.Write("\n\t\t{0} elevado a {1} = {2}", valor1, valor2, Math.Pow(valor1, valor2));
                                break;
                            }
                        case 5: // Inverso de um número (1/x)
                            {
                                Console.WriteLine("\t\tInverso de um número\n");
                                Console.Write("\n\t\tInsira um número:");
                                valor1 = double.Parse(Console.ReadLine());
                                Console.Write("\n\t\tO inverso de {0} é {1}",valor1, (1/valor1));
                                break;
                            } 
                        case 6: // Percentagem
                            {
                                Console.WriteLine("\t\tPercentagem de um número\n");
                                Console.Write("\n\t\tInsira um número: ");
                                valor1 = int.Parse(Console.ReadLine());
                                Console.Write("\n\t\tQual o valor da percentagem?(%) ");
                                valor2 = int.Parse(Console.ReadLine());
                                Console.Write("\n\t\t{0}% de {1} = {2}", valor2, valor1,(valor2* valor1)/100);
                                break;
                            }
                        case 7: // Raiz quadrada de um número
                            {
                                Console.WriteLine("\t\tRaiz quadrada de um número\n");
                                Console.Write("\n\t\tInsira um número: ");
                                valor1 = int.Parse(Console.ReadLine());
                                Console.Write("\n\t\tRaiz quadrada de {0} é {1}", valor1, Math.Sqrt(valor1));
                                break;
                            }
                        case 8: // Seno
                            {
                                Console.WriteLine("\t\tSeno\n");
                                Console.Write("\n\t\tInsira um número: ");
                                valor1 = int.Parse(Console.ReadLine());
                                Console.Write("\n\t\tO seno de {0} radianos é {1} .", valor1,Math.Sin(valor1));
                                Console.Write("\n\t\tO seno de {0} graus é {1} .", valor1,Math.Sin((valor1*Math.PI)/180));
                                break;
                            }
                        case 9: // Cosseno
                            {
                                Console.WriteLine("\tCosseno\n");
                                Console.Write("\n\t\tInsira um número: ");
                                valor1 = int.Parse(Console.ReadLine());
                                Console.Write("\n\t\tO Cosseno de {0} radianos é {1} .", valor1, Math.Cos(valor1));
                                Console.Write("\n\t\tO Cosseno de {0} graus é {1} .", valor1, Math.Round(Math.Cos((valor1 * Math.PI) / 180)),4);
                                break;
                            }
                        case 10: // Tangente
                            {
                                Console.WriteLine("\tTangente\n");
                                Console.Write("\n\t\tInsira um número: ");
                                valor1 = int.Parse(Console.ReadLine());
                                Console.Write("\n\t\tA Tangente de {0} radianos é {1} .", valor1, Math.Tan(valor1));
                                Console.Write("\n\t\tA TCosseno de {0} graus é {1} .", valor1, Math.Tan((valor1 * Math.PI) / 180));
                                break;
                            }
                        case 11: // Bin – converter decimal para binário
                            {
                                Console.WriteLine("\tBin – converter decimal para binário\n");
                                Console.Write("\n\t\tInsira um número decimal: ");
                                valor1 = int.Parse(Console.ReadLine());
                                Console.Write("\n\t{0} em binário = ", valor1);

                                bin = Convert.ToString((int)valor1, 2); //  vai converter o valor introduzido para a base 2 (binário)
                                Console.Write("{0}\n\n", bin);
                                                          
                                break;
                            }
                        case 12: // Dec – Converter binário para decimal
                            {
                                Console.WriteLine("\tDec – Converter binário para decimal\n");
                                Console.Write("\n\t\tInsira um número binário: ");
                                bin = Console.ReadLine();

                                valor1 = Convert.ToInt32((string)bin, 2);
                                Console.Write("{0}\n\n", valor1);

                               

                                break;
                            }
                        case 13: // Mod – Resto da divisão inteira
                            {
                                Console.WriteLine("\t\tResto da divisão inteira\n");
                                Console.WriteLine("\n\nInsira dois valores inteiros:");
                                valor1 = int.Parse(Console.ReadLine());
                                valor2 = int.Parse(Console.ReadLine());
                                if (valor2 == 0)
                                    Console.WriteLine("\tDivisão impossivel");
                                else
                                    Console.WriteLine("\tO resto da divisão inteira entre {0} e {1} = {2}", valor1, valor2, valor1 % valor2);
                                break;
                            }
                        case 14: // Div – Quociente da divisão inteira
                            {
                                Console.WriteLine("\tDiv – Quociente da divisão inteira\n");
                                Console.WriteLine("\n\nInsira dois valores:");
                                valor1 = int.Parse(Console.ReadLine());
                                valor2 = int.Parse(Console.ReadLine());
                                if (valor2 == 0)
                                    Console.WriteLine("\tDivisão impossivel");
                                else
                                    Console.WriteLine("\t{0} / {1} = {2}", valor1, valor2, Math.Round(valor1 / valor2));
                                break;
                            }
                    }

                }
                Console.ReadKey();

            } while (opção != 0);


            
        }
    }
}
