﻿namespace Desafio8.Classes
{
    public abstract class Funcionario
    {
        protected Funcionario(int id, string nome)
        {
            Id = id;
            Nome = nome;
            Bonificacao = 0;
        }

        public int Id { get; private set; }
        public string Nome { get; set; }
        public decimal Bonificacao { get; set; }

        public abstract void CalcularBonificacao();
    }
}