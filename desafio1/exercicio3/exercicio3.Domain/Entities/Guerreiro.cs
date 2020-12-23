using System;
using System.Collections.Generic;

namespace exercicio3.Domain.Entities
{
    public class Guerreiro : Personagem
    {
        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            Habilidades = new List<string>();
        }

        public List<string> Habilidades { get; set; }

        public override bool LvlUp()
        {
            this.Vida = this.Vida + 10;
            this.Forca = this.Forca + 10;
            ++this.Mana;
            ++this.Inteligencia;
            ++this.Level;

            return true;
        }

        public int Attack()
        {
            Random rnd = new Random();
            return (this.Forca * this.Level) + rnd.Next(0, 301);
        }

        public void AprenderHabilidade(string hab)
        {
            if(!string.IsNullOrEmpty(hab))
            {
                Habilidades.Add(hab);
            }
        }
    }
}