using VIPER.DTO;
using System.Collections.Generic;

namespace VIPER.Modules.Perfil.Interfaces
{
    public interface IViewToPresenterPerfil
    {
        void ObterDadosPrincipal(string condicao);
        void Gravar(PerfilPerfilFuncaoDTO entity);
        void Excluir(Entity.Perfil entity);
        void SelecionarPerfilFuncao(int perfil, int sistema);
        void CarregarPermissaoAcesso(string descricao, ref bool incluir, ref bool alterar, ref bool excluir, out bool ok);
    }

    public interface IPresenterToViewPerfil
    {
        void ObterDadosPrincipalSucesso(List<Entity.Perfil> dados);
        void ObterDadosPrincipalFalha();
        void GravarSucesso();
        void GravarFalha(string mensagem);
        void ExcluirSucesso();
        void ExcluirFalha(string mensagem);
        void SelecionarPerfilFuncaoSucesso(List<PerfilFuncaoDTO> perfils, List<FuncaoDTO> funcaos);
    }

    public interface IPresenterToInteractorPerfil
    {
        void ObterDadosPrincipal(string condicao);
        void Gravar(PerfilPerfilFuncaoDTO entity);
        void Excluir(Entity.Perfil entity);
        void SelecionarPerfilFuncao(int perfil, int sistema);
    }

    public interface IInteractorToPresenterPerfil
    {
        void ObterDadosPrincipalSucesso(List<Entity.Perfil> dados);
        void ObterDadosPrincipalFalha();
        void GravarSucesso();
        void GravarFalha(string mensagem);
        void ExcluirSucesso();
        void ExcluirFalha(string mensagem);
        void SelecionarPerfilFuncaoSucesso(List<PerfilFuncaoDTO> perfils, List<FuncaoDTO> funcaos);
    }

    public interface IPresenterToRouterPerfil
    {
        void CarregarPermissaoAcesso(string descricao, ref bool incluir, ref bool alterar, ref bool excluir, out bool ok);
    }
}
