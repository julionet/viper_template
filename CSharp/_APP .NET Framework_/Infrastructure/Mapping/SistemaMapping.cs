using VIPER.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VIPER.Infrastructure.Mapping
{
    public class SistemaMapping : EntityTypeConfiguration<Sistema>
    {
        public SistemaMapping()
        {
            ToTable("Sistema");
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Descricao).HasMaxLength(60).IsRequired();
            Property(c => c.Codigo).HasMaxLength(20).IsRequired();
            Property(c => c.Imagem).IsMaxLength();
            Property(c => c.Tipo).HasMaxLength(1).IsRequired();
            Property(c => c.Interface).HasMaxLength(1).IsRequired();
            Property(c => c.Linha).IsRequired();
            Property(c => c.Tamanho).IsRequired();
            Property(c => c.Gerenciador).IsRequired();
            Property(c => c.Ativo).IsRequired();
            Ignore(c => c.QuantidadeModulo);
        }
    }
}
