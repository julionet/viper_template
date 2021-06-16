using VIPER.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VIPER.Infrastructure.Mapping
{
    public class DashboardMapping : EntityTypeConfiguration<Dashboard>
    {
        public DashboardMapping()
        {
            ToTable("Dashboard");
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasMaxLength(80).IsRequired();
            Property(c => c.Xml).IsMaxLength();
        }
    }
}
