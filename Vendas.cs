namespace Exercicio_Salario
{
    public class Vendas
    {
        private static int _id = 1;
        public int Id { get; init; }
        public required decimal ValorVenda { get; init; }
        public required string CpfVendedor { get; init; }

        public Vendas()
        {
            Id = _id++;
        }
}
}