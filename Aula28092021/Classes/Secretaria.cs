using System;

namespace Aula28092021.Classes
{
    public class Secretaria : Funcionario
    {
        public Secretaria(int id, string nome) : base(id, nome) { }

        public override void CalcularBonificacao()
        {
            Salario += 100m;
            Console.WriteLine($"A Secretária recebeu uma bonificação de {100m} reais");
        }
    }
}
