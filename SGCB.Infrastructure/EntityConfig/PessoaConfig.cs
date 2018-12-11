using Microsoft.EntityFrameworkCore;
using SGCB.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCB.Infrastructure.EntityConfig
{
    public class PessoaConfig : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Pessoa> builder)
        {

            #region Configurancao do Pessoa


            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)");
            builder.Property(x => x.CPF)
                .HasColumnType("varchar(11)");

            builder.Property(x => x.Email)
                .HasColumnType("varchar(50)");

            #endregion
        }



    }
}
