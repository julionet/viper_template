using System.Collections.Generic;
using NAMESPACE.Modules.__MODULENAME__.Interfaces;

namespace NAMESPACE.Modules.__MODULENAME__.Presenters
{
    public class VIPERPresenter : IViewToPresenterVIPER, IInteractorToPresenterVIPER
    {
        public IPresenterToInteractorVIPER interactor;
        public IPresenterToRouterVIPER router;
        public IPresenterToViewVIPER view;

        public void Excluir(Entity.VIPER entity)
        {
            interactor.Excluir(entity);
        }

        public void ExcluirFalha(string mensagem)
        {
            view.ExcluirFalha(mensagem);
        }

        public void ExcluirSucesso()
        {
            view.ExcluirSucesso();
        }

        public void Gravar(Entity.VIPER entity)
        {
            interactor.Gravar(entity);
        }

        public void GravarFalha(string mensagem)
        {
            view.GravarFalha(mensagem);
        }

        public void GravarSucesso()
        {
            view.GravarSucesso();
        }

        public void ObterDadosPrincipal(string condicao)
        {
            interactor.ObterDadosPrincipal(condicao);
        }

        public void ObterDadosPrincipalFalha()
        {
            view.ObterDadosPrincipalFalha();
        }

        public void ObterDadosPrincipalSucesso(List<Entity.VIPER> dados)
        {
            view.ObterDadosPrincipalSucesso(dados);
        }
    }
}
