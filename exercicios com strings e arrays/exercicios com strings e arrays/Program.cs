using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_com_strings_e_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício - Conta vogais
            /*
            string str; // Vai conter o texto lido
            int cta, cte, cti, cto, ctu; // Contadores das vogais
            cta = cte = cti = cto = ctu = 0; // Inicializa todos os contadores

            Console.WriteLine("Insira um texto (contar as vogais):");
            str = Console.ReadLine();
            // A propriedade Length tem a dimensão efectivamente preenchida da string str
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])     // Verifica o caracter na posição i (índice)
                {
                    case 'A':
                    case 'a': cta++; break; // conta vogal a maiuscula ou minuscula
                    case 'E':
                    case 'e': cte++; break;
                    case 'I':
                    case 'i': cti++; break;
                    case 'O':
                    case 'o': cto++; break;
                    case 'U':
                    case 'u': ctu++; break;
                }
            }
            Console.WriteLine("\n ...       Gráfico de Vogais       ...");
            Console.Write("\n\tA({0})", cta); // Mostra a vogal e o nº
            for (int i=0; i< cta;i++) // Imprime nº de asteriscos correspondentes a cta
                Console.Write("*");
            Console.Write("\n\tE({0})", cte);
            for (int i = 0; i < cte; i++)
                Console.Write("*");
            Console.Write("\n\tI({0})", cti);
            for (int i = 0; i < cti; i++)
                Console.Write("*");
            Console.Write("\n\tO({0})", cto);
            for (int i = 0; i < cto; i++)
                Console.Write("*");
            Console.Write("\n\tU({0})", ctu);
            for (int i = 0; i < ctu; i++)
                Console.Write("*");
            */



            // Exercício - Conta vogais

            
          
            string str; // Vai conter o texto lido
            int cta, cte, cti, cto, ctu; // Contadores das vogais
            cta = cte = cti = cto = ctu = 0; // Inicializa todos os contadores

            Console.WriteLine("Insira um texto (contar as vogais):");
            str = Console.ReadLine();

            ContarVogais(str, ref cta, ref cte, ref cti, ref cto, ref ctu);
            DesenharGrafico(cta, cte, cti, cto, ctu);
            Console.ReadKey();
        }



        static void ContarVogais(string str, ref int cta, ref int cte, ref int cti, ref int cto, ref int ctu)
        {
            // A propriedade Length tem a dimensão efectivamente preenchida da string str
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])     // Verifica o caracter na posição i (índice)
                {
                    case 'A':
                    case 'a': cta++; break; // conta vogal a maiuscula ou minuscula
                    case 'E':
                    case 'e': cte++; break;
                    case 'I':
                    case 'i': cti++; break;
                    case 'O':
                    case 'o': cto++; break;
                    case 'U':
                    case 'u': ctu++; break;
                }

            }

        }

        static void DesenharGrafico(int cta, int cte, int cti, int cto, int ctu)
        {
            Console.WriteLine("\n ...       Gráfico de Vogais       ...");
            Console.Write("\n\tA({0})", cta); // Mostra a vogal e o nº
            for (int i = 0; i<cta;i++) // Imprime nº de asteriscos correspondentes a cta
                Console.Write("*");
            Console.Write("\n\tE({0})", cte);
            for (int i = 0; i<cte; i++)
                Console.Write("*");
            Console.Write("\n\tI({0})", cti);
            for (int i = 0; i<cti; i++)
                Console.Write("*");
            Console.Write("\n\tO({0})", cto);
            for (int i = 0; i<cto; i++)
                Console.Write("*");
            Console.Write("\n\tU({0})", ctu);
            for (int i = 0; i<ctu; i++)
                Console.Write("*");
        }
    }
}
