using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resolucao_teste_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Exercício 1: Lê o numero de faltas do aluno e reprova se for maior ou igual a 25. Se for menor que 25 pede a 
            // nota dos três testes e calcula a média. 0 a 8 Reprovado, 8 a 10 Recuperação, 10 a 20 Aprovado.
           int faltas;
           float notas1, notas2, notas3;
           Console.WriteLine("\nQuantas faltas tem o aluno?  ");
           faltas = int.Parse(Console.ReadLine());
           if (faltas >= 25)    // Verifica se reprovou por faltas
               Console.WriteLine("Reprovado por faltas!");
           else
           {
               Console.WriteLine("Quais as notas dos três testes?");
               notas1 = float.Parse(Console.ReadLine());
               notas2 = float.Parse(Console.ReadLine());
               notas3 = float.Parse(Console.ReadLine());
               if ((notas1 + notas2 + notas3) / 3 < 8) // Verifica se a média é inferior a 8
                    Console.WriteLine(" Reprovado ");
               else
                {
                    if ((notas1 + notas2 + notas3) / 3 >= 8 && (notas1 + notas2 + notas3) / 3 < 10) // Verifica se a média está entre 8 e 9, inferior a 10
                        Console.WriteLine(" Recuperação ");
                    else 
                        Console.WriteLine(" Aprovado ");
                }
           }
           
           */
            /*
            //Exercicio 2: Lê o indicativo telefónico e diz a que cidade pertence.
            int indicativo, erro;
            do
            {
                erro = 0;
                Console.Clear();
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
                    default: Console.WriteLine("\nIndicativo desconhecido!"); erro = 1; break;
                }
                Console.ReadKey();
            } while (erro == 1); // Repete enquanto o indicativo for desconhecido

            */

            /*
            // Exercicio 3: Lê uma sequência de números inteiros positivos e indica qual o maior e 
            // quantas vezes foi inserido. Termina com o 0 (zero) 
            int numero, maior=0, cont=0;
            do
            {
                Console.WriteLine("\nInsira um número inteiro positivo ('0' Para terminar):  ");
                numero = int.Parse(Console.ReadLine());
                if (numero > 0) // Verifica se o número é positivo
                {
                    if (numero > maior) // Verifica se o número que foi inserido é maior ao que já existia
                    {
                        maior = numero;
                        cont=1;
                    }
                    else
                        if (numero==maior) // Se o número inserido for igual ao maior acrescenta ao número de vezes que é inserido
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
            // Exercicio 4 : Lê o valor da mesada e o preço do chocolate. 
            // Mostra quantos chocolates consegue comprar e quanto dinheiro sobra
            float mesada, chocolate, saldo;
            int cont=0;
            Console.Write("\nQual o valor da mesada (euros)? ");
            mesada = float.Parse(Console.ReadLine());
            saldo = mesada;
            Console.Write("\nQuanto custa o chocolate (euros)? ");
            chocolate = float.Parse(Console.ReadLine());
            if ((chocolate == 0) || (mesada < chocolate)) // Verifica se o preço do chocolate é zero ou superior à da mesada
                 Console.Write("\nNão me apetece resolver.");
            else
            {
                do
                {
                    saldo = saldo - chocolate;
                    cont++;
                } while (saldo >= chocolate); // Verifica se existe dinheiro suficiente para comprar mais chocolate
                Console.WriteLine("\nComprou " + cont + " chocolates e ficou com o saldo igual a " + saldo + " euros.");
            }
            */

            /*
            // Exercicio 5: Lê dois numeros inteiros positivos e apresenta a soma e a média dos numeros ímpares
            // entre esses dois valores, incluindo os valores inseridos
            int num1, num2, aux=0, soma = 0, cont = 0;
            Console.WriteLine("\nIntroduza dois numeros inteiros positivos: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            if ((num1 != num2) && (num1 > 0) && (num2 > 0)) // Verifica se os números são diferentes e positivos
            {
                if (num1 > num2) // Verifica se o primeiro numero inserido é superior ao segundo
                {
                    aux = num1; num1 = num2; num2 = aux; // Troca a posição dos números com uma variável auxiliar
                }

                for (int ciclo = num1; ciclo <= num2; ciclo++)
                {
                    if ((ciclo % 2) != 0) // Verifica se o número é ímpar
                    {
                        soma = soma + ciclo;
                        cont++;
                    }
                }

                Console.Write("\nSoma igual a " + soma + " e média igual a " + soma / cont);
            }
            else
            {
                if ((num1 == num2) && (num1 % 2 != 0)) 
                {
                    soma = num1 + num2;
                    Console.Write("\nSoma igual a " + soma + " e média igual a " + soma / 2);
                }
                else
                {
                    if ((num1 == num2) && (num1 % 2 == 0))
                        Console.Write("\nSoma igual a 0");
                    else
                        Console.Write("\nNúmeros inválidos");
                }
            }           
            */
            /*
            //Exercicio 6: Pesquisa de mercado para saber se gostaram ou não do produto, universo masculino e feminino de 50 pessoas.
            char genero, gostou;
            int masculinos = 0, femininos = 0, mascgostou = 0, mascnaogostou=0, femgostou = 0;
            int pessoas = 1, femnaogostou = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\nPESSOA= " + pessoas);
                Console.WriteLine("\nQual o género da pessoa? (M)asculino (F)eminino");
                genero = char.Parse(Console.ReadLine().ToUpper()); // Recebe o valor e converte logo para maiusculas
                            
                if (genero == 'M')
                {
                    Console.WriteLine("\nGostou do produto? (S)im (N)ão");
                    gostou = char.Parse(Console.ReadLine().ToUpper());
                    if (gostou == 'S')
                    {
                        ++masculinos; ++mascgostou; ++pessoas; // Acrescenta ao total masculinos, masculinos que gostaram e valida a pessoa
                    }
                    else
                    {
                        if (gostou == 'N')
                        {
                            ++masculinos; ++mascnaogostou; ++pessoas;
                        }
                        else
                            Console.WriteLine("\nOpção errada!");
                    }
                }
                else
                {
                    if (genero == 'F')
                    {
                        Console.WriteLine("\nGostou do produto? (S)im (N)ão");
                        gostou = char.Parse(Console.ReadLine().ToUpper());
                        if (gostou == 'S')
                        {
                            ++femininos; ++femgostou; ++pessoas;
                        }
                        else
                        {
                            if (gostou == 'N')
                            {
                                ++femininos; ++femnaogostou; ++pessoas;
                            }
                            else
                                Console.WriteLine("\nOpção errada!");
                        } 
                    }
                    else
                        Console.WriteLine("\nOpção errada!");
                }
                Console.ReadKey();
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
