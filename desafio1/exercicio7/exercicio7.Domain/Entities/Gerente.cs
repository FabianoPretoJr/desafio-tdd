namespace exercicio7.Domain.Entities
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario) : base(nome, idade, salario){}

        public override double Bonificar()
        {
            return this.Salario + 10000;
        }
    }
}