using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCB.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCB.Infrastructure.EntityConfig
{

    public class TipoContaConfig : IEntityTypeConfiguration<TipoConta>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TipoConta> builder)
        {

            #region Configurancao do TipoConta



            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(500)");
          
            #endregion
        }

  
        
    }
}
