using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Um array é uma variável composta que suporta n elementos todos do mesmo tipo.
            // Declara e instancia um array unidimensional
            float[] notas = new float[10];
            // Acesso direto
            notas[0] = 12.7f;
            // Declara e inicializa o array numeros de dimensão 4
            int[] numeros = new int[] { 1, 2, 3, 4 };
            int[] xpto = new int[4];
            xpto[0] = 1;
            xpto[1] = 2;
            xpto[2] = 3;
            xpto[3] = 4;

            
            // Acesso indireto
            // Ler as notas dos 10 alunos e indicar a nota máxima, a nota mínima, a média da turma, o nº de alunos com negativas
            float soma=0;
            int neg = 0;
            Console.WriteLine("Insira as 10 notas dos alunos: ");
            for (int i=0; i<10; i++)
            {
                notas[i] = float.Parse(Console.ReadLine());
                soma += notas[i]; // soma = soma + notas [i]
                if (notas[i] < 10)
                    neg++;
            }
            // Ordenar
            Array.Sort(notas);
            for (int i = 0; i < 10; i++)
                Console.Write(notas[i] + " ");
       //     Console.Write("\n Média = {0}", soma / 10);
            Console.Write("\n Média = {0}", notas.Average());
            Console.Write("\n Negativas= {0}", neg);
            Console.Write("\n Maxima = {0} e Mínima = {1}", notas.Max(), notas.Min());
            
            /*
            int[] num2 = new int[4];
            Console.WriteLine("\nDimensão do array = {0}", num2.Length);

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + "");
            }
            Console.Write("\n\n");
            
            // Copia integral do array numeros para o array num2
            // Array.Copy(numeros, num2.Length);

            //Cópia dos 2 primeiros elemenos do array numeros para o num2
            Array.Copy(numeros, num2, 2);
            for (int i = 0; i < num2.Length; i++)
            {
                Console.Write(num2[i] + "");
            }

            Console.Write("\n\n");
            int[] num3 = new int[4];
            // Copia 2 elementos do array numeros a partir do indice 2 para o array num3 a partir do indice 0
            Array.Copy(numeros, 2, num3, 0, 2);
            for (int i = 0; i < num3.Length; i++)
            {
                Console.Write(num3[i] + "");
            }
            */
            Console.ReadKey();
        }
    }
}

