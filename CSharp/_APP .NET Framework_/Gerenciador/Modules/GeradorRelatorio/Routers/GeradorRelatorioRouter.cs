using VIPER.Modules.GeradorRelatorio.Interactors;
using VIPER.Modules.GeradorRelatorio.Interfaces;
using VIPER.Modules.GeradorRelatorio.Presenters;
using VIPER.Modules.GeradorRelatorio.Views;
using System.Windows.Forms;

namespace VIPER.Modules.GeradorRelatorio.Routers
{
    public class GeradorRelatorioRouter : IPresenterToRouterGeradorRelatorio
    {
        public static Form New()
        {
            return new GeradorRelatorioRouter().LoadModule();
        }

        private Form LoadModule()
        {
            GeradorRelatorioPresenter presenter = new GeradorRelatorioPresenter();
            GeradorRelatorioInteractor interactor = new GeradorRelatorioInteractor();
            GeradorRelatorioRouter router = new GeradorRelatorioRouter();
            GeradorRelatorioView form = new GeradorRelatorioView();
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
