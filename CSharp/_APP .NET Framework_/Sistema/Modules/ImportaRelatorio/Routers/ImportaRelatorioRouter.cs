using VIPER.Modules.ImportaRelatorio.Interactors;
using VIPER.Modules.ImportaRelatorio.Interfaces;
using VIPER.Modules.ImportaRelatorio.Presenters;
using VIPER.Modules.ImportaRelatorio.Views;
using System.Windows.Forms;

namespace VIPER.Modules.ImportaRelatorio.Routers
{
    public class ImportaRelatorioRouter : IPresenterToRouterImportaRelatorio
    {
        public static Form New(int funcao)
        {
            return new ImportaRelatorioRouter().LoadModule(funcao);
        }

        private Form LoadModule(int funcao)
        {
            ImportaRelatorioPresenter presenter = new ImportaRelatorioPresenter();
            ImportaRelatorioInteractor interactor = new ImportaRelatorioInteractor();
            ImportaRelatorioRouter router = new ImportaRelatorioRouter();
            ImportaRelatorioView form = new ImportaRelatorioView(funcao);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
