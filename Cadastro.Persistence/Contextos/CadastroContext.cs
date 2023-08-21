using Cadastro.Domain;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Persistence.Contextos
{
    public class CadastroContext : DbContext
    {
        public CadastroContext(DbContextOptions<CadastroContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=CADASTRO.db");
        //    //optionsBuilder.UseSqlServer("Server=DESKTOP-M0O6KC2;Database=DB_CADASTRO;Integrated Security=True");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .HasMany(p => p.Enderecos)
                .WithOne(e => e.Pessoa)
                .HasForeignKey(e => e.IdPessoa)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Pessoa>()
               .HasMany(p => p.Telefones)
               .WithOne(e => e.Pessoa)
               .HasForeignKey(e => e.IdPessoa)
               .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
