using bonus.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bonus.Tests.Entities
{
    [TestClass]
    public class LetrasTests
    {
        [TestMethod]
        [TestCategory("Domain")]
        public void LetrasDentroDaOrdemAlfabetica()
        {
            Letras letras = new Letras('B', 'H');
            Assert.IsTrue(letras.VerificarOrdem());
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void LetrasForaDaOrdemAlfabetica()
        {
            Letras letras = new Letras('K', 'E');
            Assert.IsFalse(letras.VerificarOrdem());
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void PassarLetrasERetornar24()
        {
            Letras letras = new Letras('A', 'Z');
            Assert.AreEqual(letras.ContarIntervaloLetras(), "24");
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void PassarLetrasERetornarNaoEstaNaOrdemAlfabetica()
        {
            Letras letras = new Letras('W', 'E');
            Assert.AreEqual(letras.ContarIntervaloLetras(), "Não está na ordem alfabética");
        }
    }
}