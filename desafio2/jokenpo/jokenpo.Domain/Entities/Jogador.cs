using Flunt.Notifications;
using Flunt.Validations;
using jokenpo.Domain.Enums;

namespace jokenpo.Domain.Entities
{
    public class Jogador : Notifiable
    {
        public Jogador(string nome, EJogada jogada)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(nome, "Nome", "Nome inválido")
                .IsNotNull(jogada, "Jogada", "Jogada inválida")
            );

            Nome = nome;
            Jogada = jogada;
        }

        public string Nome { get; private set; }
        public EJogada Jogada { get; private set; }
    }
}