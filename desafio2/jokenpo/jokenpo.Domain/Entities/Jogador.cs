using jokenpo.Domain.Enums;

namespace jokenpo.Domain.Entities
{
    public class Jogador
    {
        public Jogador(string nome, EJogada jogada)
        {
            Nome = nome;
            Jogada = jogada;
        }

        public string Nome { get; private set; }
        public EJogada Jogada { get; private set; }
    }
}