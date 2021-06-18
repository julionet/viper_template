using VIPER.Modules.ParametroEdicao.Interfaces;
using VIPER.Service;

namespace VIPER.Modules.ParametroEdicao.Interactors
{
    public class ParametroEdicaoInteractor : IPresenterToInteractorParametroEdicao
    {
        public IInteractorToPresenterParametroEdicao presenter;

        public void ExecutarSQL(string sql)
        {
            if (!string.IsNullOrWhiteSpace(sql))
            {
                var dados = Servicos.databaseService.ExecutarSQL(sql);
                if (dados.Count != 0)
                    presenter.ExecutarSQLSucesso(dados);
                else
                    presenter.ExecutarSQLFalha();
            } 
            else
            {
                presenter.ExecutarSQLFalha();
            }
        }
    }
}
