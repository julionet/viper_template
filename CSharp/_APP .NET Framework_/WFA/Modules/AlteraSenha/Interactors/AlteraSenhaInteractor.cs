using VIPER.DTO;
using VIPER.Modules.AlteraSenha.Interfaces;
using VIPER.Service;

namespace VIPER.Modules.AlteraSenha.Interactors
{
    public class AlteraSenhaInteractor : IPresenterToInteractorAlteraSenha
    {
        public IInteractorToPresenterAlteraSenha presenter;

        public void AlterarSenha(LoginDTO dados)
        {
            var mensagem = Servicos.usuarioService.AlterarSenha(dados);
            if (mensagem != "")
                presenter.AlterarSenhaFalha(mensagem);
            else
                presenter.AlterarSenhaSucesso();
        }
    }
}
