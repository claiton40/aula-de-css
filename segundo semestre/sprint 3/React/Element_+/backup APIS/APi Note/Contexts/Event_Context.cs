﻿using Microsoft.EntityFrameworkCore;
using webapi.event_.Domains;

namespace webapi.event_.Contexts
{
    /// <summary>
    /// Classe de contexto que faz referências as tabelas e define string de conexão
    /// </summary>
    public class Event_Context : DbContext
    {
        public DbSet<TiposUsuario> TiposUsuario { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<TiposEvento> TiposEvento { get; set; }

        public DbSet<Evento> Evento { get; set; }

        public DbSet<ComentariosEvento> ComentariosEvento{ get; set; }

        public DbSet<Instituicao> Instituicao { get; set; }

        public DbSet<PresencasEvento> PresencasEvento { get; set; }

        /// <summary>
        /// Define as opções de construção do banco
        /// </summary>
        /// <param name="optionsBuilder">Objeto com as configurações definidas</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // string da JABIRACA: Server=Jabiraca\SQLEXPRESS; Database=EventPlusDoClaitinho; Integrated Security=True; TrustServerCertificate=true;
            // string do SENAI: Server=note01-s14; Database=EventPlusDoClaitinho; User Id= sa; Pwd = Senai@134; TrustServerCertificate=true; 
            // string do NOTEBOOK: Server=Claiton2; Database=EventPlusDoClaitinho; Integrated Security=True; TrustServerCertificate=true;
            optionsBuilder.UseSqlServer("Server=Claiton2; Database=EventPlusDoClaitinho; Integrated Security=True; TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
            // COMANDOS PRA CRIAR MIGRATIONS E BANCO DENTRO DO CONSOLE DO NUGET:
            // Add-Migration <NOME DO BANCO>
            // Update - Database
        }
    }
}
