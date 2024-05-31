namespace Exercicio_Salario
{
    public class Salario(decimal salarioTotal) : ISalario
    {
        public decimal SalarioTotal { get; set; } = salarioTotal;

        public Empresa empresa = new("123456789", "Empresa");

        public string CalcularSalario()
        {
            foreach (var vendedor in empresa.Vendedores)
            {
                SalarioTotal = vendedor.TotalVendas * vendedor.ValorComissao + vendedor.HorasTrabalhadas * vendedor.ValorPorHora;
            }
            return $"Salário Total: {SalarioTotal}";
        }

        public string AtualizarSalario(decimal salarioTotal)
        {
            SalarioTotal = salarioTotal;
            CalcularSalario();
            return $"Salário Total Atualizado: {SalarioTotal}";
        }
    }
}

