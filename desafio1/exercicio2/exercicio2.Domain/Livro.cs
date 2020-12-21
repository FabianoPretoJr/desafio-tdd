using System;

namespace exercicio2
{
    public class Livro : Produto, IImposto
    {
        public Livro()
        {
            this.autor = "";
            this.tema = "";
            this.qtdPag = 0;
        }

        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base(nome,preco,qtd)
        {
            this.autor = autor;
            this.tema = tema;
            this.qtdPag = qtdPag;
        }

        private string autor;
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        
        private string tema;
        public string Tema
        {
            get { return tema; }
            set { tema = value; }
        }
        
        private int qtdPag;
        public int QtdPag
        {
            get { return qtdPag; }
            set { qtdPag = value; }
        }

        public double CalculaImposto()
        {
            double imposto = 0;

            if(this.Tema == "educativo")
            {
                Console.WriteLine("\nLivro educativo não tem imposto: " + this.Nome);

                return 0;
            }
            else
            {
                imposto = this.Preco * 0.1;
                Console.WriteLine("\n" + imposto.ToString("C") + " de imposto sobre o livro " + this.Nome);
            
                return imposto;
            }
        }
    }
}