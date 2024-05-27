public class Salario(string nome, string valorHora, int horasTrabalhadas, float valorVendas, float comissao, float salario) : Empregado(nome, valorHora, horasTrabalhadas, valorVendas, comissao, salario) {
    public float CalcularSalario()
    {
        return HorasTrabalhadas * float.Parse(ValorHora);
    }
}