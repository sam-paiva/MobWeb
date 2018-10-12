﻿using MobWeb.Modelo;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MobWeb.Persistencia.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");

            Property(c => c.UsuarioId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Apelido).HasMaxLength(150);

            Property(c => c.Email).HasMaxLength(150).IsRequired();

            Property(c => c.Nome).HasMaxLength(150).IsRequired();

            Property(c => c.Telefone).IsRequired();

        }
    }
}