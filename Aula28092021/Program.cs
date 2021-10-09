using System;
using Aula28092021.Classes;

namespace Aula28092021
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario gerente = new Gerente(1, "Milton");
            gerente.CalcularBonificacao();

            Funcionario analista = new AnalistaDeTI(2, "Daniel");
            analista.CalcularBonificacao();

            Funcionario secretaria = new Secretaria(3, "Secretária");
            secretaria.CalcularBonificacao();

            Console.ReadKey();
        }
    }
}
