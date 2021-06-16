using VIPER.Modules.ImportaRelatorio.Interactors;
using VIPER.Modules.ImportaRelatorio.Interfaces;
using VIPER.Modules.ImportaRelatorio.Presenters;
using VIPER.Modules.ImportaRelatorio.Views;
using System.Windows.Forms;

namespace VIPER.Modules.ImportaRelatorio.Routers
{
    public class ImportaRelatorioRouter : IPresenterToRouterImportaRelatorio
    {
        public static Form New()
        {
            return new ImportaRelatorioRouter().LoadModule();
        }

        private Form LoadModule()
        {
            ImportaRelatorioPresenter presenter = new ImportaRelatorioPresenter();
            ImportaRelatorioInteractor interactor = new ImportaRelatorioInteractor();
            ImportaRelatorioRouter router = new ImportaRelatorioRouter();
            ImportaRelatorioView form = new ImportaRelatorioView();
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
