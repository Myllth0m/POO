using System;

namespace Desafio10.Classes
{
    public class SeguroDeVida
    {
        public SeguroDeVida(decimal valor)
        {
            Valor = valor;
        }

        public decimal Valor { get; set; }

        public void ConsultarValor()
        {
            Console.WriteLine($"Valor total do seguro: R$ {Valor}");
        }
    }
}
