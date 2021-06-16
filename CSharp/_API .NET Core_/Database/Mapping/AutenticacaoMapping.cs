//
//  AutenticacaoMapping.cs
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

using VIPER.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VIPER.Database.Mapping
{
    public class AutenticacaoMapping : IEntityTypeConfiguration<Autenticacao>
    {
        public void Configure(EntityTypeBuilder<Autenticacao> builder)
        {
            builder.ToTable("Autenticacao");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Usuario).HasMaxLength(80).IsRequired();
            builder.Property(p => p.Senha).HasMaxLength(80).IsRequired();
        }
    }
}
