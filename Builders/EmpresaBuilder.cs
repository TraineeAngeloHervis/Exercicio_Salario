using Exercicio_Salario.Models;

namespace Exercicio_Salario.Builders;

public class EmpresaBuilder
{
    private string _cnpj = "01234567000189";
    private string _nome = "Empresa 1";
    private List<Vendedor> _vendedores = [];
    
    public EmpresaBuilder ComCnpj(string cnpj)
    {
        _cnpj = cnpj;
        return this;
    }
    
    public EmpresaBuilder ComNome(string nome)
    {
        _nome = nome;
        return this;
    }
    
    public EmpresaBuilder ComVendedores(List<Vendedor> vendedores)
    {
        _vendedores = vendedores;
        return this;
    }
    
    public Empresa Build()
    {
        return new Empresa
        {
            Cnpj = _cnpj,
            Nome = _nome,
            Vendedores = _vendedores
        };
    }
    
    public static Empresa ObterEmpresaPadrao()
    {
        return new EmpresaBuilder().Build();
    }
}
