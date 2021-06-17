using VIPER.DTO;
using VIPER.Modules.Perfil.Interfaces;
using System.Collections.Generic;

namespace VIPER.Modules.Perfil.Presenters
{
    public class PerfilPresenter : IViewToPresenterPerfil, IInteractorToPresenterPerfil
    {
        public IPresenterToInteractorPerfil interactor;
        public IPresenterToRouterPerfil router;
        public IPresenterToViewPerfil view;

        public void CarregarPermissaoAcesso(string descricao, ref bool incluir, ref bool alterar, ref bool excluir, out bool ok)
        {
            router.CarregarPermissaoAcesso(descricao, ref incluir, ref alterar, ref excluir, out ok);
        }

        public void Excluir(Entity.Perfil entity)
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

        public void Gravar(PerfilPerfilFuncaoDTO entity)
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

        public void ObterDadosPrincipalSucesso(List<Entity.Perfil> dados)
        {
            view.ObterDadosPrincipalSucesso(dados);
        }

        public void SelecionarPerfilFuncao(int perfil, int sistema)
        {
            interactor.SelecionarPerfilFuncao(perfil, sistema);
        }

        public void SelecionarPerfilFuncaoSucesso(List<PerfilFuncaoDTO> perfils, List<FuncaoDTO> funcaos)
        {
            view.SelecionarPerfilFuncaoSucesso(perfils, funcaos);
        }
    }
}
