using jokenpo.Domain.Entities;
using jokenpo.Domain.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jokenpo.Tests.Entities
{
    [TestClass]
    public class JogoTests
    {
        [TestMethod]
        [TestCategory("Domain")]
        public void JogoAcabaEmEmpate()
        {
            Jogador jogadorP1 = new Jogador("Fabiano", EJogada.Pedra);
            Jogador jogadorP2 = new Jogador("Gustavo", EJogada.Pedra);
            Jogo jogo = new Jogo(jogadorP1, jogadorP2);

            jogo.AvaliarVencedor();
            Assert.AreEqual(jogo.Resultado, "Empate");
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void JogagorP1GanhaComPedra()
        {
            Jogador jogadorP1 = new Jogador("Fabiano", EJogada.Pedra);
            Jogador jogadorP2 = new Jogador("Gustavo", EJogada.Tesoura);
            Jogo jogo = new Jogo(jogadorP1, jogadorP2);

            jogo.AvaliarVencedor();
            Assert.AreEqual(jogo.Resultado, jogadorP1.Nome);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void JogagorP1GanhaComPapel()
        {
            Jogador jogadorP1 = new Jogador("Fabiano", EJogada.Papel);
            Jogador jogadorP2 = new Jogador("Gustavo", EJogada.Pedra);
            Jogo jogo = new Jogo(jogadorP1, jogadorP2);

            jogo.AvaliarVencedor();
            Assert.AreEqual(jogo.Resultado, jogadorP1.Nome);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void JogagorP1GanhaComTesoura()
        {
            Jogador jogadorP1 = new Jogador("Fabiano", EJogada.Tesoura);
            Jogador jogadorP2 = new Jogador("Gustavo", EJogada.Papel);
            Jogo jogo = new Jogo(jogadorP1, jogadorP2);

            jogo.AvaliarVencedor();
            Assert.AreEqual(jogo.Resultado, jogadorP1.Nome);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void JogagorP2GanhaComPedra()
        {
            Jogador jogadorP1 = new Jogador("Fabiano", EJogada.Tesoura);
            Jogador jogadorP2 = new Jogador("Gustavo", EJogada.Pedra);
            Jogo jogo = new Jogo(jogadorP1, jogadorP2);

            jogo.AvaliarVencedor();
            Assert.AreEqual(jogo.Resultado, jogadorP2.Nome);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void JogagorP2GanhaComPapel()
        {
            Jogador jogadorP1 = new Jogador("Fabiano", EJogada.Pedra);
            Jogador jogadorP2 = new Jogador("Gustavo", EJogada.Papel);
            Jogo jogo = new Jogo(jogadorP1, jogadorP2);

            jogo.AvaliarVencedor();
            Assert.AreEqual(jogo.Resultado, jogadorP2.Nome);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void JogagorP2GanhaComTesoura()
        {
            Jogador jogadorP1 = new Jogador("Fabiano", EJogada.Papel);
            Jogador jogadorP2 = new Jogador("Gustavo", EJogada.Tesoura);
            Jogo jogo = new Jogo(jogadorP1, jogadorP2);

            jogo.AvaliarVencedor();
            Assert.AreEqual(jogo.Resultado, jogadorP2.Nome);
        }
    }
}