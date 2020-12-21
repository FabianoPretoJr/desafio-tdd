using System;
using System.Collections.Generic;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mago mago1 = new Mago("Gandalf", 40, 150, 31, 154, 10, 146);
            Mago mago2 = new Mago("Merlin", 30, 100, 48, 197, 40, 164);
            Mago mago3 = new Mago("Doutor Estranho", 60, 200, 13, 182, 60, 172);

            Guerreiro guerreiro1 = new Guerreiro("Rei Arthur", 120, 10, 52, 120, 134, 167);
            Guerreiro guerreiro2 = new Guerreiro("Jon Snow", 150, 5, 47, 99, 120, 132);
            Guerreiro guerreiro3 = new Guerreiro("Hércules", 200, 30, 67, 110, 200, 186);
            
            mago1.AprenderMagia("Ocus Pocus");
            mago2.AprenderMagia("Xablau");
            mago3.AprenderMagia("Sim Salabim");

            guerreiro1.AprenderHabilidade("Corte da Espada Excalibur");
            guerreiro2.AprenderHabilidade("Voo em Dragão");
            guerreiro3.AprenderHabilidade("Super Soco");

            mago1.Attack();
            mago2.Attack();
            mago3.Attack();
            guerreiro1.Attack();
            guerreiro2.Attack();
            guerreiro3.Attack();

            mago1.LvlUp();
            mago2.LvlUp();
            mago3.LvlUp();
            guerreiro1.LvlUp();
            guerreiro2.LvlUp();
            guerreiro3.LvlUp();

            Personagem.ContadorDePersonagens();
        }
    }
}
