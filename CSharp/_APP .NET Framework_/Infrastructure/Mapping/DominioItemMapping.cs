using VIPER.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VIPER.Infrastructure.Mapping
{
    public class DominioItemMapping : EntityTypeConfiguration<DominioItem>
    {
        public DominioItemMapping()
        {
            ToTable("DominioItem");
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Descricao).HasMaxLength(60).IsRequired();
            Property(c => c.Valor).HasMaxLength(10).IsRequired();
            Property(c => c.DominioId).IsRequired();
            HasRequired(c => c.Dominio).WithMany(c => c.DominioItem).HasForeignKey(c => c.DominioId);
        }
    }
}
