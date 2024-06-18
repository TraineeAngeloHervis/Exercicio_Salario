using Exercicio_Salario.Models;

namespace Exercicio_Salario.Tests.Builders;

public class VendedorBuilder
{
    private string _cpf = "12345678910";
    private string _cnpjEmpresa = "01234567000189";
    private string _nome = "Vendedor 1";
    private decimal _percentualComissao = 0.15m;
    private decimal _salarioFixo = 1000;
    private List<Venda> _vendas = [];
    private Empresa _empresa = new();
    
    public VendedorBuilder ComCpf(string cpf)
    {
        _cpf = cpf;
        return this;
    }
    
    public VendedorBuilder ComCnpjEmpresa(string cnpjEmpresa)
    {
        _cnpjEmpresa = cnpjEmpresa;
        return this;
    }
    
    public VendedorBuilder ComNome(string nome)
    {
        _nome = nome;
        return this;
    }
    
    public VendedorBuilder ComPercentualComissao(decimal percentualComissao)
    {
        _percentualComissao = percentualComissao;
        return this;
    }
    
    public VendedorBuilder ComSalarioFixo(decimal salarioFixo)
    {
        _salarioFixo = salarioFixo;
        return this;
    }
    
    public VendedorBuilder ComListaVendas(List<Venda> vendas)
    {
        _vendas = vendas;
        return this;
    }
    
    public VendedorBuilder ComEmpresa(Empresa empresa)
    {
        _empresa = empresa;
        return this;
    }
    
    public Vendedor Build()
    {
        return new Vendedor
        {
            Cpf = _cpf,
            CnpjEmpresa = _cnpjEmpresa,
            Nome = _nome,
            PercentualComissao = _percentualComissao,
            SalarioFixo = _salarioFixo,
            Vendas = _vendas,
            Empresa = _empresa
        };
    }
    
    public static Vendedor ObterVendedorPadrao()
    {
        return new VendedorBuilder().Build();
    }
}