using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1_Class
{
    class Pessoa
    {
        // Encapsulamento
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public void LerDados(Pessoa pes)
        {
            Console.Write("\nInsira o nome:   ");
            pes.Nome = Console.ReadLine();
            Console.Write("\nInsira a idade:   ");
            pes.Idade = int.Parse(Console.ReadLine());
        }


    }
}
