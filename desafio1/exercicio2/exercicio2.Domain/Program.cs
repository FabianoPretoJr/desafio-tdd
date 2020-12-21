using System;
using System.Collections.Generic;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
            Livro l2 = new Livro("Senhor dos Anéis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
            Livro l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

            VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slin", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000, 7, "Sony", "Slin", true);
            VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            List<VideoGame> games = new List<VideoGame>();
            games.Add(ps4);
            games.Add(ps4Usado);
            games.Add(xbox);

            Loja americanas = new Loja("Americanas", "12345678", livros, games);

            l2.CalculaImposto();
            l3.CalculaImposto();

            ps4Usado.CalculaImposto();
            ps4.CalculaImposto();

            americanas.listaLivros();
            americanas.listaVideoGames();

            double patrimonio = americanas.CalculaPatrimonio();
            Console.Write("\n--------------------------------------------------------------------------");
            Console.WriteLine("\n\nO patrimonio da loja: " + americanas.Nome + " é de " + patrimonio.ToString("C"));
        }
    }
}
