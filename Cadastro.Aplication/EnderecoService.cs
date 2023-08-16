using AutoMapper;
using Cadastro.Aplication.Contratos;
using Cadastro.Aplication.Dtos;
using Cadastro.Persistence.Contratos;
using System.Threading.Tasks;

namespace Cadastro.Aplication
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IGenericPersist _genericPersist;
        private readonly IEnderecoPersist _enderecoPersist;
        private readonly IMapper _mapper;

        public EnderecoService(IGenericPersist genericPersist,
                               IEnderecoPersist enderecoPersist,
                               IMapper mapper)
        {
            _mapper = mapper;
            _genericPersist = genericPersist;
            _enderecoPersist = enderecoPersist;
        }

        public Task<bool> DeleteEndereco(int idPessoa, int idEndereco)
        {
            throw new System.NotImplementedException();
        }

        public Task<EnderecoDto[]> FetchEnderecosByIdPessoa(int idPessoa)
        {
            throw new System.NotImplementedException();
        }

        public Task<EnderecoDto[]> SaveEnderecos(int idPessoa, EnderecoDto[] models)
        {
            throw new System.NotImplementedException();
        }

        public Task<EnderecoDto> UpdateEndereco(int id, EnderecoDto model)
        {
            throw new System.NotImplementedException();
        }
    }
}
