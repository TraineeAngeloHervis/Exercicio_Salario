namespace Exercicio_Salario;

public class Vendedor(string nome, string valorHora, int horasTrabalhadas, float valorVendasEmDinheiro, float comissao, float salario)
{
    public string Nome { get; private set; } = nome;
    public string ValorHora { get; private set; } = valorHora;
    public int HorasTrabalhadas { get; private set; } = horasTrabalhadas;
    public float ValorVendasEmDinheiro { get; private set; } = valorVendasEmDinheiro;
    public float Comissao { get; private set; } = comissao;
    public float SalarioTotal { get; private set; } = salario;
}