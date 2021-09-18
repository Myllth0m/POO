using System;

namespace Desafio6.Classes
{
    public class CarroUtilitario : Veiculo
    {
        public override void CalcularValorDoSeguro(decimal valor)
        {
            Console.WriteLine($"O valor do seguro sobre o carro utiliário é de R$ {valor * 0.25m}");
        }
    }
}
