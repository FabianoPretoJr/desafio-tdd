using System;
using System.Collections.Generic;

namespace exercicio3.Domain.Entities
{
    public class Mago : Personagem
    {
        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            Magia = new List<string>();
        }

        public List<string> Magia { get; set; }

        public override bool LvlUp()
        {
            this.Mana = this.Mana + 10;
            this.Inteligencia = this.Inteligencia + 10;
            ++this.Vida;
            ++this.Forca;
            ++this.Level;

            return true;
        }

        public int Attack()
        {
            Random rnd = new Random();
            return (this.Inteligencia * this.Level) + rnd.Next(0, 301);
        }

        public void AprenderMagia(string mag)
        {
            if(!string.IsNullOrEmpty(mag))
            {
                Magia.Add(mag);
            }
        }
    }
}