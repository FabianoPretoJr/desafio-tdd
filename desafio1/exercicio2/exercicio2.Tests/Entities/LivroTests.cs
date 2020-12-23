using exercicio2.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace exercicio2.Tests.Entities
{
    [TestClass]
    public class LivroTests
    {
        [TestMethod]
        [TestCategory("Domain")]
        public void CalcularImpostoDeLivroNaoEducativo()
        {
            Livro livro = new Livro("J. R. R. Tolkien", "fantasia", 500, "Senhor dos Anéis", 60, 30);
            Assert.AreNotEqual(livro.calcularImposto(), 0);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void CalcularImpostoDeLivroEducativo()
        {
            Livro livro = new Livro("GFT", "educativo", 300, "Java POO", 20, 50);
            Assert.AreEqual(livro.calcularImposto(), 0);
        }
    }
}