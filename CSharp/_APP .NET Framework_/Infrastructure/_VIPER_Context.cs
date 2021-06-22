using VIPER.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;

namespace VIPER.Infrastructure
{
    public class _VIPER_Context : DbContext
    {
        public _VIPER_Context() : base("_VIPER_ConnectionString")
        {
            Database.SetInitializer(new _VIPER_Initializer());
            Database.CommandTimeout = 6000;
            //Database.Log = s => SaveLog(s);

            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (Database.Connection is SqlConnection)
                modelBuilder.Properties<string>().Configure(c => c.HasColumnType("varchar"));

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !string.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

        private void SaveLog(string message)
        {
            string _arquivolog = Path.Combine(Path.GetTempPath(), "EntityFramework.log");
            List<string> log;

            if (File.Exists(_arquivolog))
                log = File.ReadAllLines(_arquivolog).ToList();
            else
                log = new List<string>();

            if (!message.Equals("\r\n"))
                log.Add(message);

            File.WriteAllLines(_arquivolog, log.ToArray());
        }

        public DbSet<Atualizacao> Atualizacaos { get; set; }
        public DbSet<Autenticacao> Autenticacaos { get; set; }
        public DbSet<Bloqueio> Bloqueios { get; set; }
        public DbSet<Dashboard> Dashboards { get; set; }
        public DbSet<Dominio> Dominios { get; set; }
        public DbSet<DominioItem> DominioItems { get; set; }
        public DbSet<Funcao> Funcaos { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Parametro> Parametros { get; set; }
        public DbSet<ParametroUsuario> ParametroUsuarios { get; set; }
        public DbSet<Perfil> Perfils { get; set; }
        public DbSet<PerfilFuncao> PerfilFuncaos { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
        public DbSet<Sequencial> Sequencials { get; set; }
        public DbSet<Sistema> Sistemas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioFuncao> UsuarioFuncaos { get; set; }
    }
}
