using exercicio2.Domain.Entities.Interfaces;
using Flunt.Validations;

namespace exercicio2.Domain.Entities
{
    public class Livro : Produto, IImposto
    {
        public Livro(string autor, string tema, int qtdPags, string nome, double preco, int quantidade) : base(nome, preco, quantidade)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNull(autor, "Autor", "Autor inválido")
                .IsNotNull(tema, "Tema", "Tema inválido")
                .IsGreaterThan(0, qtdPags, "QtdPags", "Quantidades de páginas deve ser maior do que zero")
            );

            Autor = Autor;
            Tema = tema;
            QtdPags = qtdPags;
        }

        public string Autor { get; private set; }
        public string Tema { get; private set; }
        public int QtdPags { get; private set; }

        public double calcularImposto()
        {
            if(this.Tema == "educativo")
            {
                return 0;
            }
            else
            {            
                return this.Preco * 0.1;
            }
        }
    }
}