using System;

namespace Aula16102021.Classes
{
    public class Funcoes
    {
        public void BuscarNumeroPar(int numero, int posicaoInicial)
        {
            for (int i = 0; i < posicaoInicial; i++)
            {
                Console.WriteLine(numero + i * 2);
            }
        }
    }
}
