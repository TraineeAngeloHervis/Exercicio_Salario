namespace Exercicio_Salario;

public class Empresa(string cnpj, string nome)
{
    public string Cnpj { get; private set; } = cnpj;
    public string Nome { get; private set; } = nome;
    private List<IVendedor> Vendedores { get; set; } = [];
    
    public void AdicionarVendedor(IVendedor vendedor)
    {
        vendedor.CnpjEmpresa = Cnpj;
        Vendedores.Add(vendedor);
    }
    
    public void RemoverVendedor(IVendedor vendedor)
    {
        Vendedores.Remove(vendedor);
    }
    
    public string ListarVendedores()
    {
        var listaVendedores = "";
        foreach (var vendedor in Vendedores)
        {
            listaVendedores += vendedor.ListarInfosVendedor() + "\n";
        }
        return listaVendedores;
    }
}

