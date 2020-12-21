using System;

namespace exercicio7
{
    public class Vendedor : Funcionario
    {
        public Vendedor() : base()
        {

        }

        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario)
        {

        } 

        public override double Bonificar()
        {
            return this.Salario + 3000;
        }
    }
}