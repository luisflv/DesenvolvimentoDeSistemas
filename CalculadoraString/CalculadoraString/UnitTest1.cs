using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraString
{
    [TestClass]
    public class UnitTest1
    {
       [TestMethod]
        public void Testando_Soma_Simples()
        {
            string mensagem ="52+2";

            Calculadora calc = new Calculadora();

            string resultado = calc.Calcular(mensagem);

            Assert.AreEqual("54", resultado);
            

        }

      [TestMethod]
       public void Testando_Subtracao_Simples()
       {
           string mensagem = "3-10";

           Calculadora calc = new Calculadora();

           string resultado = calc.Calcular(mensagem);

           Assert.AreEqual("-7", resultado);


       }

        [TestMethod]
       public void Testando_Multiplicacao_Simples()
       {
           string mensagem = "3*2";

           Calculadora calc = new Calculadora();

           string resultado = calc.Calcular(mensagem);

           Assert.AreEqual("6", resultado);


       }

      [TestMethod]
        public void Testando_Expressao_Valida()
        {
            string mensagem = "2 ";

            Calculadora calc = new Calculadora();

            string resultado = calc.Calcular(mensagem);

            Assert.AreEqual("Expressao invalida", resultado);


        }

        [TestMethod]
        public void Testando_Dividisao_Simples()
        {
            string mensagem = "10/5";

            Calculadora calc = new Calculadora();

            string resultado = calc.Calcular(mensagem);

            Assert.AreEqual("2", resultado);


        }
    
    
    }
}
