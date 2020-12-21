using System;

namespace exercicio2
{
    public class Produto
    {
        public Produto()
        {
            this.nome = "";
            this.preco = 0.0;
            this.qtd = 0;
        }

        public Produto(string nome, double preco, int qtd)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        private double preco;
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
        private int qtd;
        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }
    }
}