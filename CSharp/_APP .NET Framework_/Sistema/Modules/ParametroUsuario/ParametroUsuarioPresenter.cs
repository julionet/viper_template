using VIPER.DTO;
using VIPER.Modules.ParametroUsuario.Interfaces;
using System.Collections.Generic;

namespace VIPER.Modules.ParametroUsuario.Presenters
{
    public class ParametroUsuarioPresenter : IViewToPresenterParametroUsuario, IInteractorToPresenterParametroUsuario
    {
        public IPresenterToInteractorParametroUsuario interactor;
        public IPresenterToRouterParametroUsuario router;
        public IPresenterToViewParametroUsuario view;

        public void Excluir(Entity.ParametroUsuario entity)
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

        public void ExecutarSQL(string sql)
        {
            interactor.ExecutarSQL(sql);
        }

        public void ExecutarSQLFalha()
        {
            view.ExecutarSQLFalha();
        }

        public void ExecutarSQLSucesso(List<LookupDataSourceDTO> dados)
        {
            view.ExecutarSQLSucesso(dados);
        }

        public void Gravar(Entity.ParametroUsuario entity)
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

        public void ObterDadosPrincipal(int parametro)
        {
            interactor.ObterDadosPrincipal(parametro);
        }

        public void ObterDadosPrincipalFalha()
        {
            view.ObterDadosPrincipalFalha();
        }

        public void ObterDadosPrincipalSucesso(List<Entity.ParametroUsuario> dados)
        {
            view.ObterDadosPrincipalSucesso(dados);
        }

        public void SelecionarUsuarioFalha()
        {
            view.SelecionarUsuarioFalha();
        }

        public void SelecionarUsuarios()
        {
            interactor.SelecionarUsuarios();
        }

        public void SelecionarUsuariosSucesso(List<Entity.Usuario> dados)
        {
            view.SelecionarUsuariosSucesso(dados);
        }
    }
}
