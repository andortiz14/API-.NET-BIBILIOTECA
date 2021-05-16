using System;
using Microsoft.EntityFrameworkCore;
using BibliotecaCore.Entidades;
using BibliotecaInfrasttruture.Data.Configuracion;

namespace BibliotecaInfrasttruture.Data
{
    public partial class BibliotecaContext : DbContext
    {
        public BibliotecaContext()
        {
        }

        public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autores> Autores { get; set; }
        public virtual DbSet<Editoriales> Editoriales { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LibroConfiguracion());
            modelBuilder.ApplyConfiguration(new AutoresConfiguracion());
            modelBuilder.ApplyConfiguration(new EditorialesConfiguracion());
        }

    }
}
