using jokenpo.Domain.Enums;

namespace jokenpo.Domain.Entities
{
    public class Jogo
    {
        public Jogo(Jogador jogadorP1, Jogador jogadorP2)
        {
            JogadorP1 = jogadorP1;
            JogadorP2 = jogadorP2;
            Resultado = null;
        }

        public Jogador JogadorP1 { get; private set; }
        public Jogador JogadorP2 { get; private set; }
        public string Resultado { get; private set; }

        public void AvaliarVencedor()
        {
            if(JogadorP1.Jogada.Equals(JogadorP2.Jogada))
            {
                Resultado = "Empate";
            }
            else if(JogadorP1.Jogada.Equals(EJogada.Pedra) && JogadorP2.Jogada.Equals(EJogada.Tesoura))
            {
                Resultado = JogadorP1.Nome;
            }
            else if(JogadorP1.Jogada.Equals(EJogada.Tesoura) && JogadorP2.Jogada.Equals(EJogada.Papel))
            {
                Resultado = JogadorP1.Nome;
            }
            else if(JogadorP1.Jogada.Equals(EJogada.Papel) && JogadorP2.Jogada.Equals(EJogada.Pedra))
            {
                Resultado = JogadorP1.Nome;
            }
            else
            {
                Resultado = JogadorP2.Nome;
            }
        }
    }
}