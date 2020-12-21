using exercicio1.Domain.Entities;
using exercicio1.Domain.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace exercico1.Tests.Entities
{
    [TestClass]
    public class VeiculoTests
    {
        private readonly Veiculo _veiculo = new Veiculo("Chevrolet", "Onix", "ETZ-4310", "Branco", 15000, 10, 75000);

        [TestMethod]
        [TestCategory("Domain")]
        public void AcelerarComVeiculoLigado()
        {
            int velocidade = _veiculo.Velocidade;
            _veiculo.Ligar();
            _veiculo.Acelerar();
            Assert.AreEqual(_veiculo.Velocidade, (velocidade + 20));
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void AcelerarComVeiculoDesligado()
        {
            int velocidade = _veiculo.Velocidade;
            _veiculo.Acelerar();
            Assert.AreEqual(_veiculo.Velocidade, velocidade);
        }
    }
}