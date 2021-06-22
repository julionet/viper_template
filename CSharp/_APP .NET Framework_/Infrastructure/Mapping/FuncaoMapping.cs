using VIPER.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VIPER.Infrastructure.Mapping
{
    public class FuncaoMapping : EntityTypeConfiguration<Funcao>
    {
        public FuncaoMapping()
        {
            ToTable("Funcao");
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Descricao).HasMaxLength(60).IsRequired();
            Property(c => c.Codigo).HasMaxLength(20).IsRequired();
            Property(c => c.Grupo).HasMaxLength(40);
            Property(c => c.Tipo).HasMaxLength(1).IsRequired();
            Property(c => c.NomeAssembly).HasMaxLength(60);
            Property(c => c.NomeFormulario).HasMaxLength(60);
            Property(c => c.RelatorioId);
            Property(c => c.DashboardId);
            Property(c => c.Manutencao).IsRequired();
            Property(c => c.ModuloId).IsRequired();
            HasOptional(c => c.Relatorio).WithMany(c => c.Funcao).HasForeignKey(c => c.RelatorioId);
            HasOptional(c => c.Dashboard).WithMany(c => c.Funcao).HasForeignKey(c => c.DashboardId);
            HasRequired(c => c.Modulo).WithMany(c => c.Funcao).HasForeignKey(c => c.ModuloId);
            Ignore(c => c.Flag);
        }
    }
}
