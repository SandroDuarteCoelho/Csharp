using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_e_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            string st1="Programar é fixe";
            Console.Write("\nEscreva um texto livre  ");
            string stb = Console.ReadLine ();
            string st2 = "Programar";
            st2 += " é";
            st2 += " fixe";
            StringBuilder st3= new StringBuilder();
            st3.Append("Programar é");
            st3.Append(" fixe");
            Console.WriteLine("\n {0}", st1);
            Console.WriteLine("\n {0}", st2);
            Console.WriteLine("\n {0}", st3);
            Console.WriteLine("\n {0}", stb);
            Console.WriteLine("\nDimensão de st1= {0}", st1.Length);
            Console.WriteLine("\n {0}", st1.Insert(12, "muito ") );

            Console.ReadKey();

        }
    }
}

