using exercicio7.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace exercicio7.Tests.Entities
{
    [TestClass]
    public class SupervisorTests
    {
        [TestMethod]
        [TestCategory("Domain")]
        public void BonificarSupervisorComSalarioDe10000DeveRetornar15000()
        {
            Supervisor supervisor = new Supervisor("Ana Paula", 31, 10000);
            Assert.AreEqual(15000, supervisor.Bonificar());
        }
    }
}