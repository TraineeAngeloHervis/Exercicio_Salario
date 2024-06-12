namespace Exercicio_Salario;

public class Vendedor
{
    public string Cpf { get; init; }
    public string CnpjEmpresa { get; init; }
    public string Nome { get; set; }
    public decimal PercentualComissao { get; set; } 
    public decimal SalarioFixo { get; set; } 
    public List<Vendas> ListaVendas { get; set; }
    public string InfosVendedor { get; set; }
    public Empresa Empresa { get; set; }
    
    public Vendedor()
    {
        Cpf = "";
        CnpjEmpresa = "";
        Nome = "";
        ListaVendas = [];
    }
        
    public decimal CalcularSalario()
    {
        
            if (ListaVendas == null || ListaVendas.Count == 0 || PercentualComissao == 0)
            {
                return SalarioFixo;
            }
            if (PercentualComissao < 0)
            {
                throw new Exception("Percentual de comissão não pode ser negativo");
            }
            if (SalarioFixo < 0)
            {
                throw new Exception("Salário fixo não pode ser negativo");
            }
            if (ListaVendas.Exists(v => v.ValorVenda < 0))
            {
                throw new Exception("Valor de venda não pode ser negativo");
            }
            var totalVendas = ListaVendas.Sum(v => v.ValorVenda);
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