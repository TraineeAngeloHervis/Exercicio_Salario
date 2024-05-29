namespace Exercicio_Salario
{
    public class Salario
    {
        public string CnpjEmpresa { get; }
        public string CpfVendedor { get; }
        private decimal ValorComissao { get; set; }
        public decimal SalarioTotal { get; private set; }
        
        private readonly IVendedor _vendedor;
        
        public Salario(IVendedor vendedor)
        {
            _vendedor = vendedor;
        }
        
        public void CalcularSalario()
        {
            ValorComissao = _vendedor.TotalVendas * _vendedor.ValorComissao;
            SalarioTotal = _vendedor.HorasTrabalhadas * _vendedor.ValorPorHora + ValorComissao;
        }
        
        public void AtualizarSalario(decimal totalVendas, int horasTrabalhadas, decimal valorPorHora)
        {
            _vendedor.AtualizarSalario(totalVendas, horasTrabalhadas, valorPorHora);
        }
    }
}