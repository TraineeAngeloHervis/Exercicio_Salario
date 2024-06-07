using Exercicio_Salario;

var empresa = new Empresa("123456789", "Empresa 1");

var vendedor1 = new Vendedor("123456789", "123456789", "Vendedor 1", 0.15m, 1000, [], "");
var vendedor2 = new Vendedor("987654321", "123456789", "Vendedor 2", 0.15m, 1000, [], "");


empresa.AdicionarVendedor(vendedor1);
empresa.AdicionarVendedor(vendedor2);

var venda1 = new Vendas
{
    ValorVenda = 1000,
    CpfVendedor = vendedor1.Cpf
};

var venda2 = new Vendas
{
    ValorVenda = 2000,
    CpfVendedor = vendedor1.Cpf
};

var venda3 = new Vendas
{
    ValorVenda = 3000,
    CpfVendedor = vendedor1.Cpf
};

var venda4 = new Vendas
{
    ValorVenda = 4000,
    CpfVendedor = vendedor2.Cpf
};

var venda5 = new Vendas
{
    ValorVenda = 5000,
    CpfVendedor = vendedor2.Cpf
};

var venda6 = new Vendas
{
    ValorVenda = 6000,
    CpfVendedor = vendedor2.Cpf
};

vendedor1.ListaVendas.Add(venda1);
vendedor1.ListaVendas.Add(venda2);
vendedor1.ListaVendas.Add(venda3);
vendedor2.ListaVendas.Add(venda4);
vendedor2.ListaVendas.Add(venda5);
vendedor2.ListaVendas.Add(venda6);

Console.WriteLine(empresa.ListarVendedores());
Console.WriteLine(vendedor1.ListarInfosVendedor());
Console.WriteLine(vendedor2.ListarInfosVendedor());