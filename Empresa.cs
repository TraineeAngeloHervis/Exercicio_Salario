using System.Text;

namespace Exercicio_Salario
{
    public class Empresa(string cnpj, string nome)
    {
        public string Cnpj { get; private set; } = cnpj;
        public string Nome { get; private set; } = nome;
        public List<Vendedor> Vendedores { get; set; } = [];

        public void AdicionarVendedor(Vendedor vendedor)
        {
            if (vendedor == null)
            {
                throw new ArgumentNullException(nameof(vendedor), "Vendedor não pode ser nulo");
            }

            if (Vendedores.Exists(v => v.Cpf == vendedor.Cpf))
            {
                throw new InvalidOperationException("Vendedor já cadastrado");
            }

            Vendedores.Add(vendedor);
        }
        public void RemoverVendedor(Vendedor vendedor)
        {
            if (vendedor == null)
            {
                throw new ArgumentNullException(nameof(vendedor), "Vendedor não pode ser nulo");
            }
    
            if (!Vendedores.Contains(vendedor))
            {
                throw new InvalidOperationException("Vendedor não encontrado");
            }

            Vendedores.Remove(vendedor);
        }

        public string ListarVendedores()
        {
            var infosVendedores = new StringBuilder();
            foreach (var vendedor in Vendedores)
            {
                infosVendedores.Append(vendedor.ListarInfosVendedor());
            }
            return infosVendedores.ToString();
        }
    }
}