using System;

namespace Desafio8.Classes
{
    public class SMS : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("SMS enviado com sucesso!");
        }
    }
}
