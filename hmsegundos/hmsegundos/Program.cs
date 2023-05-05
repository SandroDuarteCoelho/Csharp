using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmsegundos
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, segundos, minutos, horas;
            Console.WriteLine("\nInsira o número de segundos:  ");
            valor = int.Parse(Console.ReadLine());
            segundos = (valor % 60);
            minutos = (valor / 60)%60;
            horas = (valor / 60)/60;
            
            Console.WriteLine("\nhoras:  " + horas);
            Console.WriteLine("\nminutos:  "+minutos);
            Console.WriteLine("\nsegundos:  " + segundos);

            Console.ReadKey();

        }
    }
}
