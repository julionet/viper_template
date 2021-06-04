using VIPER.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VIPER.Infrastructure.Mapping
{
    public class PerfilFuncaoMapping : EntityTypeConfiguration<PerfilFuncao>
    {
        public PerfilFuncaoMapping()
        {
            ToTable("PerfilFuncao");
            HasKey(c => c.Id);
			Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.PerfilId).IsRequired();
            Property(c => c.FuncaoId).IsRequired();
            Property(c => c.PermiteIncluir).IsRequired();
            Property(c => c.PermiteAlterar).IsRequired();
            Property(c => c.PermiteExcluir).IsRequired();
            HasRequired(c => c.Perfil).WithMany(c => c.PerfilFuncao).HasForeignKey(c => c.PerfilId);
            HasRequired(c => c.Funcao).WithMany(c => c.PerfilFuncao).HasForeignKey(c => c.FuncaoId);
        }
    }
}
