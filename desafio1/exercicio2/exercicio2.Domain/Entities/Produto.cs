using Flunt.Notifications;
using Flunt.Validations;

namespace exercicio2.Domain.Entities
{
    public abstract class Produto : Notifiable
    {
        public Produto(string nome, double preco, int quantidade)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNull(nome, "Nome", "Nome inválido")
                .IsGreaterThan(0, preco, "Preco", "Preco inválido")
                .IsGreaterThan(0, quantidade, "Quantidade", "Quantidade inválida")
            );

            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int Quantidade { get; set; }
    }
}