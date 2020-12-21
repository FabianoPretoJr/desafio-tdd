using Flunt.Notifications;
using Flunt.Validations;
using exercicio1.Domain.Enums;

namespace exercicio1.Domain.Entities
{
    public class Veiculo : Notifiable
    {
        public Veiculo(string marca, string modelo, string placa, string cor, float km, int litrosCombustivel, double preco)
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

        public void Ligar()
        {
            if (IsLigado.Equals(EVeiculoIsLigado.Desligado))
            {
                IsLigado = EVeiculoIsLigado.Ligado;
            }           
        }

        public void Desligar()
        {
            if (IsLigado.Equals(EVeiculoIsLigado.Ligado) && this.Velocidade == 0)
            {
                this.IsLigado = EVeiculoIsLigado.Desligado;
            }
        }

        public void Acelerar()
        {
            if(IsLigado.Equals(EVeiculoIsLigado.Ligado))
            {
                this.Velocidade = this.Velocidade + 20;
            }
        }

        public void Frear()
        {
            if (this.Velocidade > 0 && this.IsLigado.Equals(EVeiculoIsLigado.Ligado)){
                this.Velocidade = this.Velocidade - 20;
            }
        }

        public void Pintar(string cor)
        {
            if(!string.IsNullOrWhiteSpace(cor))
            {
                this.Cor = cor;
            }
        }

        public void Abastecer(int combustivel)
        {
            if ((this.LitrosCombustivel + combustivel) <= 60 && this.IsLigado.Equals(EVeiculoIsLigado.Desligado))
            {
                this.LitrosCombustivel = this.LitrosCombustivel + combustivel;
            }
        }
    }
}