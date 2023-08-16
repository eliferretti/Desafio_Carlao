using Cadastro.Domain;
using System.Threading.Tasks;

namespace Cadastro.Persistence.Contratos
{
    public interface ITelefonePersist
    {
        Task<Telefone[]> FetchTelefoneByIdPessoa(int idPessoa);
    }
}
