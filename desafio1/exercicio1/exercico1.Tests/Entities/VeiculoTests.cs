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
        public void LigarOVeiculoDesligado()
        {
            _veiculo.Ligar();
            Assert.AreEqual(_veiculo.IsLigado, EVeiculoIsLigado.Ligado);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void DesligarVeiculoLigadoComVelocidadeIgualZero()
        {
            _veiculo.Ligar();
            _veiculo.Desligar();
            Assert.AreEqual(_veiculo.IsLigado, EVeiculoIsLigado.Desligado);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void DesligarVeiculoLigadoComVelocidadeMaiorZero()
        {
            _veiculo.Ligar();
            _veiculo.Acelerar();
            _veiculo.Desligar();
            Assert.AreEqual(_veiculo.IsLigado, EVeiculoIsLigado.Ligado);
        }

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

        [TestMethod]
        [TestCategory("Domain")]
        public void FrearVeiculoLigadoComVelocidadeMaiorZero()
        {
            _veiculo.Ligar();
            _veiculo.Acelerar();
            _veiculo.Frear();

            Assert.AreEqual(_veiculo.Velocidade, 0);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void FrearVeiculoLigadoComVelocidadeIgualZero()
        {
            _veiculo.Ligar();
            _veiculo.Frear();
            Assert.AreEqual(_veiculo.Velocidade, 0);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void PintarVeiculoDeVermelho()
        {
            string cor = "Vermelho";
            _veiculo.Pintar(cor);
            Assert.AreEqual(_veiculo.Cor, cor);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void PintarVeiculoSemPassarCor()
        {
            _veiculo.Pintar(null);
            Assert.AreEqual(_veiculo.Cor, "Branco");
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void AbastecerVeiculoDesligadoCom10LitrosCombustivel()
        {
            _veiculo.Abastecer(20);
            Assert.AreEqual(_veiculo.LitrosCombustivel, 30);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void AbastecerVeiculoLigadoCom10LitrosCombustivel()
        {
            _veiculo.Ligar();
            _veiculo.Abastecer(20);
            Assert.AreEqual(_veiculo.LitrosCombustivel, 10);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void AbastecerVeiculoDesligadoCom60LitrosCombustivel()
        {
            Veiculo veiculo = new Veiculo("Chevrolet", "Onix", "ETZ-4310", "Branco", 15000, 60, 75000);

            veiculo.Abastecer(20);
            Assert.AreEqual(veiculo.LitrosCombustivel, 60);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void AbastecerVeiculoLigadoCom60LitrosCombustivel()
        {
            Veiculo veiculo = new Veiculo("Chevrolet", "Onix", "ETZ-4310", "Branco", 15000, 60, 75000);

            veiculo.Ligar();
            veiculo.Abastecer(20);
            Assert.AreEqual(veiculo.LitrosCombustivel, 60);
        }
    }
}