using System;

namespace exercicio2
{
    public class VideoGame : Produto, IImposto
    {
        public VideoGame()
        {
            this.marca = "";
            this.modelo = "";
            this.isUsado = false;
        }

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome,preco,qtd)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.isUsado = isUsado;
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        
        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        
        private bool isUsado;
        public bool IsUsado
        {
            get { return isUsado; }
            set { isUsado = value; }
        }

        public double CalculaImposto()
        {
            double imposto = 0;

            if(this.IsUsado)
            {
                imposto = this.Preco * 0.25;
                Console.WriteLine("Imposto " + this.Nome + " usado, " + imposto.ToString("C"));

                return imposto;
            }
            else
            {
                imposto = this.Preco * 0.45;

                Console.WriteLine("Imposto " + this.Nome + " " + imposto.ToString("C"));

                return imposto;
            }
        }
    }
}
