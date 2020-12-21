using System;
using System.Collections.Generic;

namespace exercicio3
{
    public class Mago : Personagem
    {
        public Mago() : base()
        {

        }

        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            
        }

        private List<string> magia;
        public List<string> Magia
        {
            get { return magia; }
            set { magia = value; }
        }

        public override void LvlUp()
        {
            Console.WriteLine("\n---------------------------------------------------------\n");
            Console.WriteLine("\nParabéns, você acaba de subir de nível!!!\n");
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Vida: " + (++this.Vida));
            Console.WriteLine("Mana: " + (this.Mana = this.Mana + 10));
            Console.WriteLine("Inteligencia: " + (this.Inteligencia = this.Inteligencia + 10));
            Console.WriteLine("Força: " + (++this.Forca));
            Console.WriteLine("Level: " + (++this.Level));
        }

        public void Attack()
        {
            Random rnd = new Random();
            int valorAtaque = (this.Inteligencia * this.Level) + rnd.Next(0, 301);

            Console.WriteLine("\n---------------------------------------------------------\n");
            Console.WriteLine("\nPoder de Ataque do " + this.Nome + ": " + valorAtaque);
        }

        public void AprenderMagia(string mag)
        {
            List<string> magia = new List<string>();

            magia.Add(mag);

            Console.WriteLine("\n---------------------------------------------------------\n");
            Console.WriteLine("\nNova mágica adquirida por " + this.Nome + ": " + mag);
        }
    }
}