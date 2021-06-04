using VIPER.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VIPER.Infrastructure.Mapping
{
    public class PerfilMapping : EntityTypeConfiguration<Perfil>
    {
        public PerfilMapping()
        {
            ToTable("Perfil");
            HasKey(c => c.Id);
			Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Descricao).HasMaxLength(60).IsRequired();
            HasMany(c => c.Usuario).WithMany(c => c.Perfil);
            Ignore(c => c.QuantidadeFuncoes);
        }
    }
}
