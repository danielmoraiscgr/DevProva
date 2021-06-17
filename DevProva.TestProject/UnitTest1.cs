using DevProva.Models;
using Moq;
using System;
using Xunit;

namespace DevProva.TestProject
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(1, 8, -9, 1)]    // Retorna o valor maior das reizes 
        [InlineData(2, -10, 8, 4)]   // Retorna o valor maior das raizes
        [InlineData(1, -10, 25, 0)]  // Delta = 0 
        [InlineData(2, 2, 1, -1)]    // Delta < 0 Equacao nao possui valores reais
        public void CalculoBhaskaraTeste(int a, int b, int c, double resultadoTeste)
        {
            // Arrange
            CalculoBhaskara calculo = new CalculoBhaskara();

            // Act

            double resultado = calculo.ResultadoCalculoBhaskara(a, b, c);

            // Assert 
            Assert.Equal(resultado, resultadoTeste);
        }

        [Theory]
        [InlineData(45, "Não primo")]
        [InlineData(38, "Não primo")]
        [InlineData(5, "Primo")]
        [InlineData(47, "Primo")]
        public void VerificarNumeroPrimoIdadeTeste(int idade, string resultadoTeste)
        {
            // Arrange

            Pessoa pessoa = new Pessoa();
            pessoa.Idade = idade;

            Mock<IPessoa> mock = new Mock<IPessoa>();
            mock.Setup(m => m.VerificarNumeroPrimo(pessoa)).Returns(resultadoTeste);

            // Act
            var resultadoTesteMock = mock.Object.VerificarNumeroPrimo(pessoa);

            Pessoa verifica = new Pessoa();
            verifica.Idade = idade;

            var resultado = verifica.VerificarNumeroPrimo(verifica);


            // Assert 
            Assert.Equal(resultado, resultadoTesteMock);


        }


    }
}


