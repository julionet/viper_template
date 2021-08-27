using VIPER.Entity;
using VIPER.Modules.GeradorRelatorioManutencao.Interfaces;
using VIPER.Service;

namespace VIPER.Modules.GeradorRelatorioManutencao.Interactors
{
    public class GeradorRelatorioManutencaoInteractor : IPresenterToInteractorGeradorRelatorioManutencao
    {
        public IInteractorToPresenterGeradorRelatorioManutencao presenter;

        public void Salvar(Relatorio entity)
        {
            var mensagem = Servicos.relatorioService.Salvar(entity);
            if (mensagem != "")
                presenter.SalvarFalha(mensagem);
            else
                presenter.SalvarSucesso();
        }
    }
}
