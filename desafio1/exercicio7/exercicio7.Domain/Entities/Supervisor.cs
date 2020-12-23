namespace exercicio7.Domain.Entities
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario){}

        public override double Bonificar()
        {
            return this.Salario + 5000;
        }
    }
}