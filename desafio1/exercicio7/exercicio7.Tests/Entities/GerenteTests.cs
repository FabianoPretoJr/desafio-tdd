using exercicio7.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace exercicio7.Tests.Entities
{
    [TestClass]
    public class GerenteTests
    {
        [TestMethod]
        [TestCategory("Domain")]
        public void BonificarGerenteComSalarioDe20000DeveRetornar30000()
        {
            Gerente gerente = new Gerente("Jóse Carlos", 34, 20000);
            Assert.AreEqual(30000, gerente.Bonificar());
        }
    }
}