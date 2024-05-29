namespace Exercicio_Salario;

public class Vendedor : IVendedor
{
    public string Cpf { get; set; }
    public string CnpjEmpresa { get; set; }
    public string Nome { get; set; }
    public decimal TotalVendas { get; set; }
    public int HorasTrabalhadas { get; set; }
    public decimal ValorPorHora { get; set; }
    public decimal ValorComissao { get; set; } = 0.15m;

    public string ListarInfosVendedor()
    {
        return $"Nome: {Nome}\n" +
               $"CPF: {Cpf}\n" +
               $"CNPJ da Empresa: {CnpjEmpresa}" +
               $"\nTotal de Vendas: {TotalVendas}" +
               $"\nHoras Trabalhadas: {HorasTrabalhadas}" +
               $"\nValor por Hora: {ValorPorHora}";
    }
    public void AtualizarSalario(decimal totalVendas, int horasTrabalhadas, decimal valorPorHora)
    {
        TotalVendas = totalVendas;
        HorasTrabalhadas = horasTrabalhadas;
        ValorPorHora = valorPorHora;
    }
}