using VIPER.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VIPER.Infrastructure.Mapping
{
    public class RelatorioMapping : EntityTypeConfiguration<Relatorio>
    {
        public RelatorioMapping()
        {
            ToTable("Relatorio");
            HasKey(c => c.Id);
			Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Codigo).HasMaxLength(20).IsRequired();
            Property(c => c.Nome).HasMaxLength(80).IsRequired();
            Property(c => c.Origem).HasMaxLength(1).IsRequired();
            Property(c => c.Tamanho).IsRequired();
            Property(c => c.Modificado).IsRequired();
            Property(c => c.Modelo).IsMaxLength();
            Property(c => c.Parametro).IsMaxLength();
            Property(c => c.Matricial).IsRequired();
            Property(c => c.QuebraPagina).IsRequired();
            Property(c => c.GraficoTexto).IsRequired();
            Property(c => c.LinhaBranco).IsRequired();
            Property(c => c.Visualizar).IsRequired();
            Property(c => c.EscalaX).IsRequired();
            Property(c => c.EscalaY).IsRequired();
        }
    }
}
