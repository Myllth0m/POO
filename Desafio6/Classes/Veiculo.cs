using System;

namespace Desafio6.Classes
{
    public class Veiculo
    {
        public virtual void CalcularValorDoSeguro(decimal valorDaDiaria)
        {
            Console.WriteLine($"O valor do seguro sobre o carro popular é de R$ {valorDaDiaria * 0.10m}");
        }
    }
}
