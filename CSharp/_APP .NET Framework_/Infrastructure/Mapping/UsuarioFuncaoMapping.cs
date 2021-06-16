using VIPER.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VIPER.Infrastructure.Mapping
{
    public class UsuarioFuncaoMapping : EntityTypeConfiguration<UsuarioFuncao>
    {
        public UsuarioFuncaoMapping()
        {
            ToTable("UsuarioFuncao");
            HasKey(c => c.Id);
			Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.UsuarioId).IsRequired();
            Property(c => c.FuncaoId).IsRequired();
            Property(c => c.PermiteIncluir).IsRequired();
            Property(c => c.PermiteAlterar).IsRequired();
            Property(c => c.PermiteExcluir).IsRequired();
            HasRequired(c => c.Usuario).WithMany(c => c.UsuarioFuncao).HasForeignKey(c => c.UsuarioId);
            HasRequired(c => c.Funcao).WithMany(c => c.UsuarioFuncao).HasForeignKey(c => c.FuncaoId);
        }    
    }
}
