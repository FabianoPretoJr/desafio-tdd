using System;

namespace exercicio7
{
    public class Supervisor : Funcionario
    {
        public Supervisor() : base()
        {

        }

        public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
            
        }

        public override double Bonificar()
        {
            return this.Salario + 5000;
        }
    }
}