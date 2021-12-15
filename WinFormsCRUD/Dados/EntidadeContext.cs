using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WinFormsCRUD.Negocio;

namespace WinFormsCRUD.Dados
{
    public class EntidadeContext : DbContext
    {
        public DbSet<Entidade> Entidades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=PC-ATE77\\SQL2008;Initial Catalog=CRUD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidade>().ToTable("entidade");

            modelBuilder.Entity<Entidade>()
                .Property(c => c.Id)
                .HasColumnName("codigo")                
                .IsRequired();

            modelBuilder.Entity<Entidade>()
                .Property(n => n.Nome)
                .HasColumnName("nome")
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Entidade>()
                .Property(l => l.Logradouro)
                .HasColumnName("logradouro")
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Entidade>()
                .Property(c => c.Cep)
                .HasColumnName("cep")
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Entidade>()
                .Property(b => b.Bairro)
                .HasColumnName("bairro")
                .HasColumnType("varchar(100)");

            modelBuilder.Entity<Entidade>()
                .Property(c => c.Cidade)
                .HasColumnName("cidade")
                .HasColumnType("varchar(100)");

            modelBuilder.Entity<Entidade>()
                .Property(u => u.Uf)
                .HasColumnName("uf")
                .HasColumnType("varchar(100)");

            modelBuilder.Entity<Entidade>()
                .Property(t => t.Telefone)
                .HasColumnName("telefone")
                .HasColumnType("varchar(100)");
        }

       
    }
}
