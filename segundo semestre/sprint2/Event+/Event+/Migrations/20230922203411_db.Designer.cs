﻿// <auto-generated />
using System;
using Event_.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Event_.Migrations
{
    [DbContext(typeof(Event_Context))]
    [Migration("20230922203411_db")]
    partial class db
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Event_.Domains.ComentarioEvento", b =>
                {
                    b.Property<Guid>("IdComentarioEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<bool>("Exibe")
                        .HasColumnType("BIT");

                    b.Property<Guid>("IdEvento")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdComentarioEvento");

                    b.HasIndex("IdEvento");

                    b.HasIndex("IdUsuario");

                    b.ToTable("ComentarioEvento");
                });

            modelBuilder.Entity("Event_.Domains.Evento", b =>
                {
                    b.Property<Guid>("IdEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataEvento")
                        .HasColumnType("DATE");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IdInstituicao")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTipoDeEvento")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeEvento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdEvento");

                    b.HasIndex("IdInstituicao");

                    b.HasIndex("IdTipoDeEvento");

                    b.ToTable("Evento");
                });

            modelBuilder.Entity("Event_.Domains.Instituicao", b =>
                {
                    b.Property<Guid>("IdInstituicao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("VARCHAR(14)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdInstituicao");

                    b.ToTable("Instituicao");
                });

            modelBuilder.Entity("Event_.Domains.PresencaEvento", b =>
                {
                    b.Property<Guid>("IdPresencaEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdEvento")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Situacao")
                        .HasColumnType("BIT");

                    b.HasKey("IdPresencaEvento");

                    b.HasIndex("IdEvento");

                    b.HasIndex("IdUsuario");

                    b.ToTable("PresencaEvento");
                });

            modelBuilder.Entity("Event_.Domains.TipoEvento", b =>
                {
                    b.Property<Guid>("IdTipoDeEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdTipoDeEvento");

                    b.ToTable("TipoEvento");
                });

            modelBuilder.Entity("Event_.Domains.TipoUsuario", b =>
                {
                    b.Property<Guid>("IdTipoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdTipoUsuario");

                    b.ToTable("TipoUsuario");
                });

            modelBuilder.Entity("Event_.Domains.Usuario", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<Guid>("IdTipoUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR(60)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdTipoUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Event_.Domains.ComentarioEvento", b =>
                {
                    b.HasOne("Event_.Domains.Evento", "Evento")
                        .WithMany()
                        .HasForeignKey("IdEvento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Event_.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Event_.Domains.Evento", b =>
                {
                    b.HasOne("Event_.Domains.Instituicao", "Instituicao")
                        .WithMany()
                        .HasForeignKey("IdInstituicao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Event_.Domains.TipoEvento", "TipoEvento")
                        .WithMany()
                        .HasForeignKey("IdTipoDeEvento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instituicao");

                    b.Navigation("TipoEvento");
                });

            modelBuilder.Entity("Event_.Domains.PresencaEvento", b =>
                {
                    b.HasOne("Event_.Domains.Evento", "Eventos")
                        .WithMany()
                        .HasForeignKey("IdEvento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Event_.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Eventos");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Event_.Domains.Usuario", b =>
                {
                    b.HasOne("Event_.Domains.TipoEvento", "TipoEvento")
                        .WithMany()
                        .HasForeignKey("IdTipoUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoEvento");
                });
#pragma warning restore 612, 618
        }
    }
}
