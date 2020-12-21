using System;
using System.Collections.Generic;

namespace exercicio3
{
    public class Guerreiro : Personagem
    {
        public Guerreiro() : base()
        {

        }

        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            
        }

        private List<string> habilidade;
        public List<string> Habilidade
        {
            get { return habilidade; }
            set { habilidade = value; }
        }

        public override void LvlUp()
        {
            Console.WriteLine("\n---------------------------------------------------------\n");
            Console.WriteLine("\nParabéns, você acaba de subir de nível!!!\n");
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Vida: " + (this.Vida = this.Vida + 10));
            Console.WriteLine("Mana: " + (++this.Mana));
            Console.WriteLine("Inteligencia: " + (++this.Inteligencia));
            Console.WriteLine("Força: " + (this.Forca = this.Forca + 10));
            Console.WriteLine("Level: " + (++this.Level));
        }

        public void Attack()
        {
            Random rnd = new Random();
            int valorAtaque = (this.Forca * this.Level) + rnd.Next(0, 301);

            Console.WriteLine("\n---------------------------------------------------------\n");
            Console.WriteLine("\nPoder de Ataque do " + this.Nome + ": " + valorAtaque);
        }

        public void AprenderHabilidade(string hab)
        {
            List<string> habilidade = new List<string>();

            habilidade.Add(hab);

            Console.WriteLine("\n---------------------------------------------------------\n");
            Console.WriteLine("\nNova habilidade adquirida por " + this.Nome + ": " + hab);
        }
    }
}