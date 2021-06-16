using VIPER.Modules.Usuario.Interactors;
using VIPER.Modules.Usuario.Interfaces;
using VIPER.Modules.Usuario.Presenters;
using VIPER.Modules.Usuario.Views;
using System.Windows.Forms;

namespace VIPER.Modules.Usuario.Routers
{
    public class UsuarioRouter : IPresenterToRouterUsuario
    {
        public static Form New(int funcao)
        {
            return new UsuarioRouter().LoadModule(funcao);
        }

        private Form LoadModule(int funcao)
        {
            UsuarioPresenter presenter = new UsuarioPresenter();
            UsuarioInteractor interactor = new UsuarioInteractor();
            UsuarioRouter router = new UsuarioRouter();
            UsuarioView form = new UsuarioView(funcao);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
