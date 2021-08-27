using VIPER.Entity;
using VIPER.Modules.ImportaRelatorio.Interfaces;
using VIPER.Service;

namespace VIPER.Modules.ImportaRelatorio.Interactors
{
    public class ImportaRelatorioInteractor : IPresenterToInteractorImportaRelatorio
    {
        public IInteractorToPresenterImportaRelatorio presenter;

        public void Importar(Relatorio[] entity)
        {
            var mensagem = Servicos.relatorioService.Importar(entity);
            if (mensagem != "")
                presenter.ImportarSucesso();
            else
                presenter.ImportarFalha(mensagem);
        }
    }
}
