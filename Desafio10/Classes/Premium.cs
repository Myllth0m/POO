using Desafio10.Interfaces;
using System;

namespace Desafio10.Classes
{
    public class Premium : IDesconto
    {
        public void AplicarDeAcordoComOSeguroDeVida(SeguroDeVida seguroDeVida)
        {
            decimal desconto = seguroDeVida.Valor * 0.15m;

            seguroDeVida.Valor -= desconto;

            Console.WriteLine($"Desconto de {desconto} reais aplicado para o seguro premium.");
        }
    }
}
