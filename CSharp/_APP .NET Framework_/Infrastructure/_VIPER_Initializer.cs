using VIPER.Entity;
using System.Data.Entity;
using System.Linq;

namespace VIPER.Infrastructure
{
    public class _VIPER_Initializer : CreateDatabaseIfNotExists<_VIPER_Context>
    {
        protected override void Seed(_VIPER_Context context)
        {
            base.Seed(context);
            InsertAutenticacao(context);
        }

        private void InsertAutenticacao(_VIPER_Context context)
        {
            if (context.Autenticacaos.Count() == 0)
            {
                context.Autenticacaos.Add(new Autenticacao { Usuario = "c8b76359-e3e7-4c08-af66-07428a9204a6", Senha = "1cb474993d9cd2161264579335325ba0" });
                context.SaveChanges();
            }
        }
    }
}
