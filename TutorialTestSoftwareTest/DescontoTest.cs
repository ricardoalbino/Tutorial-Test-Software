using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TutorialTestSoftware;

namespace TutorialTestSoftwareTest
{
    [TestClass]
    public class DescontosTest
    {
        // Casao de Teste#1: ´Valor das Vendas é Maior ou Igual a 1000 : Verificação
        [TestMethod]
        public void MaiorOuIgual_Valido_1000()
        {
            Descontos desconto = new Descontos();
            Assert.AreEqual(950, desconto.calcularDesconto(1000));
        }

        // Casao de Teste#2: ´Valor das Vendas é Menor 1000 : Verificação
        [TestMethod]
        public void MaiorOuIgual_Invalido_1000()
        {
            Descontos desconto = new Descontos();
            Assert.AreEqual(950, desconto.calcularDesconto(100));
        }


    }

}

