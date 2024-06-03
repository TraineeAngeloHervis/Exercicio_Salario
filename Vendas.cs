namespace Exercicio_Salario
{
    public class Vendas( int id, decimal valorVenda, string cpfVendedor)
    {
        public int Id { get; set; }
        public decimal ValorVenda { get; set; }
        public string CpfVendedor { get; set; }
    }
}