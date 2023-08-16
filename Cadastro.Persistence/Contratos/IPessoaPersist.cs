using Cadastro.Domain;
using System.Threading.Tasks;

namespace Cadastro.Persistence.Contratos
{
    public interface IPessoaPersist
    {
        // Pessoa
        Task<Pessoa> GetPessoaByCPFAsync(string cpf);
        Task<Pessoa> GetPessoaByIdAsync(int id);
        Task<Pessoa[]> FetchAllPessoas();
        Task<Pessoa[]> FetchByNameLike(string nomeLike);
    }
}
