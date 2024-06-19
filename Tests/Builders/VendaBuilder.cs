using Exercicio_Salario.Models;

namespace Exercicio_Salario.Tests.Builders;

public class VendaBuilder
{
    private decimal _valorVenda = 1000;
    private string _cpfVendedor = "";

    public VendaBuilder ComValorVenda(decimal valorVenda)
    {
        _valorVenda = valorVenda;
        return this;
    }

    public VendaBuilder ComCpfVendedor(string cpfVendedor)
    {
        _cpfVendedor = cpfVendedor;
        return this;
    }

    public Venda Build()
    {
        return new Venda
        {
            ValorVenda = _valorVenda,
            CpfVendedor = _cpfVendedor
        };
    }

    public static Venda ObterVendaPadrao()
    {
        return new VendaBuilder().Build();
    }
}