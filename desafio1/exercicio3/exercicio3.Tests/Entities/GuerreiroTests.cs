using exercicio3.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace exercicio3.Tests.Entities
{
    [TestClass]
    public class GuerreiroTests
    {
        private readonly Guerreiro _guerreiro = new Guerreiro("Rei Arthur", 120, 10, 52, 120, 134, 167);

        [TestMethod]
        [TestCategory("Domain")]
        public void SubirLevelDeGuerreiroSeusAtributosDevemAumentar()
        {
            Assert.IsTrue(_guerreiro.LvlUp());
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void EfetuarAtaque()
        {
            Assert.IsNotNull(_guerreiro.Attack());
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void AprenderHabilidadePassandoSeuNome()
        {
            _guerreiro.AprenderHabilidade("Corte da Espada Excalibur");
            _guerreiro.AprenderHabilidade("Voo em Dragão");
            _guerreiro.AprenderHabilidade("Super Soco");

            Assert.AreEqual(_guerreiro.Habilidades.Count, 3);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void NaoAprenderHabilidadePassandoNull()
        {
            _guerreiro.AprenderHabilidade("");
            _guerreiro.AprenderHabilidade(null);

            Assert.AreEqual(_guerreiro.Habilidades.Count, 0);
        }
    }
}