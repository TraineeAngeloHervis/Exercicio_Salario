namespace Exercicio_Salario
{
    public class Vendedor( string cpf, string cnpjEmpresa, string nome, decimal percentualComissao, decimal salarioFixo, List<Vendas> listaVendas)
    {
        public string Cpf { get; set; } = cpf;
        public string CnpjEmpresa { get; set; } = cnpjEmpresa;
        public string Nome { get; set; } = nome;
        public decimal PercentualComissao { get; set; } = percentualComissao;
        public decimal SalarioFixo { get; set; } = salarioFixo;
        public List<Vendas> ListaVendas { get; set; } = listaVendas; 
        public Empresa Empresa { get; set; }
        
        public decimal CalcularSalario()
        {
            if (ListaVendas.Count == 0)
            {
                return SalarioFixo;
            }

            var totalVendas = ListaVendas.Sum(v => v.ValorVenda);
            var totalComissao = totalVendas * PercentualComissao;

            return SalarioFixo + totalComissao;
        }
        public string ListarInfosVendedor()
        {
            var salarioTotal = CalcularSalario();

            return $"Nome: {Nome}\n" +
                   $"CPF: {Cpf}\n" +
                   $"CNPJ da Empresa: {CnpjEmpresa}" +
                   $"\nSalário Fixo: {SalarioFixo}" +
                   $"\nPercentual de Comissão: {PercentualComissao}" +
                   $"\nSalário Total: {salarioTotal}";
        }
    }
}