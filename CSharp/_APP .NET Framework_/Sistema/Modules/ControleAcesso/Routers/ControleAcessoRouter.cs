using Chronus.App.Modules.ControleAcesso.Interactors;
using Chronus.App.Modules.ControleAcesso.Interfaces;
using Chronus.App.Modules.ControleAcesso.Presenters;
using Chronus.App.Modules.ControleAcesso.Views;
using System.Windows.Forms;

namespace Chronus.App.Modules.ControleAcesso.Routers
{
    public class ControleAcessoRouter : IPresenterToRouterControleAcesso
    {
        public static Form New(int funcao)
        {
            return new ControleAcessoRouter().LoadModule(funcao);
        }

        private Form LoadModule(int funcao)
        {
            ControleAcessoPresenter presenter = new ControleAcessoPresenter();
            ControleAcessoInteractor interactor = new ControleAcessoInteractor();
            ControleAcessoRouter router = new ControleAcessoRouter();
            ControleAcessoView form = new ControleAcessoView(funcao);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
