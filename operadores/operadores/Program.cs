using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alguns operadores no C#
            // Decremento / Incremento posfixo e prefixo
            // x++ retorna o valor de x e depois incrementa x de uma unidade
            // x-- retorna o valor de x e depois decrementa x de uma unidade
            // ++x primeiro incrementa x de uma unidade e depois retorna x
            // --x primeiro decrementa x de uma unidade e depois retorna x
            int x = 2, y = 5;
            Console.WriteLine("\nPosfixo\n " + x + "++ = " + (x++));
            Console.WriteLine("\nPosfixo\n " + y + "-- = " + (y--));
            int a = 0, b = 7;
            Console.WriteLine("\nPrefixo\n ++" + a + " = " + (++a));
            Console.WriteLine("\nPrefixo\n --" + b + " = " + (--b));

            // x/y  Quociente da divisão
            // x%Y  Resto da divisão inteira (Módulo) Só funciona com variáveis inteiras
            int n1 = 5, n2 = 3;
            Console.WriteLine("\nQuociente inteiro: " + n1 + "/" + n2 + " = " + (n1 / n2));
            Console.WriteLine("\nResto da divisão: " + n1 + "%" + n2 + " = " + (n1 % n2));
            float n3 = 3;
            Console.WriteLine("\nQuociente inteiro: " + n1 + "/" + n3 + " = " + (n1 / n3));

            // Lógicos .............
            // !x   Negação lógica
            // ~x   Negação bit a bit (bitwise complement)
            Console.WriteLine("\nNegação lógica: \t !true =" + (!true));
            Console.WriteLine("\nNegação bit a bit: \t ~"+n2+" = " + (~n2));

            // Lógicos Condicionais
            // x && y   AND lógico
            // x || y   OR lógico
            Console.WriteLine("\nAND lógico: \t " + n1+">10 && "+n2+"<7 ="+((n1>10)&&(n2<7)));
            Console.WriteLine("\nOR lógico: \t " + n1 + ">10 || " + n2 + "<7 =" + ((n1 > 10) || (n2 < 7)));

            // Bit a bit (bitwise)
            // x & y    AND bit a bit
            // x | y    OR bit a bit
            // x ^ y    XOR bit a bit
            Console.WriteLine("\nAND bit a bit: \t " + n1 + " & " + n2 + " = " + (n1 & n2));
            Console.WriteLine("\nOR bit a bit: \t " + n1 + " | " + n2 + " = " + (n1 | n2));
            Console.WriteLine("\nXOR bit a bit: \t " + n1 + " ^ " + n2 + " = " + (n1 ^ n2));

            // Igualdade
            // x == y   Iguak
            // x != y   Diferente
            Console.WriteLine("\nIgual: \t " + n1 + " == " + n2 + " = " + (n1 == n2));
            Console.WriteLine("\nDiferente: \t " + n1 + " != " + n2 + " = " + (n1 != n2));

            // Operador Condicional
            // a ? b : c    Se a condição a for verdadeira executa b senão executa c
            string paridade;
            Console.WriteLine("\nInsira um valor inteiro:  ");
            int valor;
            valor = int.Parse(Console.ReadLine());
            paridade = (valor % 2 == 0) ? "Par" : "Impar";
            Console.WriteLine("\nO valor que inseriu é "+paridade);


            Console.ReadKey();

        }
    }
}
