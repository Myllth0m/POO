using Desafio10.Classes;
using Desafio10.Interfaces;
using System;

namespace Desafio10
{
    internal class CalculadorDeDesconto
    {
        public void Executar(SeguroDeVida seguroDeVida, IDesconto desconto)
        {
            desconto.AplicarDeAcordoComOSeguroDeVida(seguroDeVida);
        }
    }
}