namespace Desafio8.Classes
{
    public abstract class Funcionario
    {
        protected Funcionario(int id, string nome)
        {
            Id = id;
            Nome = nome;
            Salario = 0;
        }

        public int Id { get; private set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        public abstract void CalcularBonificacao();
    }
}
