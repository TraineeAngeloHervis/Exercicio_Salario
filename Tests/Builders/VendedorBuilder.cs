using Bogus;
using Bogus.Extensions.Brazil;
using Exercicio_Salario.Models;

namespace Exercicio_Salario.Tests.Builders;

public class VendedorBuilder
{
    private readonly Faker<Vendedor> _faker;

    private VendedorBuilder()
    {
        _faker = new Faker<Vendedor>().CustomInstantiator(f => new Vendedor()
        {
            Cpf = f.Person.Cpf(false),
            CnpjEmpresa = f.Company.Cnpj(false),
            Nome = f.Person.FirstName,
            PercentualComissao = f.Random.Decimal(0, 100),
            SalarioFixo = f.Random.Decimal(0, 100000),
            Vendas = [],
            Empresa = new Empresa()
        });
    }

    public static VendedorBuilder Novo()
        => new();

    public VendedorBuilder ComCpf(string cpf)
    {
        _faker.RuleFor(u => u.Cpf, cpf);
        return this;
    }

    public VendedorBuilder ComCnpjEmpresa(string cnpjEmpresa)
    {
        _faker.RuleFor(u => u.CnpjEmpresa, cnpjEmpresa);
        return this;
    }

    public VendedorBuilder ComNome(string nome)
    {
        _faker.RuleFor(u => u.Nome, nome);
        return this;
    }

    public VendedorBuilder ComPercentualComissao(decimal percentualComissao)
    {
        _faker.RuleFor(u => u.PercentualComissao, percentualComissao);
        return this;
    }

    public VendedorBuilder ComSalarioFixo(decimal salarioFixo)
    {
        _faker.RuleFor(u => u.SalarioFixo, salarioFixo);
        return this;
    }

    public VendedorBuilder ComVendas(List<Venda> vendas)
    {
        _faker.RuleFor(u => u.Vendas, vendas.Select(v => new Venda
        {
            ValorVenda = v.ValorVenda,
            CpfVendedor = v.CpfVendedor
        }).ToList());
        return this;
    }

    public VendedorBuilder ComEmpresa(Empresa empresa)
    {
        _faker.RuleFor(u => u.Empresa, empresa);
        return this;
    }

    public Vendedor Build()
        => _faker.Generate();

    public string ListarInfosVendedor()
    {
        var vendedor = _faker.Generate();
        return vendedor.ListarInfosVendedor();
    }

    public decimal CalcularSalario()
    {
        var vendedor = _faker.Generate();
        return vendedor.CalcularSalario();
    }
}