using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dominio.entidades
{
    public partial class bdVeterinariaContext : DbContext
    {
        public bdVeterinariaContext()
        {
        }

        public bdVeterinariaContext(DbContextOptions<bdVeterinariaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Gatos> Gatos { get; set; }
        public virtual DbSet<Perros> Perros { get; set; }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-BQNM9J4;Database=bdVeterinaria;Trusted_Connection=True;");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Gatos>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CantidadDientes).HasColumnName("cantidadDientes");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Perros>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CantidadDientes).HasColumnName("cantidadDientes");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(20);
            });
        }
    }
}
