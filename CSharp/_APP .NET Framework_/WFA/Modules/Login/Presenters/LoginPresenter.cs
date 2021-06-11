using VIPER.DTO;
using VIPER.Modules.Login.Interfaces;
using System.Collections.Generic;

namespace VIPER.Modules.Login.Presenters
{
    public class LoginPresenter : IViewToPresenterLogin, IInteractorToPresenterLogin
    {
        public IPresenterToInteractorLogin interactor;
        public IPresenterToRouterLogin router;
        public IPresenterToViewLogin view;

        public void CarregarAlteraSenha(string senha, out bool confirmado)
        {
            router.CarregarAlteraSenha(senha, out confirmado);
        }

        public void CarregarConfigBanco(out bool confirmado)
        {
            router.CarregarConfigBanco(out confirmado);
        }

        public void DeveAlterarSenha(string login)
        {
            interactor.DeveAlterarSenha(login);
        }

        public void DeveAlterarSenhaFalha()
        {
            view.DeveAlterarSenhaFalha();
        }

        public void DeveAlterarSenhaSucesso()
        {
            view.DeveAlterarSenhaSucesso();
        }

        public void SelecionarSistemas()
        {
            interactor.SelecionarSistemas();
        }

        public void SelecionarSistemasFalha(string mensagem)
        {
            view.SelecionarSistemasFalha(mensagem);
        }

        public void SelecionarSistemasSucesso(List<Entity.Sistema> sistemas)
        {
            view.SelecionarSistemasSucesso(sistemas);
        }

        public void ValidarLogin(AutenticacaoDTO autenticacao)
        {
            interactor.ValidarLogin(autenticacao);
        }

        public void ValidarLoginFalha(string mensagem)
        {
            view.ValidarLoginFalha(mensagem);
        }

        public void ValidarLoginSucesso(string login)
        {
            view.ValidarLoginSucesso(login);
        }
    }
}
