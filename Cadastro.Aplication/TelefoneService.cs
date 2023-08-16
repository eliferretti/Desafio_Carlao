using AutoMapper;
using Cadastro.Aplication.Contratos;
using Cadastro.Aplication.Dtos;
using Cadastro.Persistence.Contratos;
using System.Threading.Tasks;

namespace Cadastro.Aplication
{
    public class TelefoneService : ITelefoneService
    {
        private readonly IGenericPersist _genericPersist;
        private readonly ITelefonePersist _telefonePersist;
        private readonly IMapper _mapper;

        public TelefoneService(IGenericPersist genericPersist,
                             ITelefonePersist telefonePersist,
                             IMapper mapper)
        {
            _mapper = mapper;
            _genericPersist = genericPersist;
            _telefonePersist = telefonePersist;
        }

        public Task<bool> DeleteTelefone(int idPessoa, int idTelefone)
        {
            throw new System.NotImplementedException();
        }

        public Task<TelefoneDto[]> FetchTelefonesByIdPessoa(int idPessoa)
        {
            throw new System.NotImplementedException();
        }

        public Task<TelefoneDto[]> SaveTelefones(int idPessoa, TelefoneDto[] models)
        {
            throw new System.NotImplementedException();
        }

        public Task<TelefoneDto> UpdateTelefone(int id, TelefoneDto model)
        {
            throw new System.NotImplementedException();
        }
    }
}
