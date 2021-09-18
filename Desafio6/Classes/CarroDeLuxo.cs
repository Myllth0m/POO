using System;

namespace Desafio6.Classes
{
    public class CarroDeLuxo : Veiculo
    {
        public override void CalcularValorDoSeguro(decimal valor)
        {
            Console.WriteLine($"O valor do seguro sobre o carro de luxo é de R$ {valor * 0.20m}");
        }
    }
}
