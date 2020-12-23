using System;
using System.Collections.Generic;
using Flunt.Notifications;
using Flunt.Validations;

namespace exercicio2.Domain.Entities
{
    public class Loja : Notifiable
    {
        public Loja(string nome, string cnpj, List<Livro> livros, List<Videogame> videogames)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNull(nome, "Nome", "Nome inválido")
                .IsNotNull(cnpj, "CNPJ", "CNPJ inválido")
                .IsNotNull(livros, "Livros", "Livros inválidos")
                .IsNotNull(videogames, "Videogames", "Videogames inválidos")
            );

            Nome = nome;
            CNPJ = cnpj;
            Livros = livros;
            Videogames = videogames;
        }

        public string Nome { get; private set; }
        public string CNPJ { get; private set; }
        public List<Livro> Livros { get; private set; }
        public List<Videogame> Videogames { get; private set; }
        
        public List<Livro> ListarLivros()
        {
            if(this.Livros != null)
            {
                return Livros;
            }

            return null;
        }

        public List<Videogame> ListarVideogames()
        {
            if (this.Videogames != null){
                return Videogames;
            }

            return null;
        }

        public double CalcularPatrimonio()
        {
            double patrimonio = 0;

            for(int i = 0; i < this.Livros.Count; i++)
            {
                Livro l = this.Livros[i];

                patrimonio = patrimonio + l.Preco;
            }
            for(int j = 0; j < this.Videogames.Count; j++)
            {
                Videogame vg = this.Videogames[j];

                patrimonio = patrimonio + vg.Preco;
            }

            return patrimonio;
        }
    }
}