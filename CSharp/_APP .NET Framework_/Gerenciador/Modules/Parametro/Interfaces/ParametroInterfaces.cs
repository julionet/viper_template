using System.Collections.Generic;

namespace VIPER.Modules.Parametro.Interfaces
{
    public interface IViewToPresenterParametro
    {
        void ObterDadosPrincipal(string condicao);
        void Gravar(Entity.Parametro entity);
        void Excluir(Entity.Parametro entity);
    }

    public interface IPresenterToViewParametro
    {
        void ObterDadosPrincipalSucesso(List<Entity.Parametro> dados);
        void ObterDadosPrincipalFalha();
        void GravarSucesso();
        void GravarFalha(string mensagem);
        void ExcluirSucesso();
        void ExcluirFalha(string mensagem);
    }

    public interface IPresenterToInteractorParametro
    {
        void ObterDadosPrincipal(string condicao);
        void Gravar(Entity.Parametro entity);
        void Excluir(Entity.Parametro entity);
    }

    public interface IInteractorToPresenterParametro
    {
        void ObterDadosPrincipalSucesso(List<Entity.Parametro> dados);
        void ObterDadosPrincipalFalha();
        void GravarSucesso();
        void GravarFalha(string mensagem);
        void ExcluirSucesso();
        void ExcluirFalha(string mensagem);
    }

    public interface IPresenterToRouterParametro
    {
        
    }
}
