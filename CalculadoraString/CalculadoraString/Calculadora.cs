using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraString
{
    public class Calculadora
    {

        public string Calcular(string expressao)
        {
            string resultado= null;
            string validacao = null;

         
         
            if (expressao.Contains("+"))
            {
                resultado = Somar(expressao);
               
            }
            else if (expressao.Contains("-"))
            {
                resultado = Subtrair(expressao);
            }
            else if (expressao.Contains("*"))
            {
                resultado = Multiplicar(expressao);
            }
            else if (expressao.Contains("/"))
            {
                resultado = Dividir(expressao);
            }
            return resultado;

        }


        private string ValidarExpressao(string expressao)
        {

            string resultado = null; 

            if (expressao.Contains(' '))
            {

                resultado = "Expressao invalida";


            }
            return resultado;
        }

        private string Somar(string expressao)
        {

            int resultado = 0;


            if (expressao.Contains("+"))
            {
                string[] caracteres = expressao.Split('+');

                int tamanho = caracteres.Length;

                for (int i = 0; i < tamanho; i++)
                {
                    resultado += Convert.ToInt32(caracteres[i]);
                }
            }

            return resultado.ToString();



        }

        private string Subtrair(string expressao)
        {

            int resultado = 0;
            
            int valor1 = 0, valor2= 0; 

            if (expressao.Contains("-"))
            {
                string[] caracteres = expressao.Split('-');

                int tamanho = caracteres.Length;
/*
                for (int i = 0; i < tamanho; i++)
                {
                    valor =  Convert.ToInt32(caracteres[i]);

                    resultado =  resultado - valor;

                }*/

                valor1 = Convert.ToInt32(caracteres[0]);
                valor2 = Convert.ToInt32(caracteres[1]);

                resultado = valor1 - valor2;

            }

            return resultado.ToString();



        }

        private string Multiplicar(string expressao)
        {

            int resultado = 1;
            int valor;

            if (expressao.Contains("*"))
            {
                string[] caracteres = expressao.Split('*');

                int tamanho = caracteres.Length;

                for (int i = 0; i < tamanho; i++)
                {
                    valor =  Convert.ToInt32(caracteres[i]);

                    resultado = valor * resultado;
                }
            }

            return resultado.ToString();



        }

        private string Dividir(string expressao)
        {

            int resultado = 0;
            int valor;

            if (expressao.Contains("/"))
            {
                string[] caracteres = expressao.Split('/');

                int tamanho = caracteres.Length;
                /*
                for (int i = 0; i < tamanho; i++)
                {
                    valor = Convert.ToInt32(caracteres[i]);

                    resultado =  resultado / valor;
                }*/

                int val1 = Convert.ToInt32(caracteres[0]);
                int val2 = Convert.ToInt32(caracteres[1]);

                resultado = val1 / val2;

            }

            return resultado.ToString();



        }

    }
}
