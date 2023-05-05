using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Passagem_Parametros
{
    class Program
    {
        // O modificador static indica que só existe uma instancia do objeto, ou seja ele é singular.
        // Main() é um caso especial de um método static. É o entry point do programa.
        // Os métodos static são chamados pelo nome. Não é necessária nenhuma instância e podem ter o modificador public ou private.
        // Método com o modificador public é reconhecido fora da classe.
        // Método com o modificador private só pode ser acedido dentro da classe..
        static void SomaPares()
        {
            int somap = 0;
            Console.Write("\nInsira um valor inteiro: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i <= x; i++)
                if (i % 2 == 0)
                    somap += i;
            Console.WriteLine("\nSoma dos pares = {0}", somap);

        }

        static void PassagemValor(int a)
        {
            a = 6;
        }

        static void PassagemReferencia(ref int a)
        {
            a = 6;
        }
        static void Main(string[] args)
        {
            // Chamada do método SomaPares
            SomaPares();
            int n = 2;
            // Passagem de Parâmetro por valor - é passada uma cópia da variável - fora do método a variável não sofre alteração
            PassagemValor(n);
            Console.WriteLine("\n n = {0}", n);

            // Passagem de parâmetro por referência - é passada a referência da variável - a variável sofre alteração
            // A passagem de parâmetros por referência requer que a variável seja inicializada com um valor
            PassagemReferencia(ref n);
            Console.WriteLine("\n n = {0}", n);

            float n1 = 3.6f, n2 = 5.3f, m, m1;
            MediaOut(n1, n2, out m);
            Console.WriteLine("\n Média = {0}", m);

            m1 = MediaReturn(n1, n2);
            Console.WriteLine("\n Média = {0}", m1);

            Console.ReadKey();
        }

        // Usando o out para retornar valores como parâmetro da função
        static void MediaOut(float f1, float f2, out float med)
        {
            med = (f1 + f2) / 2;
        }

        // Usando o return para retornar valores como parâmetro da função
        static float MediaReturn(float f1, float f2)
        {
            float m = (f1 + f2) / 2;
            return m;

        }
    }
}

