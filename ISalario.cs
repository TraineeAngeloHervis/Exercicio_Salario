namespace Exercicio_Salario
{
    public interface ISalario
    {
        decimal SalarioTotal { get; set; }
        string CalcularSalario();
        string AtualizarSalario(decimal salarioTotal);
    }
}