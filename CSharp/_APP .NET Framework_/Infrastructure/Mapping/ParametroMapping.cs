using VIPER.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VIPER.Infrastructure.Mapping
{
    public class ParametroMapping : EntityTypeConfiguration<Parametro>
    {
        public ParametroMapping()
        {
            ToTable("Parametro");
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Codigo).HasMaxLength(10).IsRequired();
            Property(c => c.Descricao).HasMaxLength(120).IsRequired();
            Property(c => c.Observacao).IsMaxLength();
            Property(c => c.Tipo).HasMaxLength(1).IsRequired();
            Property(c => c.ValorPadrao).IsMaxLength();
            Property(c => c.ValorPersonalizado).IsMaxLength();
            Property(c => c.Lista).IsMaxLength();
            Property(c => c.PermiteUsuario).IsRequired();
            Property(c => c.Categoria).HasMaxLength(3).IsRequired();
        }
    }
}
