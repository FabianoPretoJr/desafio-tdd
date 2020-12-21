namespace exercicio7
{
    public class Gerente : Funcionario
    {
        public Gerente() : base()
        {

        }

        public Gerente(string nome, int idade, double salario) : base(nome, idade, salario)
        {

        }

        public override double Bonificar()
        {
            return this.Salario + 10000;
        }
    }
}