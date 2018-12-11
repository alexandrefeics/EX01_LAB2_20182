using Microsoft.EntityFrameworkCore;
using SGCB.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCB.Infrastructure.EntityConfig
{

    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Endereco> builder)
        {

            #region Configurancao do Endereco



            builder.Property(x => x.Bairro)
                .HasColumnType("varchar(80)");
            builder.Property(x => x.CEP)
               .HasColumnType("varchar(30)");
            builder.Property(x => x.Numero)
               .HasColumnType("varchar(40)");
            builder.Property(x => x.Logradouro)
               .HasColumnType("varchar(200)");

            #endregion
        }
    }
}
