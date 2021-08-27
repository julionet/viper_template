using VIPER.DTO;
using VIPER.Modules.ParametroEdicao.Interfaces;
using System.Collections.Generic;

namespace VIPER.Modules.ParametroEdicao.Presenters
{
    public class ParametroEdicaoPresenter : IViewToPresenterParametroEdicao, IInteractorToPresenterParametroEdicao
    {
        public IPresenterToInteractorParametroEdicao interactor;
        public IPresenterToRouterParametroEdicao router;
        public IPresenterToViewParametroEdicao view;

        public void ExecutarSQL(string sql)
        {
            interactor.ExecutarSQL(sql);
        }

        public void ExecutarSQLFalha()
        {
            view.ExecutarSQLFalha();
        }

        public void ExecutarSQLSucesso(List<LookupDataSourceDTO> dados)
        {
            view.ExecutarSQLSucesso(dados);
        }
    }
}
