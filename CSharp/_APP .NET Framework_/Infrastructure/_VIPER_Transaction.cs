using System.Data;
using System.Data.Entity;

namespace VIPER.Infrastructure
{
    public class _VIPER_Transaction
    {
        private _VIPER_Transaction()
        {

        }

        public static DbContextTransaction CreateDbContextTransaction(_VIPER_Context db)
        {
            return db.Database.BeginTransaction(IsolationLevel.ReadUncommitted);
        }
    }
}
