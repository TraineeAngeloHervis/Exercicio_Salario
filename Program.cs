using Exercicio_Salario;
using Exercicio_Salario.Models;

var empresa = new Empresa
{
    Cnpj = "01234567000189",
    Nome = "Empresa 1"
};

var vendedor1 = new Vendedor
{
    Cpf = "123456789",
    CnpjEmpresa = "01234567000189",
    Nome = "Vendedor 1",
    PercentualComissao = 0.15m,
    SalarioFixo = 1000
};

var vendedor2 = new Vendedor
{
    Cpf = "987654321",
    CnpjEmpresa = "01234567000189",
    Nome = "Vendedor 2",
    PercentualComissao = 0.15m,
    SalarioFixo = 1000
};

empresa.AdicionarVendedor(vendedor1);
empresa.AdicionarVendedor(vendedor2);

var venda1 = new Venda
{
    ValorVenda = 1000,
    CpfVendedor = vendedor1.Cpf
};

var venda2 = new Venda
{
    ValorVenda = 2000,
    CpfVendedor = vendedor1.Cpf
};

var venda3 = new Venda
{
    ValorVenda = 3000,
    CpfVendedor = vendedor1.Cpf
};

var venda4 = new Venda
{
    ValorVenda = 4000,
    CpfVendedor = vendedor2.Cpf
};

var venda5 = new Venda
{
    ValorVenda = 5000,
    CpfVendedor = vendedor2.Cpf
};

var venda6 = new Venda
{
    ValorVenda = 6000,
    CpfVendedor = vendedor2.Cpf
};

vendedor1.Vendas.Add(venda1);
vendedor1.Vendas.Add(venda2);
vendedor1.Vendas.Add(venda3);
vendedor2.Vendas.Add(venda4);
vendedor2.Vendas.Add(venda5);
vendedor2.Vendas.Add(venda6);

Console.WriteLine(empresa.ListarVendedores());
Console.WriteLine(vendedor1.ListarInfosVendedor());
Console.WriteLine(vendedor2.ListarInfosVendedor());