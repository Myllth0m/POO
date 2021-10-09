using System;

namespace Aula28092021.Classes
{
    public class Gerente : Funcionario
    {
        public Gerente(int id, string nome) : base(id, nome) { }

        public override void CalcularBonificacao()
        {
            Salario += 500m;
            Console.WriteLine($"O Gerente recebeu uma bonificação de {500m} reais");
        }
    }
}
