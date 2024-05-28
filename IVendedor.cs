namespace Exercicio_Salario;

public interface IVendedor
{
    string Nome { get; }
    string ValorHora { get; }
    int HorasTrabalhadas { get; }
    float ValorVendasEmDinheiro { get; }
    float Comissao { get; }
    float SalarioTotal { get; }
    
    double CalcularSalario();
}