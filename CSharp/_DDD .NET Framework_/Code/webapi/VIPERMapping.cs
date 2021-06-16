using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NAMESPACE.Entity;

namespace NAMESPACE.Infrastructure.Mapping
{
    public class VIPERMapping : EntityTypeConfiguration<VIPER>
    {
        public VIPERMapping()
        {
            ToTable("VIPER");
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
