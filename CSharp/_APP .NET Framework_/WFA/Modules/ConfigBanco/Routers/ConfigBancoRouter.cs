using VIPER.Modules.ConfigBanco.Interactors;
using VIPER.Modules.ConfigBanco.Interfaces;
using VIPER.Modules.ConfigBanco.Presenters;
using VIPER.Modules.ConfigBanco.Views;
using System.Windows.Forms;

namespace VIPER.Modules.ConfigBanco.Routers
{
    public class ConfigBancoRouter : IPresenterToRouterConfigBanco
    {
        public static Form New()
        {
            return new ConfigBancoRouter().LoadModule();
        }

        private Form LoadModule()
        {
            ConfigBancoPresenter presenter = new ConfigBancoPresenter();
            ConfigBancoInteractor interactor = new ConfigBancoInteractor();
            ConfigBancoRouter router = new ConfigBancoRouter();
            ConfigBancoView form = new ConfigBancoView();
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
