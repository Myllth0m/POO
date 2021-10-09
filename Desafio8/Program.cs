using System;
using Desafio8.Classes;

namespace Desafio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Notificacao mensagemDeVoz = new VoiceMail();
            mensagemDeVoz.Enviar();

            Notificacao email = new Email();
            email.Enviar();

            Notificacao sms = new SMS();
            sms.Enviar();

            Console.ReadKey();
        }
    }
}
