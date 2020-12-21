using Flunt.Notifications;
using Flunt.Validations;
using exercicio1.Domain.Enums;

namespace exercicio1.Domain.Entities
{
    public class Veiculo : Notifiable
    {
        public Veiculo(string marca, string modelo, string placa, string cor, float km, int litrosCombustivel, int velocidade, double preco)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(marca, "Marca", "Marca inválida")
                .IsNotNullOrEmpty(modelo, "Modelo", "Modelo inválido")
                .IsNotNullOrEmpty(placa, "Placa", "Placa inválida")
                .IsNotNullOrEmpty(cor, "Cor", "Cor inválida")
                .IsGreaterOrEqualsThan(0, km, "Km", "Km inváilido")
                .IsGreaterOrEqualsThan(0, litrosCombustivel, "LitrosCombustivel", "Litros de combustivel inválido")
                .IsGreaterThan(0, preco, "Preco", "Preço inválido")
            );

            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Km = km;
            IsLigado = EVeiculoIsLigado.Desligado;
            LitrosCombustivel = litrosCombustivel;
            Velocidade = 0;
            Preco = preco;
        }

        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Placa { get; private set; }
        public string Cor { get; private set; }
        public float Km { get; private set; }
        public EVeiculoIsLigado IsLigado { get; private set; }
        public int LitrosCombustivel { get; private set; }
        public int Velocidade { get; private set; }
        public double Preco { get; private set; }

        public int Acelerar()
        {
            if(IsLigado.Equals(EVeiculoIsLigado.Ligado))
            {
                return this.Velocidade = this.Velocidade + 20;
            }
            else
            {
                return this.Velocidade;
            }
            
        }

        // public void Abastecer(int combustivel)
        // {
        //     if (this.LitrosCombustivel + combustivel > 60)
        //     {
        //         Console.WriteLine("Quantidade ultrapassa limite de 60 litros!");
        //     }
        //     else
        //     {
        //         this.litrosCombustivel = this.litrosCombustivel + combustivel;

        //         Console.WriteLine("Tem " + this.LitrosCombustivel + " litros no tanque de combustivel");
        //     }            
        // }

        // public void Frear()
        // {
        //     if (this.Velocidade > 0){
        //         this.velocidade = this.velocidade - 20;

        //         Console.WriteLine("Velocidade = " + this.Velocidade);
        //     }
        //     else
        //     {
        //         Console.WriteLine("Veículo está parado");
        //     }
        // }

        // public void Pintar(string cor)
        // {
        //     this.cor = cor;

        //     Console.WriteLine("O veículo foi pintado de " + this.Cor);
        // }

        // public void Ligar()
        // {
        //     if (!IsLigado)
        //     {
        //         this.isligado = true;

        //         Console.WriteLine("Veículo ligado!");
        //     }           
        // }

        // public void Desligar()
        // {
        //     if (IsLigado && this.Velocidade == 0)
        //     {
        //         this.isligado = false;

        //         Console.WriteLine("Veículo desligado!");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Veículo já está desligado ou está em movimento");
        //     }
        // }
    }
}