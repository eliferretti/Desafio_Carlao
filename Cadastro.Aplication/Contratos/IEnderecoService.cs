using Cadastro.Aplication.Dtos;
using System.Threading.Tasks;

namespace Cadastro.Aplication.Contratos
{
    public interface IEnderecoService
    {
        Task<EnderecoDto[]> SaveEnderecos(int idPessoa, EnderecoDto[] models);
        Task<bool> DeleteEndereco(int idPessoa, int idEndereco);
        Task<EnderecoDto[]> FetchEnderecosByIdPessoa(int idPessoa);
        Task<EnderecoDto> UpdateEndereco(int id, EnderecoDto model);
    }
}
