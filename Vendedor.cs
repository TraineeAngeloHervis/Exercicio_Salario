namespace Exercicio_Salario
{
    public class Vendedor(string cpf, string nome, string cnpjEmpresa, decimal totalVendas, int horasTrabalhadas, decimal valorPorHora) : IVendedor
    {
        public string Cpf { get; set; } = cpf;
        public string CnpjEmpresa { get; set; } = cnpjEmpresa;
        public string Nome { get; set; } = nome;
        public decimal TotalVendas { get; set; } = totalVendas;
        public int HorasTrabalhadas { get; set; } = horasTrabalhadas;
        public decimal ValorPorHora { get; set; } = valorPorHora;
        public decimal ValorComissao { get; set; } = 0.15m;
        public decimal SalarioTotal { get; set; }

        public string CalcularSalario()
        {
            return $"Salário Total: {TotalVendas * ValorComissao + HorasTrabalhadas * ValorPorHora}";
        }

        public string AtualizarSalario(decimal salarioTotal)
        {
            return $"Salário Total Atualizado: {salarioTotal}";
        }



        public string ListarInfosVendedor()
        {
            return $"Nome: {Nome}\n" +
                   $"CPF: {Cpf}\n" +
                   $"CNPJ da Empresa: {CnpjEmpresa}" +
                   $"\nTotal de Vendas: {TotalVendas}" +
                   $"\nHoras Trabalhadas: {HorasTrabalhadas}" +
                   $"\nValor por Hora: {ValorPorHora}";
        }
    }
}