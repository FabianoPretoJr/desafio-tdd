using System;

namespace exercicio3
{
    public class Personagem
    {
        public Personagem()
        {
            this.Nome = "";
            this.Vida = 0;
            this.Mana = 0;
            this.Xp = 0;
            this.Inteligencia = 0;
            this.Forca = 0;
            this.Level = 0;
        }

        public Personagem(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        {
            this.Nome = nome;
            this.Vida = vida;
            this.Mana = mana;
            this.Xp = xp;
            this.Inteligencia = inteligencia;
            this.Forca = forca;
            this.Level = level;
            NovoPersonagem();
        }

        private static int ContadorPersonagem;

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        private int vida;
        public int Vida
        {
            get { return vida; }
            set { vida = value; }
        }
        
        private int mana;
        public int Mana
        {
            get { return mana; }
            set { mana = value; }
        }
        
        private float xp;
        public float Xp
        {
            get { return xp; }
            set { xp = value; }
        }
        
        private int inteligencia;
        public int Inteligencia
        {
            get { return inteligencia; }
            set { inteligencia = value; }
        }
        
        private int forca;
        public int Forca
        {
            get { return forca; }
            set { forca = value; }
        }
        
        private int level;
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        
        public virtual void LvlUp()
        {
            
        }

        public static void NovoPersonagem()
        {
            ContadorPersonagem++;
        }

        public static void ContadorDePersonagens()
        {
            Console.WriteLine("\n---------------------------------------------------------\n");
            Console.WriteLine("Número de personagens existentes: " + ContadorPersonagem + "\n\n");
        }
    }
}