using System.Text;
using Exercicio_Salario.Exceptions;

namespace Exercicio_Salario.Models
{
    public class Empresa
    {
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public List<Vendedor> Vendedores { get; init; }
        
        public Empresa()
        {
            Cnpj = "";
            Nome = "";
            Vendedores = [];
        }

        public void AdicionarVendedor(Vendedor vendedor)
        {
            if (vendedor == null)
            {
                throw new ArgumentNullException(nameof(vendedor), "Vendedor não pode ser nulo");
            }

            if (Vendedores.Exists(v => v.Cpf == vendedor.Cpf))
            {
                throw new VendedorCadastradoException("Vendedor já cadastrado");
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
                throw new VendedorNaoEncontradoException("Vendedor não encontrado");
            }

            Vendedores.Remove(vendedor);
        }

        public string ListarVendedores()
        {
            var infosVendedores = new StringBuilder();
            foreach (var vendedor in Vendedores)
            {
                infosVendedores.AppendLine(vendedor.ListarInfosVendedor());
            }
            return infosVendedores.ToString();
        }
    }
}