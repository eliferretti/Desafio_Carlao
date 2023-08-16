using Cadastro.Domain;
using Cadastro.Persistence.Contextos;
using Cadastro.Persistence.Contratos;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Persistence
{
    public class TelefonePersist : ITelefonePersist
    {
        private readonly CadastroContext _context;
        public TelefonePersist(CadastroContext context)
        {
            _context = context;
        }

        public async Task<Telefone[]> FetchTelefoneByIdPessoa(int idPessoa)
        {
            IQueryable<Telefone> query = _context.Telefones;
            query = query.AsNoTracking().Where(x => x.IdPessoa == idPessoa);
            return await query.ToArrayAsync();
        }
    }
}
