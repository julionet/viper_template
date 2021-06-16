using VIPER.DTO;
using System.Collections.Generic;

namespace VIPER.Modules.Login.Interfaces
{
    public interface IViewToPresenterLogin
    {
        void ValidarLogin(AutenticacaoDTO autenticacao);
        void DeveAlterarSenha(string login);
        void SelecionarSistemas();
        void CarregarConfigBanco(out bool confirmado);
        void CarregarAlteraSenha(string senha, out bool confirmado);
    }

    public interface IPresenterToViewLogin
    {
        void ValidarLoginSucesso(string login);
        void ValidarLoginFalha(string mensagem);
        void DeveAlterarSenhaSucesso();
        void DeveAlterarSenhaFalha();
        void SelecionarSistemasSucesso(List<Entity.Sistema> sistemas);
        void SelecionarSistemasFalha(string mensagem);
    }

    public interface IPresenterToInteractorLogin
    {
        void ValidarLogin(AutenticacaoDTO autenticacao);
        void DeveAlterarSenha(string login);
        void SelecionarSistemas();
    }

    public interface IInteractorToPresenterLogin
    {
        void ValidarLoginSucesso(string login);
        void ValidarLoginFalha(string mensagem);
        void DeveAlterarSenhaSucesso();
        void DeveAlterarSenhaFalha();
        void SelecionarSistemasSucesso(List<Entity.Sistema> sistemas);
        void SelecionarSistemasFalha(string mensagem);
    }

    public interface IPresenterToRouterLogin
    {
        void CarregarConfigBanco(out bool confirmado);
        void CarregarAlteraSenha(string senha, out bool confirmado);
    }
}
