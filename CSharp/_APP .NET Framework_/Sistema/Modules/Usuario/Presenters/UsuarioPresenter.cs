using VIPER.Modules.Usuario.Interfaces;
using System.Collections.Generic;

namespace VIPER.Modules.Usuario.Presenters
{
    public class UsuarioPresenter : IViewToPresenterUsuario, IInteractorToPresenterUsuario
    {
        public IPresenterToInteractorUsuario interactor;
        public IPresenterToRouterUsuario router;
        public IPresenterToViewUsuario view;

        public void Excluir(Entity.Usuario entity)
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

        public void Gravar(Entity.Usuario entity)
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

        public void ObterDadosPrincipalSucesso(List<Entity.Usuario> dados)
        {
            view.ObterDadosPrincipalSucesso(dados);
        }
    }
}
