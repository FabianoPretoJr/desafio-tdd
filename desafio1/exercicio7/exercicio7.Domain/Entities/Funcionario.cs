using Flunt.Notifications;
using Flunt.Validations;

namespace exercicio7.Domain.Entities
{
    public class Funcionario : Notifiable
    {
        public Funcionario(string nome, int idade, double salario)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNull(nome, "Nome", "Nome inválido")
                .IsGreaterThan(0, idade, "Idade", "Idade inválida")
                .IsGreaterThan(0, salario, "Salario", "Salario inválido")
            );

            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public double Salario { get; private set; }

        public virtual double Bonificar()
        {
            return this.Salario;
        }
    }
}