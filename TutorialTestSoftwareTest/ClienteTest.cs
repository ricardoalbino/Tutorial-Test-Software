using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TutorialTestSoftware;

namespace TutorialTestSoftwareTest
{

    /* TESTE UNITARIO*/
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void CreateTest_Retornar_Teste_Valido()
        {
            //Arrange
            ClienteModel clienteModel = new ClienteModel();
            clienteModel.NOME = "Fabio";
            clienteModel.ENDERECO = "Rua Caracol";
            clienteModel.CEP = "13318-000";
            clienteModel.BAIRRO = "Jacare";
            clienteModel.CIDADE = "Cabreuva";
            clienteModel.UF = "SP";
            clienteModel.TELEFONE = "973301843";

            //Act
            var resultado = clienteModel.Create(clienteModel);

            //Assert     -> 1 valido
            Assert.AreEqual(1, resultado);
        }


        [TestMethod]
        public void CreateTest_Retornar_Teste_Inalido()
        {
            //Arrange
            ClienteModel clienteModel = new ClienteModel();
            // clienteModel.NOME = "Fabio"; -> Campo obrigatorio no banco de dados
            clienteModel.ENDERECO = "Rua Caracol";
            clienteModel.CEP = "13318-000";
            clienteModel.BAIRRO = "Jacare";
            clienteModel.CIDADE = "Cabreuva";
            clienteModel.UF = "SP";
            clienteModel.TELEFONE = "973301843";

            //Act
            var resultado = clienteModel.Create(clienteModel);

            //Assert      -0 invalido
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void UpdateTest_Retornar_Teste_valido()
        {
            //Arrange
            ClienteModel clienteModel = new ClienteModel();
           
            clienteModel.NOME = "Fabio arone"; 
            clienteModel.ENDERECO = "Rua Caracol";
            clienteModel.CEP = "13318-000";
            clienteModel.BAIRRO = "Jacare";
            clienteModel.CIDADE = "Cabreuva";
            clienteModel.UF = "SP";
            clienteModel.TELEFONE = "973301843";
            clienteModel.ID = 4;

            //Act
            var resultado = clienteModel.Update(clienteModel);

            //Assert      -0 invalido
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void UpdateTest_Retornar_Teste_Invalido()
        {
            //Arrange
            ClienteModel clienteModel = new ClienteModel();

            clienteModel.NOME = "Fabio arone";
            clienteModel.ENDERECO = "Rua Caracol";
            clienteModel.CEP = "13318-000";
            clienteModel.BAIRRO = "Jacare";
            clienteModel.CIDADE = "Cabreuva";
            clienteModel.UF = "SP";
            clienteModel.TELEFONE = "973301843";
            clienteModel.ID = 0; // Chave Primaria Invalida

            //Act
            var resultado = clienteModel.Update(clienteModel);

            //Assert      -0 invalido
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void DeletarTest_Retornar_Teste_valido()
        {
            //Arrange
            ClienteModel clienteModel = new ClienteModel();


            clienteModel.ID = 4;

            //Act
            var resultado = clienteModel.Delete(clienteModel);

            //Assert      -0 invalido
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void DeletarTest_Retornar_Teste_Invalido()
        {
            //Arrange
            ClienteModel clienteModel = new ClienteModel();


            clienteModel.ID = 0; // Chave Primaria Invalida!

            //Act
            var resultado = clienteModel.Delete(clienteModel);

            //Assert      -0 invalido
            Assert.AreEqual(1, resultado);
        }

    }
}
