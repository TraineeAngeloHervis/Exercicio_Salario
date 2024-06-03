using Exercicio_Salario;

var empresa = new Empresa("123456789", "Empresa Teste");
var vendedor1 = new Vendedor("123456789", "123456789", "Vendedor 1", 0.15m, 1000, []);
var vendedor2 = new Vendedor("987654321", "123456789", "Vendedor 2", 0.15m, 1000, []);

empresa.AdicionarVendedor(vendedor1);
empresa.AdicionarVendedor(vendedor2);

var venda1 = new Vendas(1, 1000, vendedor1.Cpf);
var venda2 = new Vendas(2, 2000, vendedor1.Cpf);
var venda3 = new Vendas(3, 3000, vendedor1.Cpf);
var venda4 = new Vendas(4, 4000, vendedor2.Cpf);
var venda5 = new Vendas(5, 5000, vendedor2.Cpf);
var venda6 = new Vendas(6, 6000, vendedor2.Cpf);


vendedor1.ListaVendas.Add(venda1);
vendedor1.ListaVendas.Add(venda2);
vendedor1.ListaVendas.Add(venda3);
vendedor2.ListaVendas.Add(venda4);
vendedor2.ListaVendas.Add(venda5);
vendedor2.ListaVendas.Add(venda6);

vendedor1.CalcularSalario();
vendedor2.CalcularSalario();

Console.WriteLine(empresa.ListarVendedores());
Console.WriteLine(vendedor1.ListarInfosVendedor());
Console.WriteLine(vendedor2.ListarInfosVendedor());