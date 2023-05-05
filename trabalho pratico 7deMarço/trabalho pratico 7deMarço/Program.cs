using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_pratico_7deMarço
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Exercício 1
            int total;
            float valor, vtotal=0;
            Console.Write("Qual o número total de mercadorias em stock? ");
            total=int.Parse(Console.ReadLine());
            for (int ciclo = 1; ciclo <= total; ciclo++)
            {
                Console.Write("Qual o valor do {0} artigo (euros)? ", ciclo);
                valor = float.Parse(Console.ReadLine());
                vtotal = vtotal + valor;
            }
            Console.Write("O valor total em stock é {0} euros, a média de valor das mercadorias é {1} euros.", vtotal, Math.Round((vtotal / total),2));
            */

            /*
            // Exercicio 2
            int total = 0;
            float valor, vtotal=0;
            do
            {
                total++;
                Console.Write("\nQual o valor do {0} artigo (euros)? ", total);
                valor = float.Parse(Console.ReadLine());
                vtotal = vtotal + valor;
                Console.Write("MAIS MERCADORIAS (S/N)? ");
                

            } while (Console.ReadLine().ToUpper() != "N");
            Console.Write("O valor total em stock é {0} euros, a média de valor das mercadorias é {1} euros.", vtotal, Math.Round((vtotal / total),2));
            */

            /*
            // Exercício 3
            int voto, maior=0;
            int[] total = new int[6];
            int[] vencedores = new int[4];
            vencedores[0] = 1;
            do
            {
                Console.WriteLine("\nIntroduza o seu voto (1,2,3,4 = voto para os respectivos candidatos):\n5 = voto em branco\noutro = voto nulo\nTerminar=0");
                voto = int.Parse(Console.ReadLine());

                switch (voto)
                {
                    case 1: total[0]++; break;
                    case 2: total[1]++; break;
                    case 3: total[2]++; break;
                    case 4: total[3]++; break;
                    case 5: total[4]++; break;
                    default: total[5]++; break;
                }

                Console.Clear();
            } while (voto != 0);

            Console.Write("\nCandidato 1 = {0} votos", total[0]);
            Console.Write("\nCandidato 2 = {0} votos", total[1]);
            Console.Write("\nCandidato 3 = {0} votos", total[2]);
            Console.Write("\nCandidato 4 = {0} votos", total[3]);
            Console.Write("\nVotos em branco = {0} votos", total[4]);
            Console.Write("\nVotos nulos = {0} votos", total[5]-1);
            for (int pos = 1; pos < 4; pos++) 
            {
                
                if (total[pos] > total[maior])
                {
            
                    for (int pos2=0;pos2<pos;pos2++) // Põe a 0 qualquer candidato vencedor sinalizado anteriormente
                        vencedores[pos2] = 0;

                    vencedores[pos] = 1; // Sinaliza o novo candidato vencedor
                    maior = pos;
                    Console.Write("Vencedor [{0}] = {1}", pos, vencedores[pos]);
                    
                }
                else
                {
                    if (total[pos] == total[maior]) // Se outro candidato tiver o mesmo numero de votos que o maior, põe a 1
                        vencedores[pos] = 1;
                }
   
            }
            Console.Write("\n\nOs Vencedores são:");
            for (int pos=0; pos<4;pos++)
            {
                if (vencedores[pos]==1)
                    Console.Write("\nCandidato {0} com {1} votos", pos+1, total[pos]);
            }
          */
            /*
             // Exercicio 4
             DateTime agora = DateTime.Now;
             int ano = agora.Year;
             int numero, aNasc, aIngr;
             do
             {
                 Console.Clear();
                 Console.Write("Qual o número do empregado? ");
                 numero = int.Parse(Console.ReadLine());
                 if (numero != 0)
                 {
                     Console.Write("Qual o ano do seu nascimento? ");
                     aNasc = int.Parse(Console.ReadLine());
                     Console.Write("Qual o ano do ingresso na empresa? ");
                     aIngr = int.Parse(Console.ReadLine());
                     Console.Write("\nTem {0} anos. O tempo de trabalho é de {1} anos.", ano - aNasc, ano - aIngr);
                     if (((ano - aNasc >= 65) || (ano - aIngr >= 30)) || ((ano - aNasc >= 60) && (ano - aIngr >= 35)))
                         Console.Write("\n\n\tRequerer Reforma!");

                     else
                         Console.Write("\n\n\tNão Requerer!");

                     Console.ReadKey();
                 }

             }
             while (numero != 0);
           */

            /*
            // Exercicio 5
            int habitantes=0, salario, filhos, TSalarios=0, Msalario=0, TFilhos=0, salarioB=0;
            do
            {
                Console.Write("\nQual o valor do salário? (euros) ");
                salario = int.Parse(Console.ReadLine());
                if (salario > 0)
                {
                    TSalarios += salario;
                    if (salario < 500)
                        salarioB++;
                    if (salario > Msalario)
                        Msalario = salario;

                    Console.Write("Qual o número de filhos? ");
                    filhos = int.Parse(Console.ReadLine());
                    TFilhos += filhos;
                    habitantes++;
                }
            }
            while (salario > 0);

            Console.Write("\nA média do salário da população é de {0} euros.", TSalarios/habitantes);
            Console.Write("\nA média do número de filhos é de {0}.", (float)TFilhos/habitantes);
            Console.Write("\nO maior salário por habitante é de {0} euros.", Msalario);
            Console.Write("\nA percentagem de pessoas com salário menor que 500 euros é de {0} %.", (salarioB*100)/habitantes);
            */

            
            // Exercicio 6
            decimal dinheiro = 0, doisE = 0, umE = 0, cinquentaC=0, vinteC=0, dezC=0, cincoC=0 ;
            do
            {
                Console.Clear();
                Console.Write("O custo de cada café é de 0,35 euros.\nA máquina aceita moedas de 0,05, 0,10, 0,20, 0,50, 1 e 2.\n\nIntroduza o dinheiro: ");
                dinheiro = decimal.Parse(Console.ReadLine());
            } while (dinheiro < 0.35m);
  //          Math.Round(dinheiro, 2);
            dinheiro -= 0.35m;
            Console.WriteLine("\nO seu troco é de {0} euros:", dinheiro);

            while (dinheiro >= 2)
            {
                dinheiro -= 2;
                doisE++;
            }
           
           while (dinheiro >= 1)
           {
       //         Math.Round(dinheiro, 2);
                dinheiro -= 1;
                umE++;
           }
            while (dinheiro >= 0.5m)
            {
                 cinquentaC++;
  //                  Math.Round(dinheiro, 2);
                dinheiro = dinheiro - 0.5m;
               
      //          Math.Round(dinheiro -= 0.5f,2);
            }
            while (dinheiro >= 0.2m)
            {
                 vinteC++;
 //               Math.Round(dinheiro, 2);
                dinheiro -= 0.2m;
            }
            while (dinheiro >= 0.1m)
            {
                 dezC++;
 //               Math.Round(dinheiro, 2);
                dinheiro -= 0.1m;
            //    Convert.ToDouble(dinheiro);
             //   Math.Ceiling(dinheiro);
            }
            while (dinheiro >= 0.05m)
            {
                 cincoC++;
 //               Math.Round(dinheiro, 2);
                dinheiro -= 0.05m;
            }
  
            Console.WriteLine("\nMoedas 2 euros={0}\nMoedas 1 euro={1}\nMoedas 50 centimos={2}\nMoedas 20 centimos={3}\nMoedas 10 centimos={4}\nMoedas 5 centimos={5}", doisE, umE, cinquentaC, vinteC, dezC, cincoC);
            Console.WriteLine("\nDinheiro = {0}", dinheiro);
            

            /*
            // Exercicio 7
            int anos;
            float taxa, deposito;
            Console.WriteLine("Qual a quantia do depósito bancário? (euros)");
            deposito = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Qual o valor da taxa de juro inicial? (superior a 5,0%)");
                taxa = float.Parse(Console.ReadLine());
            } while (taxa <= 5);
            Console.WriteLine("Para quantos anos?");
            anos = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nAno\tCapital Inicial\t\tTaxa Juros\tJuros\t\tCapital Final");

            for (int i=1;i<=anos;i++)
            {
                Console.WriteLine(" {0}\t{1} euros\t\t  {2} %\t\t{3} euros \t{4} euros", i, Math.Round(deposito), taxa, Math.Round(taxa*deposito)/100, Math.Round(deposito + ((taxa * deposito) / 100)));
                deposito += (taxa * deposito) / 100;

                if (taxa > 5)
                    taxa -= 0.5f;
                else
                    taxa = 5;
            }
            */
            Console.ReadKey();


        }
    }
}
