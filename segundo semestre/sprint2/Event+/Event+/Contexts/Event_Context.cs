using Event_.Domains;
using Microsoft.EntityFrameworkCore;

namespace Event_.Contexts
{
    public class Event_Context : DbContext
    {
        public DbSet<TipoUsuario> TipoUsuario { get; set; }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<TipoEvento> TipoEvento { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<ComentarioEvento> ComentarioEvento { get; set; }
        public DbSet<PresencaEvento> PresencaEvento { get; set; }
        public DbSet<Instituicao> Instituicao { get; set; }

        /// <summary>
        /// Define as opções de construção do banco
        /// </summary>
        /// <param name="optionsBuilder">Objeto com as configurações definidas</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=note01-s14; Database=event+Claiton; User Id= sa; Pwd = Senai@134; TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
