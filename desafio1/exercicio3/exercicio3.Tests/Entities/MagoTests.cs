using exercicio3.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace exercicio3.Tests.Entities
{
    [TestClass]
    public class MagoTests
    {
        private readonly Mago _mago = new Mago("Gandalf", 40, 150, 31, 154, 10, 146);

        [TestMethod]
        [TestCategory("Domain")]
        public void SubirLevelDeMagoSeusAtributosDevemAumentar()
        {
            Assert.IsTrue(_mago.LvlUp());
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void EfetuarAtaque()
        {
            Assert.IsNotNull(_mago.Attack());
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void AprenderMagiaPassandoSeuNome()
        {
            _mago.AprenderMagia("Ocus Pocus");
            _mago.AprenderMagia("Xablau");
            _mago.AprenderMagia("Sim Salabim");

            Assert.AreEqual(_mago.Magia.Count, 3);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void NaoAprenderMagiaPassandoNull()
        {
            _mago.AprenderMagia("");
            _mago.AprenderMagia(null);

            Assert.AreEqual(_mago.Magia.Count, 0);
        }
    }
}