namespace Exercicio_Salario
{
    public class Empresa(string cnpj, string nome)
    {
        public string Cnpj { get; private set; } = cnpj;
        public string Nome { get; private set; } = nome;
        public List<Vendedor> Vendedores { get; set; } = [];

        public void AdicionarVendedor(Vendedor vendedor)
        {
            try 
            {
                Vendedores.Add(vendedor);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao adicionar vendedor", e);
            }
        }
        public void RemoverVendedor(Vendedor vendedor)
        {
            try
            {
                Vendedores.Remove(vendedor);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao remover vendedor", e);
            }
        }
        public string ListarVendedores()
        {
            try 
            {
                var listaVendedores = "";
                foreach (var vendedor in Vendedores)
                {
                    listaVendedores += vendedor.ListarInfosVendedor() + "\n";
                }
                return listaVendedores;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao listar vendedores", e);
            }
        }
    }
}