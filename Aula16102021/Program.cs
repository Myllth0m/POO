using System;
using Aula16102021.Classes;

namespace Aula16102021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para descobrir a sequência de dez pares: ");
            var numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite quantas posições você quer: ");
            var posicaoInicial = Convert.ToInt32(Console.ReadLine());

            Funcoes funcoes = new Funcoes();
            funcoes.BuscarNumeroPar(numero, posicaoInicial);

            Console.ReadLine();
        }
    }
}
