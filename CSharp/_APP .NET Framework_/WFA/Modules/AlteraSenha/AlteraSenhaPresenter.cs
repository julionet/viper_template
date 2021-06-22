using VIPER.DTO;
using VIPER.Modules.AlteraSenha.Interfaces;

namespace VIPER.Modules.AlteraSenha.Presenters
{
    public class AlteraSenhaPresenter : IViewToPresenterAlteraSenha, IInteractorToPresenterAlteraSenha
    {
        public IPresenterToInteractorAlteraSenha interactor;
        public IPresenterToRouterAlteraSenha router;
        public IPresenterToViewAlteraSenha view;

        public void AlterarSenha(LoginDTO dados)
        {
            interactor.AlterarSenha(dados);
        }

        public void AlterarSenhaFalha(string mensagem)
        {
            view.AlterarSenhaFalha(mensagem);
        }

        public void AlterarSenhaSucesso()
        {
            view.AlterarSenhaSucesso();
        }
    }
}
