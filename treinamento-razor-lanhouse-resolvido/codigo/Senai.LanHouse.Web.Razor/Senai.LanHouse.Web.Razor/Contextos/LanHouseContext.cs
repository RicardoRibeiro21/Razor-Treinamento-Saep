using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Senai.LanHouse.Web.Razor.Dominios;

namespace Senai.LanHouse.Web.Razor.Contextos
{
    public partial class LanHouseContext : DbContext
    {
        public LanHouseContext()
        {
        }

        public LanHouseContext(DbContextOptions<LanHouseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Defeito> Defeito { get; set; } 
        public virtual DbSet<Equipamento> Equipamento { get; set; }
        public virtual DbSet<TipoDefeito> TipoDefeito { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {                
                optionsBuilder.UseSqlServer("Server=LAB08DESK1401\\SQLEXPRESS02;Database=Lan_House; User Id=sa; pwd=info@132");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Defeito>(entity =>
            {
                entity.Property(e => e.DefeitoId).HasColumnName("defeitoId");

                entity.Property(e => e.DataDefeito).HasColumnName("dataDefeito");

                entity.Property(e => e.EquipamentoId).HasColumnName("equipamentoId");

                entity.Property(e => e.Observacao)
                    .IsRequired()
                    .HasColumnName("observacao")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDefeitoId).HasColumnName("tipoDefeitoId");

                entity.HasOne(d => d.Equipamento)
                    .WithMany(p => p.Defeito)
                    .HasForeignKey(d => d.EquipamentoId)
                    .HasConstraintName("FK__Defeito__equipam__440B1D61");

                entity.HasOne(d => d.TipoDefeito)
                    .WithMany(p => p.Defeito)
                    .HasForeignKey(d => d.TipoDefeitoId)
                    .HasConstraintName("FK__Defeito__tipoDef__4316F928");
            });

            modelBuilder.Entity<Equipamento>(entity =>
            {
                entity.Property(e => e.EquipamentoId).HasColumnName("equipamentoId");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoDefeito>(entity =>
            {
                entity.Property(e => e.TipoDefeitoId).HasColumnName("tipoDefeitoId");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("senha")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
