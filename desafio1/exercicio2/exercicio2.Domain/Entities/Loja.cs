using System;
using System.Collections.Generic;

namespace exercicio2.Domain.Entities
{
    public class Loja
    {
        public Loja(string nome, string cNPJ, List<Livro> livros, List<Videogame> videogame)
        {
            Nome = nome;
            CNPJ = cNPJ;
            Livros = livros;
            Videogames = videogame;
        }

        public string Nome { get; private set; }
        public string CNPJ { get; private set; }
        public List<Livro> Livros { get; private set; }
        public List<Videogame> Videogames { get; private set; }
        
        public void ListarLivros()
        {
            if(this.Livros != null)
            {
                for (int i = 0; i < this.Livros.Count; i++)
                {
                    Livro l = this.Livros[i];
                    Console.WriteLine("\nTítulo: " + l.Nome + ", preço: " + l.Preco.ToString("C") + ", quantidade: " + l.Quantidade + " em estoque.");
                }
            }
        }

        public void ListarVideogames()
        {
            if (this.Videogames != null){
                for (int i = 0; i < this.Videogames.Count; i++)
                {
                    Videogame v = this.Videogames[i];
                    Console.Write("\nTítulo: " + v.Nome + ", preço: " + v.Preco.ToString("C") + ", quantidade: " + v.Quantidade + " em estoque.");
                }
            }
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