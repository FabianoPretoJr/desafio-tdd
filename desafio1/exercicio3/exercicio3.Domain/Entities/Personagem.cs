using Flunt.Notifications;
using Flunt.Validations;

namespace exercicio3.Domain.Entities
{
    public class Personagem : Notifiable
    {
        protected Personagem(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNull(nome, "Nome", "Nome inválido")
                .IsGreaterThan(0, vida, "Vida", "Vida inválida")
                .IsGreaterThan(0, mana, "Mana", "Mana inválida")
                .IsGreaterThan(0, xp, "Xp", "Xp inválido")
                .IsGreaterThan(0, inteligencia, "Inteligencia", "Inteligencia inválida")
                .IsGreaterThan(0, forca, "Forca", "Força inválida")
                .IsGreaterThan(0, level, "Level", "Level inválido")
            );

            Nome = nome;
            Vida = vida;
            Mana = mana;
            Xp = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
        }

        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Mana { get; set; }
        public float Xp { get; set; }
        public int Inteligencia { get; set; }
        public int Forca { get; set; }
        public int Level { get; set; }

        public virtual bool LvlUp()
        {
            return true;
        }
    }
}