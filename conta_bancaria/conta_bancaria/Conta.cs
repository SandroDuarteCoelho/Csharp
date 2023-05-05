using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta_bancaria
{
    class Conta
    {
        // Atributos da conta (private)
        int saldo;
        int nib;
        int valor;

        // Encapsulamento das variaveis privadas
        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public int Nib
        {
            get { return nib; }
            set { nib = value; }
        }
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        // Construtora de classe com parametros permite inicializar o objeto instanciado
        public Conta(int nib, int saldo)
        {
            this.Saldo = saldo;
            this.Nib = nib;
            //this.Valor = valor;
        }

        // Comportamento - acções desencadeadas pelos métodos
        public void consultar();
        {
        this.nib=
        }

        public void levantar();
        {

        }

        public void depositar();
        {

        }

        public void transferir();
        {

        }

       
    }
}
