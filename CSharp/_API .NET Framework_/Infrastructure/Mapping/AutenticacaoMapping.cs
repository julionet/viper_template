using VIPER.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VIPER.Infrastructure.Mapping
{
    public class AutenticacaoMapping : EntityTypeConfiguration<Autenticacao>
    {
        public AutenticacaoMapping()
        {
            ToTable("Autenticacao");
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Usuario).HasMaxLength(80).IsRequired();
            Property(c => c.Senha).HasMaxLength(80).IsRequired();
        }
    }
}
