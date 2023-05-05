using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar o ficheiro
            StreamWriter sw = File.CreateText("file.txt");
            sw.WriteLine( "O zé foi á fonte.");
            sw.Close();

            // Acrescentar linhas ao ficheiro
            StreamWriter w = File.AppendText("file.txt");
            w.WriteLine("Não havia água.");
            w.Close();

            StreamWriter q = File.AppendText("file.txt");
            q.WriteLine("Foi ao Minipreço.");
            q.Close();

            // Ler o ficheiro
            StreamReader rd = new StreamReader("file.txt");
            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                Console.WriteLine(linha);
            }
            rd.Close();


            Console.ReadKey();
            
            /*
            Caso queiramos alterar a localização do ficheiro, temos primeiro que obter a localização (path) actual do ficheiro e o seu destino:
            string path1=System.IO.Directory.GetCurrentDirectory(); 
            path1 = "@"+path1 + "file.ini"; 
            File.Move(path1, @"c:\file2.ini"); 
            Neste caso o ficheiro de destino tem o nome de file2.ini e está na raiz do disco c, de notar que é necessário introduzir sempre o @ no inicio da localização.
            */
        }
    }
}
