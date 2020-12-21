using System;
using System.Collections.Generic;

namespace exercicio2
{
    public class Loja
    {
        public Loja()
        {
            this.nome = "";
            this.cnpj = "";
        }

        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videogames)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.livros = livros;
            this.videoGames = videogames;
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        private string cnpj;
        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        
        private List<Livro> livros;
        public List<Livro> Livros
        {
            get { return livros; }
            set { livros = value; }
        }
        
        private List<VideoGame> videoGames;
        public List<VideoGame> VideoGames
        {
            get { return videoGames; }
            set { videoGames = value; }
        }

        public double listaLivros()
        {
            Console.Write("\n-------------------------------------------------------------------------");
            Console.WriteLine("\nA loja " + this.nome + " possui estes livros para venda:");

            if (this.Livros[0] != null){
                for (int i = 0; i < this.Livros.Count; i++)
                {
                    Livro l = this.Livros[i];
                    Console.WriteLine("\nTítulo: " + l.Nome + ", preço: " + l.Preco.ToString("C") + ", quantidade: " + l.Qtd + " em estoque.");
                }
            }  
            else
            {
                Console.WriteLine("\nA loja não tem livros no seu estoque.");
            }

            return 0.0;
        }

        public void listaVideoGames()
        {
            Console.Write("\n--------------------------------------------------------------------------");
            Console.WriteLine("\nA loja " + this.nome + " possui estes video-games para venda:");

            if (this.VideoGames[0] != null){
                for (int i = 0; i < this.VideoGames.Count; i++)
                {
                    VideoGame v = this.VideoGames[i];
                    Console.Write("\nTítulo: " + v.Nome + ", preço: " + v.Preco.ToString("C") + ", quantidade: " + v.Qtd + " em estoque.");
                }
            }  
            else
            {
                Console.WriteLine("\n\nA loja não tem video-games no seu estoque.");
            }
        }

        public double CalculaPatrimonio()
        {
            double patrimonio = 0;

            for(int i = 0; i < this.Livros.Count; i++)
            {
                Livro l = this.Livros[i];

                patrimonio = patrimonio + l.Preco;
            }
            for(int j = 0; j < this.VideoGames.Count; j++)
            {
                VideoGame vg = this.VideoGames[j];

                patrimonio = patrimonio + vg.Preco;
            }

            return patrimonio;
        }
    }
}