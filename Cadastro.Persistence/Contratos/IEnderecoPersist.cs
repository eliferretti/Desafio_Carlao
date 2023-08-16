using Cadastro.Domain;
using System.Threading.Tasks;

namespace Cadastro.Persistence.Contratos
{
    public interface IEnderecoPersist
    {
        Task<Endereco[]> FetchEnderecosByIdPessoa(int idPessoa);
    }
}
