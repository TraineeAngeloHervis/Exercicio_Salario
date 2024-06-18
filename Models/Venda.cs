namespace Exercicio_Salario.Models
{
    public class Venda
    {
        public Guid Id { get; init; }
        public required decimal ValorVenda { get; init; }
        public required string CpfVendedor { get; init; }

        public Venda()
        {
            Id = Guid.NewGuid();
            ValorVenda = 0;
            CpfVendedor = "";
        }
}
}