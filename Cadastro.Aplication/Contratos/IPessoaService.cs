using Cadastro.Aplication.Dtos;
using System.Threading.Tasks;

namespace Cadastro.Aplication.Contratos
{
    public interface IPessoaService
    {
        Task<PessoaDto> AddPessoa(PessoaDto model);
        Task<PessoaDto> UpdatePessoa(int id, PessoaDto model);
        Task<bool> DeletePessoa(int id);
        Task<PessoaDto[]> FetchAllPessoasAsync();
        Task<PessoaDto> GetPessoaByCpf(string cpf);
        Task<PessoaDto[]> FetchPessoasByNomeLike(string nomeLike);
    }
}
