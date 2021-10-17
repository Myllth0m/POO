using System;
using Desafio9.Classes;

namespace Desafio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o limite da sequência de fibonacci: ");
            int limiteDaSequencia = Convert.ToInt32(Console.ReadLine());

            Calculo calculo = new Calculo();
            calculo.SequenciaFibonacci(limiteDaSequencia);

            Console.ReadLine();
        }
    }
}
