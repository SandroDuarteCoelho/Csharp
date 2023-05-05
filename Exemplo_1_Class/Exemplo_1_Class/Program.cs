using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1_Class
{
    class Program
    {
        class Carro
        {
            // Atributos da classe
            public string marca;
            public string cor;
            // Este atributo está agora protegido de acesso de fora da classe
            // Não tendo modificador é considerado private
            int cilindrada;
            public bool ligado; // Indica se o carro está ligado
            public int autonomia; // Em Km 

            // Encapsulamento da variável usando os acessores get e set
            public int Cilindrada
            {
                // Retorna o valor do objeto atual
                get { return cilindrada; }
                set { cilindrada = value; }
            }

            // Construtora de Classe tem sempre o nome da classe
            // Construtora de classe sem parametros
            public Carro()
            { }

            // Construtora de classe com parametros permite inicializar o objeto instanciado

                //this refere-se ao objeto corrente
            public Carro(string marca, string cor, int cilindrada)
            {
                this.marca = marca;
                this.cor = cor;
                this.cilindrada = cilindrada;
            }

            // Comportamento - acções desencadeadas pelos métodos

            public void Ligar()
            {
                this.ligado = true;
                Console.WriteLine("\nCarro Ligado!!!");
            }

            public void Desligar()
            {
                this.ligado = false;
                Console.WriteLine("\nCarro Desligado!!!");
            }

            public bool Andar()
            {
                if (this.ligado && this.autonomia > 0)
                    return true;
                else
                    return false;
            }


        }
        static void Main(string[] args)
        {
            /* Este objeto não foi instanciado é só uma referência. Não existe em memória.
            Carro carr;
            carr.cor = "Azul";
            carr.marca = "audi";
            */
            Carro car = new Carro();
            car.cor = "amarelo";
            car.marca = "Kia";
            car.Cilindrada = 1400;
            car.ligado = false;
            car.autonomia = 50;

            Console.WriteLine("\nEste carro é um {0} {1}",car.marca, car.cor);

            //instancia um carro usando a construtora com parametros
            Carro car1 = new Carro("Audi", "Azul", 1900);
            Console.WriteLine("\nEste carro é um {0} {1} e tem {2} de cilindrada", car1.marca, car1.cor, car1.Cilindrada/*car1.cilindrada*/);

            // Ligar o carro
            car.Ligar();
            if (car.Andar())
                Console.WriteLine("\nVou andar de carro");
            else
                Console.WriteLine("\nAndar a pé faz bem");
            car.Desligar();

            Pessoa p = new Pessoa("Ana", 25);
            Console.WriteLine("\nA {0} tem {1} anos", p.Nome, p.Idade);

            Pessoa p1 = new Pessoa();
            p1.LerDados(p1);
            Console.WriteLine("\n{0} tem {1} anos e tem um {2} {3}", p1.Nome, p1.Idade, car1.marca, car1.cor);

            Console.ReadKey();
        }
    }
}
