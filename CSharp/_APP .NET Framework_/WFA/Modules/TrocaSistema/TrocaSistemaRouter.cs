using VIPER.Modules.TrocaSistema.Interactors;
using VIPER.Modules.TrocaSistema.Interfaces;
using VIPER.Modules.TrocaSistema.Presenters;
using VIPER.Modules.TrocaSistema.Views;
using System.Windows.Forms;

namespace VIPER.Modules.TrocaSistema.Routers
{
    public class TrocaSistemaRouter : IPresenterToRouterTrocaSistema
    {
        public static Form New()
        {
            return new TrocaSistemaRouter().LoadModule();
        }

        private Form LoadModule()
        {
            TrocaSistemaPresenter presenter = new TrocaSistemaPresenter();
            TrocaSistemaInteractor interactor = new TrocaSistemaInteractor();
            TrocaSistemaRouter router = new TrocaSistemaRouter();
            TrocaSistemaView form = new TrocaSistemaView();
            
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
            
            interactor.presenter = presenter;

            return form;
        }
    }
}
