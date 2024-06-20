namespace Exercicio_Salario.Models;

public class Venda
{
    public required decimal ValorVenda { get; init; }
    public required string CpfVendedor { get; init; }

    public Venda()
    {
        ValorVenda = 0;
        CpfVendedor = "";
    }
}