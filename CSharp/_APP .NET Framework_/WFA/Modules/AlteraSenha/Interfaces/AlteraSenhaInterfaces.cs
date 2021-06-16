using VIPER.DTO;

namespace VIPER.Modules.AlteraSenha.Interfaces
{
    public interface IViewToPresenterAlteraSenha
    {
        void AlterarSenha(LoginDTO dados);
    }

    public interface IPresenterToViewAlteraSenha
    {
        void AlterarSenhaSucesso();
        void AlterarSenhaFalha(string mensagem);
    }

    public interface IPresenterToInteractorAlteraSenha
    {
        void AlterarSenha(LoginDTO dados);
    }

    public interface IInteractorToPresenterAlteraSenha
    {
        void AlterarSenhaSucesso();
        void AlterarSenhaFalha(string mensagem);
    }

    public interface IPresenterToRouterAlteraSenha
    {
        
    }
}
