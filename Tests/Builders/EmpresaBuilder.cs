using Bogus;
using Bogus.Extensions.Brazil;
using Exercicio_Salario.Models;

namespace Exercicio_Salario.Tests.Builders;

public class EmpresaBuilder
{
    private readonly Faker<Empresa> _faker;
    private List<Vendedor> _vendedores = [];

    private EmpresaBuilder()
    {
        _faker = new Faker<Empresa>().CustomInstantiator(f => new Empresa()
        {
            Cnpj = f.Company.Cnpj(false),
            Nome = f.Company.CompanyName(),
            Vendedores = _vendedores
        });
    }

    public static EmpresaBuilder Novo()
        => new();

    public EmpresaBuilder ComCnpj(string cnpj)
    {
        _faker.RuleFor(e => e.Cnpj, cnpj);
        return this;
    }

    public EmpresaBuilder ComNome(string nome)
    {
        _faker.RuleFor(e => e.Nome, nome);
        return this;
    }

    public EmpresaBuilder ComVendedores(List<Vendedor> vendedores)
    {
        _vendedores = vendedores;
        return this;
    }

    public EmpresaBuilder AdicionarVendedor(Vendedor vendedor)
    {
        _vendedores.Add(vendedor);
        return this;
    }

    public EmpresaBuilder RemoverVendedor(Vendedor vendedor)
    {
        _vendedores.Remove(vendedor);
        return this;
    }

    public string ListarVendedores()
    {
        var empresa = _faker.Generate();
        return empresa.ListarVendedores();
    }

    public Empresa Build()
        => _faker.Generate();
}