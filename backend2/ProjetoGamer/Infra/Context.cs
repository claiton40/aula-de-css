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
                    "Data Source = NOTE03-S1; initial catalog = gamerTarde; Integrated Security = True; TrustServerCertificate = true"
                );
            }
        }

        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Equipe> Equipe { get; set; }
    }
}
