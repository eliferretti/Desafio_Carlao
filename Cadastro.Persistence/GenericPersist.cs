using Cadastro.Persistence.Contextos;
using Cadastro.Persistence.Contratos;
using System.Threading.Tasks;

namespace Cadastro.Persistence
{
    public class GenericPersist : IGenericPersist
    {
        private readonly CadastroContext _context;
        public GenericPersist(CadastroContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(T[] entity) where T : class
        {
           _context.RemoveRange(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
