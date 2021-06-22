using VIPER.Entity;
using VIPER.Modules.ImportaRelatorio.Interfaces;

namespace VIPER.Modules.ImportaRelatorio.Presenters
{
    public class ImportaRelatorioPresenter : IViewToPresenterImportaRelatorio, IInteractorToPresenterImportaRelatorio
    {
        public IPresenterToInteractorImportaRelatorio interactor;
        public IPresenterToRouterImportaRelatorio router;
        public IPresenterToViewImportaRelatorio view;

        public void Importar(Relatorio[] relatorios)
        {
            interactor.Importar(relatorios);
        }

        public void ImportarFalha(string mensagem)
        {
            view.ImportarFalha(mensagem);
        }

        public void ImportarSucesso()
        {
            view.ImportarSucesso();
        }
    }
}
