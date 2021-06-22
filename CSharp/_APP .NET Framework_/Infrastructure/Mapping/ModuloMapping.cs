using VIPER.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VIPER.Infrastructure.Mapping
{
    public class ModuloMapping : EntityTypeConfiguration<Modulo>
    {
        public ModuloMapping()
        {
            ToTable("Modulo");
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Descricao).HasMaxLength(60).IsRequired();
            Property(c => c.Codigo).HasMaxLength(20).IsRequired();
            Property(c => c.Grupo).HasMaxLength(40);
            Property(c => c.Cor).IsRequired();
            Property(c => c.Imagem).IsMaxLength();
            Property(c => c.Administracao).IsRequired();
            Property(c => c.Navegacao).IsRequired();
            Property(c => c.SistemaId).IsRequired();
            HasRequired(c => c.Sistema).WithMany(c => c.Modulo).HasForeignKey(c => c.SistemaId);
            Ignore(c => c.Flag);
            Ignore(c => c.QuantidadeFuncao);
        }
    }
}
