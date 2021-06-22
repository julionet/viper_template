using VIPER.Entity;
using VIPER.Modules.GeradorRelatorioManutencao.Interfaces;

namespace VIPER.Modules.GeradorRelatorioManutencao.Presenters
{
    public class GeradorRelatorioManutencaoPresenter : IViewToPresenterGeradorRelatorioManutencao, IInteractorToPresenterGeradorRelatorioManutencao
    {
        public IPresenterToInteractorGeradorRelatorioManutencao interactor;
        public IPresenterToRouterGeradorRelatorioManutencao router;
        public IPresenterToViewGeradorRelatorioManutencao view;

        public void Salvar(Relatorio entity)
        {
            interactor.Salvar(entity);
        }

        public void SalvarFalha(string mensagem)
        {
            view.SalvarFalha(mensagem);
        }

        public void SalvarSucesso()
        {
            view.SalvarSucesso();
        }
    }
}
