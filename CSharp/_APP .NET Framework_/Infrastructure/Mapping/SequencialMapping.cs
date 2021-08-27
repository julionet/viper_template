using VIPER.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VIPER.Infrastructure.Mapping
{
    public class SequencialMapping : EntityTypeConfiguration<Sequencial>
    {
        public SequencialMapping()
        {
            ToTable("Sequencial");
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasMaxLength(60).IsRequired();
            Property(c => c.Valor).IsRequired();
        }
    }
}
