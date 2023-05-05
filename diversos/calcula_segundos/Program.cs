using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcula_segundos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia as horas, minutos e segundos, e calcule o número de segundos que passaram desde o início do dia.*/

            int horas, minutos, segundos;

            Console.WriteLine("Horas:");
            horas = int.Parse(Console.ReadLine()); // para ler variaveis int, acrescentar int.Parse

            Console.WriteLine("Minutos:");
            minutos = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundos:");
            segundos = int.Parse(Console.ReadLine());

            //1hora=60min , 1 min=60seg

            minutos = minutos + (horas * 60);
            segundos=segundos+(minutos * 60);

            Console.WriteLine($"Passaram  {horas * 60}  minutos");
            Console.WriteLine($"Passaram  {minutos * 60}  segundos");
            Console.WriteLine($"Passaram  {segundos}  segundos");

            Console.ReadKey();


        }
    }
}
