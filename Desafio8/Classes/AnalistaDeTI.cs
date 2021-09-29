using System;

namespace Desafio8.Classes
{
    public class AnalistaDeTI : Funcionario
    {
        public AnalistaDeTI(int id, string nome) : base(id, nome) { }

        public override void CalcularBonificacao()
        {
            Salario += 300m;
            Console.WriteLine($"O Analista de TI recebeu uma bonificação de {300m} reais");
        }
    }
}
