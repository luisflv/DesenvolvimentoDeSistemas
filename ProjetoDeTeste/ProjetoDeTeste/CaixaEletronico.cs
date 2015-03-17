using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeTeste
{
    public class CaixaEletronico
    {
        public double Saldo
        {
            get
            {
               return sal;
            }
            set
            {
                sal = value; 
            }
        }

        private double sal = 0;

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("VALOR INVÁLIDO", "valor");
            }
            else
            {
                Saldo += valor;
            }          
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("VALOR INVÁLIDO", "valor");
            }
            else
            {
                Saldo = Saldo - valor;
            }
        }


    }
}
