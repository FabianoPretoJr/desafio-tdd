using exercicio2.Domain.Entities.Interfaces;
using Flunt.Validations;

namespace exercicio2.Domain.Entities
{
    public class Videogame : Produto, IImposto
    {
        public Videogame(string marca, string modelo, bool isUsado, string nome, double preco, int quantidade) : base(nome, preco, quantidade)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNull(marca, "Autor", "Autor inválido")
                .IsNotNull(modelo, "Tema", "Tema inválido")
            );

            Marca = marca;
            Modelo = modelo;
            IsUsado = isUsado;
        }

        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public bool IsUsado { get; private set; }

        public double calcularImposto()
        {
            if(this.IsUsado)
            {
                return this.Preco * 0.25;
            }
            else
            {
                return this.Preco * 0.45;
            }
        }
    }
}