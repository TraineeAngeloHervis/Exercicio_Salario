public class Empregado(string nome, string valorHora, int horasTrabalhadas, float valorVendas, float comissao, float salario)
{
    public string Nome { get; set; } = nome;
    public string ValorHora { get; set; } = valorHora;
    public int HorasTrabalhadas { get; set; } = horasTrabalhadas;
    public float ValorVendas { get; set; } = valorVendas;
    public float Comissao { get; set; } = comissao;
    public float SalarioTotal { get; set; } = salario;
}