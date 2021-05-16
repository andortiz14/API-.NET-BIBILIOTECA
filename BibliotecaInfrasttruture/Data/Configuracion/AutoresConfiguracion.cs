using BibliotecaCore.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaInfrasttruture.Data
{
    public class AutoresConfiguracion : IEntityTypeConfiguration<Autores>
    {
        public void Configure(EntityTypeBuilder<Autores> builder)
        {
            builder.HasKey(e => e.AtrId);

            builder.HasIndex(e => e.AtrId)
                .HasName("PK_Autores_AtrId")
                .IsUnique();

            builder.Property(e => e.AtrCiudad)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.AtrEmail)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.AtrFechaNacimiento).HasColumnType("datetime");

            builder.Property(e => e.AtrNombre)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
