namespace Exercicio_Salario
{
    public class Vendas( int id, decimal valorVenda, string cpfVendedor)
    {
        public int Id { get;} = id;
        public decimal ValorVenda { get;} = valorVenda;
        public string CpfVendedor { get;} = cpfVendedor;
    }
}