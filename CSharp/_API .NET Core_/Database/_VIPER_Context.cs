//
//  _VIPER_Context.cs
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

using VIPER.Database.Mapping;
using VIPER.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace VIPER.Database
{
    public class _VIPER_Context : DbContext
    {
        public _VIPER_Context()
        {
            if (!Database.GetService<IRelationalDatabaseCreator>().Exists())
            {
                Database.EnsureCreated();
                _VIPER_Initialize.Seed(this);
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var provider = configuration.GetSection("AppSettings").GetValue<string>("DatabaseProvider");
            if (provider.Equals("SqlServer"))
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("VIPERConnectionString"));
            else if (provider.Equals("MySql"))
                optionsBuilder.UseMySql(configuration.GetConnectionString("VIPERConnectionString"));
			else if (provider.Equals("Firebird"))
                optionsBuilder.UseFirebird(configuration.GetConnectionString("VIPERConnectionString"));

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AutenticacaoMapping());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Autenticacao> Autenticacaos { get; set; }
    }
}
