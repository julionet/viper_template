using VIPER.Entity;
using VIPER.Modules.ImportaRelatorio.Interfaces;
using VIPER.Service;

namespace VIPER.Modules.ImportaRelatorio.Interactors
{
    public class ImportaRelatorioInteractor : IPresenterToInteractorImportaRelatorio
    {
        public IInteractorToPresenterImportaRelatorio presenter;

        public void Importar(Relatorio[] relatorios)
        {
            var mensagem = Servicos.relatorioService.Importar(relatorios);
            if (mensagem != "")
                presenter.ImportarFalha(mensagem);
            else
                presenter.ImportarSucesso();
        }
    }
}
