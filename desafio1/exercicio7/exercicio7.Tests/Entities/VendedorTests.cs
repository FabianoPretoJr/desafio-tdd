using exercicio7.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace exercicio7.Tests.Entities
{
    [TestClass]
    public class VendedorTests
    {
        [TestMethod]
        [TestCategory("Domain")]
        public void BonificarVendedorComSalarioDe4000DeveRetornar7000()
        {
            Vendedor vendedor = new Vendedor("Pedro Carlos", 24, 4000);
            Assert.AreEqual(7000, vendedor.Bonificar());
        }
    }
}