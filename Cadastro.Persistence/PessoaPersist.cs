using Cadastro.Domain;
using Cadastro.Persistence.Contextos;
using Cadastro.Persistence.Contratos;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Persistence
{
    public class PessoaPersist : IPessoaPersist
    {
        private readonly CadastroContext _context;
        public PessoaPersist(CadastroContext context)
        {
            _context = context;
        }

        public async Task<Pessoa[]> GetAllPessoas()
        {
            IQueryable<Pessoa> query = _context.Pessoas
                .Include(p => p.Enderecos)
                .Include(p => p.Telefones);

            query = query.AsNoTracking().OrderBy(p => p.NomeCompleto);
            return await query.ToArrayAsync();
        }

        public async Task<Pessoa[]> FetchByNameLike(string nomeLike)
        {
            IQueryable<Pessoa> query = _context.Pessoas
                .Include(p => p.Enderecos)
                .Include(p => p.Telefones);

            query = query.AsNoTracking().OrderBy(p => p.NomeCompleto)
                .Where(p => p.NomeCompleto.Contains(nomeLike));
            return await query.ToArrayAsync();
        }

        public async Task<Pessoa> GetPessoaByCPFAsync(string cpf)
        {
            IQueryable<Pessoa> query = _context.Pessoas
                .Include(p => p.Enderecos)
                .Include(p => p.Telefones);

            query = query.AsNoTracking().OrderBy(p => p.CPF)
                .Where(p => p.CPF == cpf);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<Pessoa> GetPessoaByIdAsync(int id)
        {
            IQueryable<Pessoa> query = _context.Pessoas
                 .Include(p => p.Enderecos)
                 .Include(p => p.Telefones);

            query = query.AsNoTracking().OrderBy(p => p.Id)
                .Where(p => p.Id == id);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<Pessoa[]> FetchAllPessoas()
        {
            IQueryable<Pessoa> query = _context.Pessoas
                .Include(p => p.Enderecos)
                .Include(p => p.Telefones);

            query = query.AsNoTracking().OrderBy(p => p.NomeCompleto);
            return await query.ToArrayAsync();
        }
    }
}
