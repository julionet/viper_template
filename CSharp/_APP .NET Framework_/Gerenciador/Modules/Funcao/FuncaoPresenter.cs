using VIPER.DTO;
using VIPER.Entity;
using VIPER.Modules.Funcao.Interfaces;
using System.Collections.Generic;

namespace VIPER.Modules.Funcao.Presenters
{
    public class FuncaoPresenter : IViewToPresenterFuncao, IInteractorToPresenterFuncao
    {
        public IPresenterToInteractorFuncao interactor;
        public IPresenterToRouterFuncao router;
        public IPresenterToViewFuncao view;

        public void SelecionarDashboardas()
        {
            interactor.SelecionarDashboardas();
        }

        public void SelecionarDashboardasFalha()
        {
            view.SelecionarDashboardasFalha();
        }

        public void SelecionarDashboardasSucesso(List<Dashboard> dados)
        {
            view.SelecionarDashboardasSucesso(dados);
        }

        public void SelecionarRelatorios()
        {
            interactor.SelecionarRelatorios();
        }

        public void SelecionarRelatoriosFalha()
        {
            view.SelecionarRelatoriosFalha();
        }

        public void SelecionarRelatoriosSucesso(List<RelatorioRetornoDTO> dados)
        {
            view.SelecionarRelatoriosSucesso(dados);
        }

        public void Validar(Entity.Funcao entity)
        {
            interactor.Validar(entity);
        }

        public void ValidarFalha(string mensagem)
        {
            view.ValidarFalha(mensagem);
        }

        public void ValidarSucesso()
        {
            view.ValidarSucesso();
        }
    }
}
