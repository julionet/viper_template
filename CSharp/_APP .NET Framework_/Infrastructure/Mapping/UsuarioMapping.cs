using VIPER.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VIPER.Infrastructure.Mapping
{
    public class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            ToTable("Usuario");
            HasKey(c => c.Id);
			Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Login).HasMaxLength(25).IsRequired();
            Property(c => c.Nome).HasMaxLength(40);
            Property(c => c.Senha).HasMaxLength(10);
            Property(c => c.Master).IsRequired();
            Property(c => c.Bloqueado).IsRequired();
            Property(c => c.Administrador).IsRequired();
            Property(c => c.NuncaExpira).IsRequired();
            Property(c => c.AlterarSenha).IsRequired();
            Property(c => c.DiasExpirar);
            Property(c => c.DataAlteracao);
            Ignore(c => c.ListaPerfis);
        }
    }
}
