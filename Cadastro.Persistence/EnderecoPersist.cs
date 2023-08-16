using Cadastro.Domain;
using Cadastro.Persistence.Contextos;
using Cadastro.Persistence.Contratos;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Persistence
{
    public class EnderecoPersist : IEnderecoPersist
    {
        private readonly CadastroContext _context;
        public EnderecoPersist(CadastroContext context) 
        {
            _context = context; 
        }

        public async Task<Endereco[]> FetchEnderecosByIdPessoa(int idPessoa)
        {
            IQueryable<Endereco> query = _context.Enderecos;
            query = query.AsNoTracking().Where(x => x.IdPessoa == idPessoa);
            return await query.ToArrayAsync();
        }
    }
}
