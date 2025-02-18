using Microsoft.EntityFrameworkCore;
using ProjetoGamer.Models;

namespace ProjetoGamer.Infra
{
    public class Context : DbContext
    {
        public Context() { }

        public Context(DbContextOptions<Context> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source = note03-s15; initial catalog = gamerTarde; User Id = sa; pwd = Senai@134; TrustServerCertificate = true"
                );
            }
        }

        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Equipe> Equipe { get; set; }
    }
}
