using Microsoft.EntityFrameworkCore;
using Senai.Saep.Web.Razor.Dominios;

namespace Senai.Saep.Web.Razor.Contextos
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

        public virtual DbSet<Equipamentos> Equipamentos { get; set; }
        public virtual DbSet<RegistrosDefeitos> RegistrosDefeitos { get; set; }
        public virtual DbSet<TiposDefeitos> TiposDefeitos { get; set; }
        public virtual DbSet<TiposEquipamentos> TiposEquipamentos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Lan_House;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Equipamentos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TipoEquipamentoId).HasColumnName("Tipo_Equipamento_ID");

                entity.HasOne(d => d.TipoEquipamento)
                    .WithMany(p => p.Equipamentos)
                    .HasForeignKey(d => d.TipoEquipamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Equipamen__Tipo___145C0A3F");
            });

            modelBuilder.Entity<RegistrosDefeitos>(entity =>
            {
                entity.ToTable("Registros_Defeitos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataDefeito).HasColumnName("Data_Defeito");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDefeitoId).HasColumnName("Tipo_Defeito_Id");

                entity.Property(e => e.TipoEquipamentoId).HasColumnName("Tipo_Equipamento_Id");

                entity.HasOne(d => d.TipoDefeito)
                    .WithMany(p => p.RegistrosDefeitos)
                    .HasForeignKey(d => d.TipoDefeitoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Registros__Tipo___182C9B23");

                entity.HasOne(d => d.TipoEquipamento)
                    .WithMany(p => p.RegistrosDefeitos)
                    .HasForeignKey(d => d.TipoEquipamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Registros__Tipo___173876EA");
            });

            modelBuilder.Entity<TiposDefeitos>(entity =>
            {
                entity.ToTable("Tipos_Defeitos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposEquipamentos>(entity =>
            {
                entity.ToTable("Tipos_Equipamentos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
