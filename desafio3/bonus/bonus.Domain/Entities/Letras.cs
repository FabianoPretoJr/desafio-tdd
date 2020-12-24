using Flunt.Notifications;
using Flunt.Validations;

namespace bonus.Domain.Entities
{
    public class Letras : Notifiable
    {
        public Letras(char letra1, char letra2)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNull(letra1, "Letra1", "Letra 1 inválida")
                .IsNotNull(letra2, "Letra2", "Letra 2 inválida")
            );

            Letra1 = letra1;
            Letra2 = letra2;
        }

        public char Letra1 { get; private set; }
        public char Letra2 { get; private set; }

        public bool VerificarOrdem()
        {
            if(Letra1 > Letra2)
                return false;
            else
                return true;
        }

        public string ContarIntervaloLetras()
        {
            if(VerificarOrdem())
            {
                int cont = 0;
                for(int i = (Letra1 + 1); i < Letra2; i++)
                {
                    cont++;
                }
                return cont.ToString();
            }
            else
            {
                return "Não está na ordem alfabética";
            }
        }
    }
}