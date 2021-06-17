using VIPER.Modules.PermissaoAcesso.Interactors;
using VIPER.Modules.PermissaoAcesso.Interfaces;
using VIPER.Modules.PermissaoAcesso.Presenters;
using VIPER.Modules.PermissaoAcesso.Views;
using System.Windows.Forms;

namespace VIPER.Modules.PermissaoAcesso.Routers
{
    public class PermissaoAcessoRouter : IPresenterToRouterPermissaoAcesso
    {
        public static Form New(string descricao, bool incluir, bool alterar, bool excluir)
        {
            return new PermissaoAcessoRouter().LoadModule(descricao, incluir, alterar, excluir);
        }

        private Form LoadModule(string descricao, bool incluir, bool alterar, bool excluir)
        {
            PermissaoAcessoPresenter presenter = new PermissaoAcessoPresenter();
            PermissaoAcessoInteractor interactor = new PermissaoAcessoInteractor();
            PermissaoAcessoRouter router = new PermissaoAcessoRouter();
            PermissaoAcessoView form = new PermissaoAcessoView(descricao, incluir, alterar, excluir);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
