using NAMESPACE.DTO;
using System.Collections.Generic;

namespace NAMESPACE.Modules.__MODULENAME__.Interfaces
{
    public interface IViewToPresenterVIPER
    {
        void ObterDadosPrincipal(string condicao);
        void Gravar(Entity.VIPER entity);
        void Excluir(Entity.VIPER entity);
		void SelecionarAcessoPorUsuario(int usuario, int funcao, int modulo, int sistema);
    }

    public interface IPresenterToViewVIPER
    {
        void ObterDadosPrincipalSucesso(List<Entity.VIPER> dados);
        void ObterDadosPrincipalFalha();
        void GravarSucesso();
        void GravarFalha(string mensagem);
        void ExcluirSucesso();
        void ExcluirFalha(string mensagem);
		void SelecionarAcessoPorUsuarioSucesso(UsuarioFuncaoDTO acesso);
    }

    public interface IPresenterToInteractorVIPER
    {
        void ObterDadosPrincipal(string condicao);
        void Gravar(Entity.VIPER entity);
        void Excluir(Entity.VIPER entity);
		void SelecionarAcessoPorUsuario(int usuario, int funcao, int modulo, int sistema);
    }

    public interface IInteractorToPresenterVIPER
    {
        void ObterDadosPrincipalSucesso(List<Entity.VIPER> dados);
        void ObterDadosPrincipalFalha();
        void GravarSucesso();
        void GravarFalha(string mensagem);
        void ExcluirSucesso();
        void ExcluirFalha(string mensagem);
		void SelecionarAcessoPorUsuarioSucesso(UsuarioFuncaoDTO acesso);
    }

    public interface IPresenterToRouterVIPER
    {
        
    }
}
