using BibliotecaCore.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaInfrasttruture.Data.Configuracion
{
    public class EditorialesConfiguracion : IEntityTypeConfiguration<Editoriales>
    {
        public void Configure(EntityTypeBuilder<Editoriales> builder)
        {
            builder.HasKey(e => e.EdtId);

            builder.HasIndex(e => e.EdtId)
                .HasName("PK_Editoriales_EdtId")
                .IsUnique();

            builder.Property(e => e.EdtDireccion)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.EdtEmail)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.EdtNombre)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.EdtTelefono)
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
