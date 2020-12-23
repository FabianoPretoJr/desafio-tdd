using System.Collections.Generic;
using exercicio2.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace exercicio2.Tests.Entities
{
    [TestClass]
    public class LojaTests
    {
        public LojaTests()
        {
            _livros.Add(new Livro("J. K. Rowling", "fantasia", 300, "Harry Potter", 40, 50));
            _livros.Add(new Livro("J. R. R. Tolkien", "fantasia", 500, "Senhor dos Anéis", 60, 30));
            _livros.Add(new Livro("GFT", "educativo", 500, "Java POO", 20, 50));

            _videogames.Add(new Videogame("Sony", "Slin", false, "PS4", 1800, 100));
            _videogames.Add(new Videogame("Sony", "Slin", true, "PS4", 1000, 7));
            _videogames.Add(new Videogame("Microsoft", "One", false, "XBOX", 1500, 500));
        }

        private readonly List<Livro> _livros = new List<Livro>();
        private readonly List<Videogame> _videogames = new List<Videogame>();

        [TestMethod]
        [TestCategory("Domain")]
        public void ListarLivrosPassadosEmInstanciaDeLoja()
        {
            Loja loja = new Loja("Amazon", "123.452.12/1245.54", _livros, _videogames);
            Assert.IsNotNull(loja.ListarLivros());
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void ListarLivrosComoNull()
        {
            Loja loja = new Loja("Amazon", "123.452.12/1245.54", null, _videogames);
            Assert.IsNull(loja.ListarLivros());
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void ListarVideogamesPassadosEmInstanciaDeLoja()
        {
            Loja loja = new Loja("Amazon", "123.452.12/1245.54", _livros, _videogames);
            Assert.IsNotNull(loja.ListarVideogames());
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void ListarVideogamesComoNull()
        {
            Loja loja = new Loja("Amazon", "123.452.12/1245.54", _livros, null);
            Assert.IsNull(loja.ListarVideogames());
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void CalcularPatrimonioDeveRetornar4420()
        {
            Loja loja = new Loja("Amazon", "123.452.12/1245.54", _livros, _videogames);
            Assert.AreEqual(loja.CalcularPatrimonio(), 4420);
        }
    }
}