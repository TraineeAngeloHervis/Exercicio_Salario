namespace Exercicio_Salario
{
    public class Empresa(string cnpj, string nome)
    {
        public string Cnpj { get; private set; } = cnpj;
        public string Nome { get; private set; } = nome;
        public List<Vendedor> Vendedores { get; set; } = [];

        public void AdicionarVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }
        public void RemoverVendedor(Vendedor vendedor)
        {
            Vendedores.Remove(vendedor);
        }
        public string ListarVendedores()
        {
            return Vendedores.Aggregate("", (current, vendedor) => current + (vendedor.ListarInfosVendedor() + "\n"));
        }
    }
}