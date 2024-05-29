namespace Exercicio_Salario;

public interface IVendedor
{
    string Cpf { get; set; }
    string CnpjEmpresa { get; set; }
    string Nome { get; set; }
    decimal TotalVendas { get; set; }
    int HorasTrabalhadas { get; set; }
    decimal ValorPorHora { get; set; }
    decimal ValorComissao { get; set; }
    string ListarInfosVendedor();
    void AtualizarSalario(decimal totalVendas, int horasTrabalhadas, decimal valorPorHora);
}