namespace exercicio7.Domain.Entities
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario){}

        public override double Bonificar()
        {
            return this.Salario + 3000;
        } 
    }
}