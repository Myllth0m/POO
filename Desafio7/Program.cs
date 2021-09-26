using System;
using Desafio7.Classes;

namespace Desafio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta novaConta = new Conta("Milton Daniel Yama", "0540562", 50m);
            novaConta.VerificarSaldo();

            novaConta.Sacar(30m);
            novaConta.Depositar(80m);

            Console.ReadKey();
        }
    }
}
