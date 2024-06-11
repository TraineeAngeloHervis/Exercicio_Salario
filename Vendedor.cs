namespace Exercicio_Salario;

public class Vendedor(string cpf, 
    string cnpjEmpresa, 
    string nome, 
    decimal percentualComissao, 
    decimal salarioFixo, 
    List<Vendas> listaVendas, 
    string infosVendedor)
{
    public string Cpf { get; } = cpf;
    public string CnpjEmpresa { get; } = cnpjEmpresa;
    public string Nome { get; private set; } = nome;
    public decimal PercentualComissao { get; set; } = percentualComissao;
    public decimal SalarioFixo { get; set; } = salarioFixo;
    public List<Vendas> ListaVendas { get; set; } = listaVendas;
    public string InfosVendedor { get; set; } = infosVendedor;
    public Empresa Empresa { get; set; }
        
    public decimal CalcularSalario()
    {
        try
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
            if (ListaVendas.Any(v => v.ValorVenda < 0))
            {
                throw new Exception("Valor de venda não pode ser negativo");
            }
            var totalVendas = ListaVendas.Sum(v => v.ValorVenda);
            var totalComissao = totalVendas * PercentualComissao;

            return SalarioFixo + totalComissao;
        }
        catch (Exception e)
        {
            throw new Exception("Erro ao calcular o salário do vendedor", e);
        }
    }

    public string ListarInfosVendedor()
    {
        try
        {
            InfosVendedor = $"Nome: {Nome}\n" +
                            $"CPF: {Cpf}\n" +
                            $"CNPJ da Empresa: {CnpjEmpresa}\n" +
                            $"Salário Fixo: {SalarioFixo}\n" +
                            $"Percentual de Comissão: {PercentualComissao}\n" +
                            $"Salário Total: {CalcularSalario():C}";
            return InfosVendedor;
        }
        catch (Exception e)
        {
            throw new Exception("Erro ao listar as informações do vendedor", e);
        }
    }
}