using VIPER.DTO;
using System.Collections.Generic;

namespace VIPER.Modules.ControleAcesso.Interfaces
{
    public interface IViewToPresenterControleAcesso
    {
        void Salvar(UsuarioUsuarioFuncaoDTO entity);
        void SelecionarUsuario(int usuario);
        void SelecionarListaFuncoes(int usuario);
        void SelecionarPerfis(int usuario);
        void CarregarPermissaoAcesso(string descricao, ref bool incluir, ref bool alterar, ref bool excluir, out bool ok);
    }

    public interface IPresenterToViewControleAcesso
    {
        void SalvarSucesso();
        void SalvarFalha(string mensagem);
        void SelecionarUsuarioSucesso(Entity.Usuario usuario);
        void SelecionarUsuarioFalha();
        void SelecionarListaFuncoesSucesso(List<UsuarioFuncaoDTO> usuarioFuncaos, List<FuncaoDTO> funcaos);
        void SelecionarPerfisSucesso(List<Entity.Perfil> perfilselecionados, List<Entity.Perfil> perfiltodos);
    }

    public interface IPresenterToInteractorControleAcesso
    {
        void Salvar(UsuarioUsuarioFuncaoDTO entity);
        void SelecionarUsuario(int usuario);
        void SelecionarListaFuncoes(int usuario);
        void SelecionarPerfis(int usuario);
    }

    public interface IInteractorToPresenterControleAcesso
    {
        void SalvarSucesso();
        void SalvarFalha(string mensagem);
        void SelecionarUsuarioSucesso(Entity.Usuario usuario);
        void SelecionarUsuarioFalha();
        void SelecionarListaFuncoesSucesso(List<UsuarioFuncaoDTO> usuarioFuncaos, List<FuncaoDTO> funcaos);
        void SelecionarPerfisSucesso(List<Entity.Perfil> perfilselecionados, List<Entity.Perfil> perfiltodos);
    }

    public interface IPresenterToRouterControleAcesso
    {
        void CarregarPermissaoAcesso(string descricao, ref bool incluir, ref bool alterar, ref bool excluir, out bool ok);
    }
}
