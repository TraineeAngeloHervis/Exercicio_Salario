using Exercicio_Salario.Exceptions;

namespace Exercicio_Salario.Models;

public class Vendedor
{
    public string Cpf { get; set; }
    public string CnpjEmpresa { get; init; }
    public string Nome { get; set; }
    public decimal PercentualComissao { get; set; }
    public decimal SalarioFixo { get; set; }
    public List<Venda> Vendas { get; set; }
    public Empresa Empresa { get; set; }

    public Vendedor()
    {
        Cpf = "";
        CnpjEmpresa = "";
        Nome = "";
        Vendas = [];
    }

    public decimal CalcularSalario()
    {
        if (PercentualComissao < 0)
        {
            throw new ComissaoNegativaException();
        }

        if (SalarioFixo < 0)
        {
            throw new SalarioNegativoException();
        }

        if (Vendas.Exists(v => v.ValorVenda < 0))
        {
            throw new ValorVendaNegativoException();
        }

        var totalVendas = Vendas.Sum(v => v.ValorVenda);
        var totalComissao = totalVendas * PercentualComissao;

        return SalarioFixo + totalComissao;
    }

    public string ListarInfosVendedor()
    {
        var infosVendedor = $"Nome: {Nome}\n" +
                            $"CPF: {Cpf}\n" +
                            $"CNPJ da Empresa: {CnpjEmpresa}\n" +
                            $"Salário Fixo: {SalarioFixo}\n" +
                            $"Percentual de Comissão: {PercentualComissao:P}\n" +
                            $"Salário Total: R$ {CalcularSalario():N2}";
        return infosVendedor;
    }
}