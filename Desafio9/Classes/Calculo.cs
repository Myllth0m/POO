using System;

namespace Desafio9.Classes
{
    public class Calculo
    {
        public void SequenciaFibonacci(int limiteDaSequencia)
        {
            int numeroAnterior;
            int numeroAtual = 0;
            int numeroPosterior = 1;

            Console.Write($"{numeroAtual}, {numeroPosterior}, ");

            for (int i = 0; i < limiteDaSequencia; i++)
            {
                numeroAnterior = numeroAtual;
                numeroAtual = numeroPosterior;
                numeroPosterior = numeroAtual + numeroAnterior;

                Console.Write($"{numeroPosterior}, ");
            }
        }
    }
}
