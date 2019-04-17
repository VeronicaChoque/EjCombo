using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EjCombo.Repository.Models
{
    public partial class ComboContext : DbContext
    {
        public ComboContext()
        {
        }

        public ComboContext(DbContextOptions<ComboContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agregado> Agregado { get; set; }
        public virtual DbSet<Combo> Combo { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistory { get; set; }
        public virtual DbSet<Gaseosa> Gaseosa { get; set; }
        public virtual DbSet<Hamburguesa> Hamburguesa { get; set; }
        public virtual DbSet<Papas> Papas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseMySql("server=win2012-01;database=combo;user=vchoque;pwd=saratoga");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agregado>(entity =>
            {
                entity.ToTable("agregado");

                entity.HasIndex(e => e.Hamburguesaid)
                    .HasName("IX_Agregado_hamburguesaid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Hamburguesaid)
                    .HasColumnName("hamburguesaid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Hamburguesa)
                    .WithMany(p => p.Agregado)
                    .HasForeignKey(d => d.Hamburguesaid)
                    .HasConstraintName("FK_Agregado_Hamburguesa_hamburguesaid");
            });

            modelBuilder.Entity<Combo>(entity =>
            {
                entity.ToTable("combo");

                entity.HasIndex(e => e.Gaseosaid)
                    .HasName("IX_Combo_gaseosaid");

                entity.HasIndex(e => e.Hamburguesaid)
                    .HasName("IX_Combo_hamburguesaid");

                entity.HasIndex(e => e.Papasid)
                    .HasName("IX_Combo_papasid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Gaseosaid)
                    .HasColumnName("gaseosaid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Hamburguesaid)
                    .HasColumnName("hamburguesaid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Papasid)
                    .HasColumnName("papasid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Gaseosa)
                    .WithMany(p => p.Combo)
                    .HasForeignKey(d => d.Gaseosaid)
                    .HasConstraintName("FK_Combo_Gaseosa_gaseosaid");

                entity.HasOne(d => d.Hamburguesa)
                    .WithMany(p => p.Combo)
                    .HasForeignKey(d => d.Hamburguesaid)
                    .HasConstraintName("FK_Combo_Hamburguesa_hamburguesaid");

                entity.HasOne(d => d.Papas)
                    .WithMany(p => p.Combo)
                    .HasForeignKey(d => d.Papasid)
                    .HasConstraintName("FK_Combo_Papas_papasid");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId).HasColumnType("varchar(95)");

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("varchar(32)");
            });

            modelBuilder.Entity<Gaseosa>(entity =>
            {
                entity.ToTable("gaseosa");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Tamanio)
                    .IsRequired()
                    .HasColumnName("tamanio")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<Hamburguesa>(entity =>
            {
                entity.ToTable("hamburguesa");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<Papas>(entity =>
            {
                entity.ToTable("papas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Tamanio)
                    .IsRequired()
                    .HasColumnName("tamanio")
                    .HasColumnType("longtext");
            });
        }
    }
}
