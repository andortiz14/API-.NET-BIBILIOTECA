using BibliotecaCore.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaInfrasttruture.Data
{
    public class LibroConfiguracion : IEntityTypeConfiguration<Libro>
    {
        public void Configure(EntityTypeBuilder<Libro> builder)
        {
           builder.HasKey(e => e.LbrId)
                    .HasName("PK_Libros");

                builder.HasIndex(e => e.LbrId)
                    .HasName("PK_Libros_LbrId")
                    .IsUnique();

                builder.Property(e => e.LbrGenero)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.LbrTitulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.HasOne(d => d.LbrAtr)
                    .WithMany(p => p.Libro)
                    .HasForeignKey(d => d.LbrAtrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Libros__LbrAtrId__2F10007B");

                builder.HasOne(d => d.LbrEdt)
                    .WithMany(p => p.Libro)
                    .HasForeignKey(d => d.LbrEdtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Libros__LbrEdtId__2E1BDC42");
        }
    }
}
