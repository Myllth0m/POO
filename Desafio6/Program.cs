using System;
using Desafio6.Classes;

namespace Desafio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo carroPopular = new CarroPopular();
            carroPopular.CalcularValorDoSeguro(100);

            Veiculo carroDeLuxo = new CarroDeLuxo();
            carroDeLuxo.CalcularValorDoSeguro(300);

            Veiculo carroUtilitario = new CarroUtilitario();
            carroUtilitario.CalcularValorDoSeguro(400);

            Console.ReadKey();
        }
    }
}
