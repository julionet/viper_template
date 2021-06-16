//
//  __MODULENAME__Mapping.cs
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

using NAMESPACE.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NAMESPACE.Database.Mapping
{
    public class VIPERMapping : IEntityTypeConfiguration<VIPER>
    {
        public void Configure(EntityTypeBuilder<VIPER> builder)
        {
            builder.ToTable("VIPER");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
        }
    }
}
