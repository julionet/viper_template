using VIPER.Modules.ParametroUsuario.Interactors;
using VIPER.Modules.ParametroUsuario.Interfaces;
using VIPER.Modules.ParametroUsuario.Presenters;
using VIPER.Modules.ParametroUsuario.Views;
using System.Windows.Forms;

namespace VIPER.Modules.ParametroUsuario.Routers
{
    public class ParametroUsuarioRouter : IPresenterToRouterParametroUsuario
    {
        public static Form New(int parametro, string tipocomponente, string lista, string descricaoparametro)
        {
            return new ParametroUsuarioRouter().LoadModule(parametro, tipocomponente, lista, descricaoparametro);
        }

        private Form LoadModule(int parametro, string tipocomponente, string lista, string descricaoparametro)
        {
            ParametroUsuarioPresenter presenter = new ParametroUsuarioPresenter();
            ParametroUsuarioInteractor interactor = new ParametroUsuarioInteractor();
            ParametroUsuarioRouter router = new ParametroUsuarioRouter();
            ParametroUsuarioView form = new ParametroUsuarioView(parametro, tipocomponente, lista, descricaoparametro);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
