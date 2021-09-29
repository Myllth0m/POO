using System;
using Desafio8.Classes;

namespace Desafio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario gerente = new Gerente(1, "Milton");
            gerente.CalcularBonificacao();
            
            Funcionario analista = new AnalistaDeTI(1, "Daniel");
            analista.CalcularBonificacao();

            Funcionario secretaria = new Secretaria(1, "Secretária");
            secretaria.CalcularBonificacao();

            Console.ReadKey();
        }
    }
}
