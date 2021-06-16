using VIPER.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VIPER.Infrastructure.Mapping
{
    public class BloqueioMapping : EntityTypeConfiguration<Bloqueio>
    {
        public BloqueioMapping()
        {
            ToTable("Bloqueio");
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Classe).HasMaxLength(60).IsRequired();
            Property(c => c.Usuario).HasMaxLength(60).IsRequired();
            Property(c => c.Computador).HasMaxLength(60).IsRequired();
            Property(c => c.DataHora).IsRequired();
            Property(c => c.Referencia).IsRequired();
        }
    }
}
