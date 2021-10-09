using System;

namespace Desafio8.Classes
{
    public class VoiceMail : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Mensagem de voz enviada com sucesso!");
        }
    }
}
