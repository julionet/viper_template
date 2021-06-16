using VIPER.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VIPER.Infrastructure.Mapping
{
    public class ParametroUsuarioMapping : EntityTypeConfiguration<ParametroUsuario>
    {
        public ParametroUsuarioMapping()
        {
            ToTable("ParametroUsuario");
            HasKey(c => c.Id);
			Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.ParametroId).IsRequired();
            Property(c => c.UsuarioId).IsRequired();
            Property(c => c.Valor).IsMaxLength();
            HasRequired(c => c.Parametro).WithMany(c => c.ParametroUsuario).HasForeignKey(c => c.ParametroId);
            HasRequired(c => c.Usuario).WithMany(c => c.ParametroUsuario).HasForeignKey(c => c.UsuarioId);
        }
    }
}
