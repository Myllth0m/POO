using Desafio10.Classes;
using Desafio10.Interfaces;
using System;

namespace Desafio10
{
    class Program
    {
        static void Main(string[] args)
        {
            IDesconto descontoNormal = new Normal();
            IDesconto descontoPremium = new Premium();

            SeguroDeVida seguroDeVidaNormal = new SeguroDeVida(100);
            SeguroDeVida seguroDeVidaPremium = new SeguroDeVida(1000);

            CalculadorDeDesconto calculador = new CalculadorDeDesconto();
            calculador.Executar(seguroDeVidaNormal, descontoNormal);
            seguroDeVidaNormal.ConsultarValor();

            calculador.Executar(seguroDeVidaPremium, descontoPremium);
            seguroDeVidaPremium.ConsultarValor();

            Console.ReadLine();
        }
    }
}
