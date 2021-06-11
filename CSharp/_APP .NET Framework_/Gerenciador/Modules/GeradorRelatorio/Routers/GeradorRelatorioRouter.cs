using VIPER.Modules.GeradorRelatorio.Interactors;
using VIPER.Modules.GeradorRelatorio.Interfaces;
using VIPER.Modules.GeradorRelatorio.Presenters;
using VIPER.Modules.GeradorRelatorio.Views;
using System.Windows.Forms;

namespace VIPER.Modules.GeradorRelatorio.Routers
{
    public class GeradorRelatorioRouter : IPresenterToRouterGeradorRelatorio
    {
        public static Form New(int funcao)
        {
            return new GeradorRelatorioRouter().LoadModule(funcao);
        }

        private Form LoadModule(int funcao)
        {
            GeradorRelatorioPresenter presenter = new GeradorRelatorioPresenter();
            GeradorRelatorioInteractor interactor = new GeradorRelatorioInteractor();
            GeradorRelatorioRouter router = new GeradorRelatorioRouter();
            GeradorRelatorioView form = new GeradorRelatorioView(funcao);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
