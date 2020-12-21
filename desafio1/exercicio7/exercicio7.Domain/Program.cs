using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente("Paula", 50, 8000);
            Supervisor s = new Supervisor("Pedro", 34, 5000);
            Vendedor v = new Vendedor("Carlos", 29, 4000);

            Console.WriteLine("Salário + bonificação = " + g.Bonificar());
            Console.WriteLine("Salário + bonificação = " + s.Bonificar());
            Console.WriteLine("Salário + bonificação = " + v.Bonificar());
        }
    }
}
