using Microsoft.EntityFrameworkCore;
using veiculos.Domains;

namespace veiculos.Contexts
{
    public class Veiculos_Context: DbContext
    {
        public DbSet<Fabricante> Fabricante { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }
      

        /// <summary>
        /// Define as opções de construção do banco
        /// </summary>
        /// <param name="optionsBuilder">Objeto com as configurações definidas</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=note01-s14; Database=veiculos_II; User Id= sa; Pwd = Senai@134; TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
