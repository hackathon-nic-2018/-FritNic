namespace FritNic.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FritangaNic : DbContext
    {
        public FritangaNic()
            : base("name=FritangaNic")
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<DetalleValoracion> DetalleValoracion { get; set; }
        public virtual DbSet<Fritanga> Fritanga { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Municipio> Municipio { get; set; }
        public virtual DbSet<PlatillosNegocio> PlatillosNegocio { get; set; }
        public virtual DbSet<Propietario> Propietario { get; set; }
        public virtual DbSet<Valoracion> Valoracion { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.Menu)
                .WithRequired(e => e.Categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Departamento>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Departamento>()
                .HasMany(e => e.Municipio)
                .WithRequired(e => e.Departamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Fritanga>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Fritanga>()
                .Property(e => e.PermisoNegocio)
                .IsUnicode(false);

            modelBuilder.Entity<Fritanga>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Fritanga>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Fritanga>()
                .HasMany(e => e.DetalleValoracion)
                .WithRequired(e => e.Fritanga)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Fritanga>()
                .HasMany(e => e.PlatillosNegocio)
                .WithRequired(e => e.Fritanga)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Precio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Menu>()
                .HasMany(e => e.PlatillosNegocio)
                .WithRequired(e => e.Menu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Municipio>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Municipio>()
                .HasMany(e => e.Fritanga)
                .WithRequired(e => e.Municipio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Propietario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Propietario>()
                .Property(e => e.P_Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Propietario>()
                .Property(e => e.S_Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Propietario>()
                .Property(e => e.Cedula)
                .IsUnicode(false);

            modelBuilder.Entity<Propietario>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Propietario>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Propietario>()
                .HasMany(e => e.Fritanga)
                .WithRequired(e => e.Propietario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Propietario>()
                .HasMany(e => e.Municipio)
                .WithRequired(e => e.Propietario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Valoracion>()
                .Property(e => e.valoracion1)
                .IsUnicode(false);

            modelBuilder.Entity<Valoracion>()
                .HasMany(e => e.DetalleValoracion)
                .WithRequired(e => e.Valoracion)
                .WillCascadeOnDelete(false);
        }
    }
}
