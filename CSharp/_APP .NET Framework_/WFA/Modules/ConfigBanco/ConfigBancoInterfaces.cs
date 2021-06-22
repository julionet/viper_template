namespace VIPER.Modules.ConfigBanco.Interfaces
{
    public interface IViewToPresenterConfigBanco
    {
        void CarregarConfiguracao(string connectionstringname);
    }

    public interface IPresenterToViewConfigBanco
    {
        void CarregarConfiguracaoSucesso(string connectionstring);
        void CarregarConfiguracaoFalha(string mensagem);
    }

    public interface IPresenterToInteractorConfigBanco
    {
        void CarregarConfiguracao(string connectionstringname);
    }

    public interface IInteractorToPresenterConfigBanco
    {
        void CarregarConfiguracaoSucesso(string connectionstring);
        void CarregarConfiguracaoFalha(string mensagem);
    }

    public interface IPresenterToRouterConfigBanco
    {
        
    }
}
