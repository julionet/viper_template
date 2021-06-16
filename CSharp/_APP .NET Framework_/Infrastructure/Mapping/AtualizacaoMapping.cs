using VIPER.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VIPER.Infrastructure.Mapping
{
    public class AtualizacaoMapping : EntityTypeConfiguration<Atualizacao>
    {
        public AtualizacaoMapping()
        {
            ToTable("Atualizacao");
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Numero).IsRequired();
            Property(c => c.Data).IsRequired();
            Property(c => c.Descricao).IsRequired();
            Property(c => c.Versao).HasMaxLength(20).IsRequired();
            Property(c => c.Banco).HasMaxLength(1).IsRequired();
            Property(c => c.Sql);
            Property(c => c.SqlProcedimento).IsRequired();
            Property(c => c.Status).HasMaxLength(1).IsRequired();
            Property(c => c.Mensagem);
            Property(c => c.Obrigatorio).IsRequired();
        }
    }
}