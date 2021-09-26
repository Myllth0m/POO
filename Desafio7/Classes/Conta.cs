using System;

namespace Desafio7.Classes
{
    public class Conta
    {
        public Conta(string titular, string numero, decimal saldo)
        {
            Titular = titular;
            Numero = numero;
            Saldo = saldo;
        }

        public string Titular { get; private set; }
        public string Numero { get; private set; }
        private decimal Saldo { get; set; }

        public void VerificarSaldo()
        {
            Console.WriteLine($"Seu saldo atual é de {Saldo} reais");
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0 || valor > Saldo)
            {
                Console.WriteLine("Verifique o valor informado e tente novamente");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Você sacou {valor} reais");
            }

            VerificarSaldo();
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Informe um valor válido para depositar");
            }
            else
            {
                Saldo += valor;
                Console.WriteLine($"Você depositou {valor} reais");
            }

            VerificarSaldo();
        }
    }
}
