using VIPER.Modules.Parametro.Interactors;
using VIPER.Modules.Parametro.Interfaces;
using VIPER.Modules.Parametro.Presenters;
using VIPER.Modules.Parametro.Views;
using System.Windows.Forms;

namespace VIPER.Modules.Parametro.Routers
{
    public class ParametroRouter : IPresenterToRouterParametro
    {
        public static Form New(int funcao)
        {
            return new ParametroRouter().LoadModule(funcao);
        }

        private Form LoadModule(int funcao)
        {
            ParametroPresenter presenter = new ParametroPresenter();
            ParametroInteractor interactor = new ParametroInteractor();
            ParametroRouter router = new ParametroRouter();
            ParametroView form = new ParametroView(funcao);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
