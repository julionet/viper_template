using Chronus.App.Modules.Perfil.Interactors;
using Chronus.App.Modules.Perfil.Interfaces;
using Chronus.App.Modules.Perfil.Presenters;
using Chronus.App.Modules.Perfil.Views;
using System.Windows.Forms;

namespace Chronus.App.Modules.Perfil.Routers
{
    public class PerfilRouter : IPresenterToRouterPerfil
    {
        public static Form New(int funcao)
        {
            return new PerfilRouter().LoadModule(funcao);
        }

        private Form LoadModule(int funcao)
        {
            PerfilPresenter presenter = new PerfilPresenter();
            PerfilInteractor interactor = new PerfilInteractor();
            PerfilRouter router = new PerfilRouter();
            PerfilView form = new PerfilView(funcao);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
