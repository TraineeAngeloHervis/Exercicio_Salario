using Exercicio_Salario;
using System.Collections.Generic;

Empresa empresa = new("123456789", "Empresa Teste");
ISalario salario = new Salario(0);

empresa.AdicionarVendedor(new Vendedor("123456789", "123456789", "Ângelo", 1000, 40, 10));
empresa.AdicionarVendedor(new Vendedor("123456789", "123456789", "Gomes", 2000, 40, 10));
empresa.AdicionarVendedor(new Vendedor("123456789", "123456789", "Junior", 3000, 40, 10));

empresa.Vendedores[0].CalcularSalario();
empresa.Vendedores[1].CalcularSalario();
empresa.Vendedores[2].CalcularSalario();

Console.WriteLine(empresa.ListarVendedores());

empresa.RemoverVendedor(empresa.Vendedores[2]);

Console.WriteLine(empresa.ListarVendedores());

empresa.Vendedores[0].AtualizarSalario(2000);
empresa.Vendedores[1].AtualizarSalario(3000);

Console.WriteLine(empresa.ListarVendedores());