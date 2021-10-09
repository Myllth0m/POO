using System;

namespace Desafio8.Classes
{
    public class Email : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Email enviado com sucesso!");
        }
    }
}
