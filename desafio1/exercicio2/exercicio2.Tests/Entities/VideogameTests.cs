using exercicio2.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace exercicio2.Tests.Entities
{
    [TestClass]
    public class VideogameTests
    {
        [TestMethod]
        [TestCategory("Domain")]
        public void CalcularImpostoDeVideogameUsadoRetornar500()
        {
            Videogame videogame = new Videogame("Sony", "Playstation", true, "4", 2000, 3);
            Assert.AreEqual(videogame.calcularImposto(), 500);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void CalcularImpostoDeVideogameNaoUsadoRetornar2025()
        {
            Videogame videogame = new Videogame("Sony", "Playstation", false, "5", 4500, 200);
            Assert.AreEqual(videogame.calcularImposto(), 2025);
        }
    }
}