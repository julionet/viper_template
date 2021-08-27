using VIPER.Modules.Parametro.Interfaces;
using System.Collections.Generic;

namespace VIPER.Modules.Parametro.Presenters
{
    public class ParametroPresenter : IViewToPresenterParametro, IInteractorToPresenterParametro
    {
        public IPresenterToInteractorParametro interactor;
        public IPresenterToRouterParametro router;
        public IPresenterToViewParametro view;

        public void Excluir(Entity.Parametro entity)
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

        public void Gravar(Entity.Parametro entity)
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

        public void ObterDadosPrincipalSucesso(List<Entity.Parametro> dados)
        {
            view.ObterDadosPrincipalSucesso(dados);
        }
    }
}
