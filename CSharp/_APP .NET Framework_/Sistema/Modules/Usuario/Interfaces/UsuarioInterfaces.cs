using System.Collections.Generic;

namespace VIPER.Modules.Usuario.Interfaces
{
    public interface IViewToPresenterUsuario
    {
        void ObterDadosPrincipal(string condicao);
        void Gravar(Entity.Usuario entity);
        void Excluir(Entity.Usuario entity);
    }

    public interface IPresenterToViewUsuario
    {
        void ObterDadosPrincipalSucesso(List<Entity.Usuario> dados);
        void ObterDadosPrincipalFalha();
        void GravarSucesso();
        void GravarFalha(string mensagem);
        void ExcluirSucesso();
        void ExcluirFalha(string mensagem);
    }

    public interface IPresenterToInteractorUsuario
    {
        void ObterDadosPrincipal(string condicao);
        void Gravar(Entity.Usuario entity);
        void Excluir(Entity.Usuario entity);
    }

    public interface IInteractorToPresenterUsuario
    {
        void ObterDadosPrincipalSucesso(List<Entity.Usuario> dados);
        void ObterDadosPrincipalFalha();
        void GravarSucesso();
        void GravarFalha(string mensagem);
        void ExcluirSucesso();
        void ExcluirFalha(string mensagem);
    }

    public interface IPresenterToRouterUsuario
    {
        
    }
}
