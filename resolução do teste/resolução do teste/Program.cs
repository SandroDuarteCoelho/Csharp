using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resolução_do_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Exercício 1: 
            int faltas, notas1, notas2, notas3;
            Console.WriteLine("\nQuantas faltas tem o aluno?  ");
            faltas = int.Parse(Console.ReadLine());
            if (faltas >= 25)
            {
                Console.WriteLine("Reprovado por faltas!");
            }
            else
            {
                Console.WriteLine("Quais as notas dos três testes?");
                notas1 = int.Parse(Console.ReadLine());
                notas2 = int.Parse(Console.ReadLine());
                notas3 = int.Parse(Console.ReadLine());
                if ((notas1+notas2+notas3)/3 < 8)
                {
                    Console.WriteLine(" Reprovado ");
                }
                else
                    Console.WriteLine(" Aprovado ");

            }
            */

            /*
            //Exercicio 2
            int indicativo;
            Console.WriteLine("\nQual o indicativo?  ");
            indicativo = int.Parse(Console.ReadLine());
            switch (indicativo)
            {
                case 21: Console.WriteLine(indicativo + " pertence a Lisboa"); break;
                case 22: Console.WriteLine(indicativo + " pertence ao Porto"); break;
                case 239: Console.WriteLine(indicativo + " pertence a Coimbra"); break;
                case 289: Console.WriteLine(indicativo + " pertence a Faro"); break;
                case 291: Console.WriteLine(indicativo + " pertence ao Funchal"); break;
                case 296: Console.WriteLine(indicativo + " pertence a Ponta Delgada"); break;
                default: Console.WriteLine("\nIndicativo desconhecido!"); break;
            }
            
            */

            /*
            //Exercicio 3
            int numero, maior=0, cont=0;
            do
            {
                Console.WriteLine("\nInsira um número inteiro positivo:  ");
                numero = int.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    if (numero > maior)
                    {
                        maior = numero;
                        cont=1;
                    }
                    else
                        if (numero==maior)
                        {
                        cont++;
                        }
                }
                else
                    Console.WriteLine("Número inválido!");

            } while (numero != 0);
            
            Console.WriteLine("\nO maior é:  "+maior);
            Console.WriteLine("\nFoi inserido "+cont+" vezes.");
            */
            
            /*
            //Exercicio 4
            float mesada, chocolate, saldo;
            int cont=0;
            Console.Write("\nQual o valor da mesada (euros)? ");
            mesada = float.Parse(Console.ReadLine());
            saldo = mesada;
            Console.Write("\nQuanto custa o chocolate (euros)? ");
            chocolate = float.Parse(Console.ReadLine());
            if ((chocolate == 0) || (mesada < chocolate))
            {
                Console.Write("\nNão me apetece resolver.");
            }
            else
            {
                do
                {
                    saldo = saldo - chocolate;
                    cont++;
                } while (saldo >= chocolate);
                Console.WriteLine("\nComprou " + cont + " chocolates e ficou com o saldo igual a " + saldo + " euros.");
            }
            */

            
            //Exercicio 5
            int num1, num2, soma = 0, cont = 0;
            Console.WriteLine("\nIntroduza dois numeros inteiros positivos: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            if ((num1 != num2) && (num1 > 0) && (num2 > 0))
            {
                if (num1 < num2)
                {
                    for (int ciclo = num1; ciclo <= num2; ciclo++)
                    {
                        if ((ciclo % 2) != 0)
                        {
                            soma = soma + ciclo;
                            cont++;
                        }
                    }
                }
                else
                {
                    for (int ciclo = num2; ciclo <= num1; ciclo++)
                    {
                        if ((ciclo % 2) != 0)
                        {
                            soma = soma + ciclo;
                            cont++;
                        }
                    }
                }
                Console.Write("\nSoma igual a " + soma + " e média igual a " + soma / cont);

            }
            
            else
            {
            if ((num1 == num2) && (num1 % 2 != 0))
                {
                    soma = num1 + num2;
                    Console.Write("\nSoma igual a " + soma + " e média igual a " +soma/2 );
                }
            else
                {
                    if ((num1 == num2) && (num1 % 2 == 0))
                    {
                        Console.Write("\nSoma igual a 0");
                    }
                    else
                    {
                        Console.Write("\nNúmeros inválidos");
                    }
                        
                }
            
            }
            

            /*
            //Exercicio 6
            char genero, gostou;
            int masculinos = 0, femininos = 0, mascgostou = 0, mascnaogostou=0, femgostou = 0;
            int pessoas=1, femnaogostou =0, cont;
            do
            {
                cont = 0;
                Console.WriteLine("\nPESSOA= " + pessoas);
                Console.WriteLine("\nQual o género da pessoa? (M)asculino (F)eminino");
                genero = char.Parse(Console.ReadLine());
                switch (genero)
                {
                    case 'M': cont = 1; break;
                    case 'm': cont = 1; break;
                    case 'F': cont = 2; break;
                    case 'f': cont = 2; break;
                    default: Console.WriteLine("\nOpção errada!"); break;
                }

                if (cont==1)
                {
                    Console.WriteLine("\nGostou do produto? (S)im (N)ão");
                    gostou = char.Parse(Console.ReadLine());
                    switch (gostou)
                    {
                        case 'S': ++masculinos; ++mascgostou; break;
                        case 's': ++masculinos; ++mascgostou; break;
                        case 'N': ++masculinos; ++mascnaogostou; break;
                        case 'n': ++masculinos; ++mascnaogostou; break;
                        default: cont = 0; Console.WriteLine("\nOpção errada!"); break;
                    }
                }

                if (cont == 2)
                {
                    Console.WriteLine("\nGostou do produto? (S)im (N)ão");
                    gostou = char.Parse(Console.ReadLine());
                    switch (gostou)
                    {
                        case 'S': ++femininos; ++femgostou; break;
                        case 's': ++femininos; ++femgostou; break;
                        case 'N': ++femininos; ++femnaogostou; break;
                        case 'n': ++femininos; ++femnaogostou; break;
                        default: cont = 0; Console.WriteLine("\nOpção errada!"); break;
                    }
                }

                if (cont != 0)
                {
                    pessoas++;
                }
            } while (pessoas < 51);
                       
            Console.WriteLine("\nNúmero de pessoas que gostaram do produto: "+(mascgostou+femgostou));
            Console.WriteLine("Número de pessoas que não gostaram do produto: " + (mascnaogostou + femnaogostou));
            Console.WriteLine("Percentagem de pessoas do género masculino que não gostaram do produto: " + (mascnaogostou*100)/masculinos+"%");
            if (mascgostou > femgostou)
            {
                Console.WriteLine("O género que teve maior aceitação foi o masculino");
            }
            else
            {
                Console.WriteLine("O género que teve maior aceitação foi o feminino");
            }
            */
            Console.ReadKey();
        }
    }
}
