using Cadastro.Aplication.Dtos;
using System.Threading.Tasks;

namespace Cadastro.Aplication.Contratos
{
    public interface ITelefoneService
    {
        Task<TelefoneDto[]> SaveTelefones(int idPessoa, TelefoneDto[] models);
        Task<bool> DeleteTelefone(int idPessoa, int idTelefone);
        Task<TelefoneDto[]> FetchTelefonesByIdPessoa(int idPessoa);
        Task<TelefoneDto> UpdateTelefone(int id, TelefoneDto model);
    }
}
