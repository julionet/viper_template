using VIPER.DTO;
using System.Collections.Generic;

namespace VIPER.Modules.ParametroUsuario.Interfaces
{
    public interface IViewToPresenterParametroUsuario
    {
        void ObterDadosPrincipal(int parametro);
        void Gravar(Entity.ParametroUsuario entity);
        void Excluir(Entity.ParametroUsuario entity);
        void SelecionarUsuarios();
        void ExecutarSQL(string sql);
    }

    public interface IPresenterToViewParametroUsuario
    {
        void ObterDadosPrincipalSucesso(List<Entity.ParametroUsuario> dados);
        void ObterDadosPrincipalFalha();
        void GravarSucesso();
        void GravarFalha(string mensagem);
        void ExcluirSucesso();
        void ExcluirFalha(string mensagem);
        void SelecionarUsuariosSucesso(List<Entity.Usuario> dados);
        void SelecionarUsuarioFalha();
        void ExecutarSQLSucesso(List<LookupDataSourceDTO> dados);
        void ExecutarSQLFalha();
    }

    public interface IPresenterToInteractorParametroUsuario
    {
        void ObterDadosPrincipal(int parametro);
        void Gravar(Entity.ParametroUsuario entity);
        void Excluir(Entity.ParametroUsuario entity);
        void SelecionarUsuarios();
        void ExecutarSQL(string sql);
    }

    public interface IInteractorToPresenterParametroUsuario
    {
        void ObterDadosPrincipalSucesso(List<Entity.ParametroUsuario> dados);
        void ObterDadosPrincipalFalha();
        void GravarSucesso();
        void GravarFalha(string mensagem);
        void ExcluirSucesso();
        void ExcluirFalha(string mensagem);
        void SelecionarUsuariosSucesso(List<Entity.Usuario> dados);
        void SelecionarUsuarioFalha();
        void ExecutarSQLSucesso(List<LookupDataSourceDTO> dados);
        void ExecutarSQLFalha();
    }

    public interface IPresenterToRouterParametroUsuario
    {
        
    }
}
