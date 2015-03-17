using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjetoDeTeste
{
    [TestClass]
    public class CaixaEletronicoTeste
    {
        private CaixaEletronico _caixaEletronico;

        [TestInitialize]
        public void InicializarTeste()
        {
            _caixaEletronico = new CaixaEletronico();
        }


        [TestMethod]
        public void Saldo_Do_Caixa_Eletronico_Deve_Iniciar_Com_Zero()
        {

            Assert.AreEqual(0,_caixaEletronico.Saldo);
        }
        
       [TestMethod]
        public void Quando_Depositar_20_Retornar_Saldo_20()
        {
            _caixaEletronico.Depositar(20);
            Assert.AreEqual(20, _caixaEletronico.Saldo);

        }


        [TestMethod]
        public void Quando_Depositar_10_E_Depois_Depositar_30_Retornar_40()
        {

            _caixaEletronico.Depositar(10);
            _caixaEletronico.Depositar(30);

            Assert.AreEqual(40, _caixaEletronico.Saldo);

        }

        [TestMethod]
        public void Quando_Sacar_10_E_No_Caixa_Tiver_25_Retornar_15()
        {
            _caixaEletronico.Depositar(25);
            _caixaEletronico.Sacar(10);

            Assert.AreEqual(15,_caixaEletronico.Saldo);
        }
      
        [TestMethod]
        public void Quando_Sacar_50_E_No_Caixa_Tiver_70_Retornar_20()
        {

            _caixaEletronico.Depositar(70);
            _caixaEletronico.Sacar(50);

            Assert.AreEqual(20,_caixaEletronico.Saldo, "teste");


        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Quando_Depositar_Valores_Negativos_Lancar_Excessao()
        {
            _caixaEletronico.Depositar(-30);

            
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Quando_Depositar_1_E_Sacar_3_Lancar_Excessao()
        
        {
            _caixaEletronico.Depositar(1);
            _caixaEletronico.Sacar(3);


        }

    }
}
