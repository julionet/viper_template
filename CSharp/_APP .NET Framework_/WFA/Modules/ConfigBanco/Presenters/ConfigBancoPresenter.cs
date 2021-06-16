using VIPER.Modules.ConfigBanco.Interfaces;

namespace VIPER.Modules.ConfigBanco.Presenters
{
    public class ConfigBancoPresenter : IViewToPresenterConfigBanco, IInteractorToPresenterConfigBanco
    {
        public IPresenterToInteractorConfigBanco interactor;
        public IPresenterToRouterConfigBanco router;
        public IPresenterToViewConfigBanco view;

        public void CarregarConfiguracao(string connectionstringname)
        {
            interactor.CarregarConfiguracao(connectionstringname);
        }

        public void CarregarConfiguracaoFalha(string mensagem)
        {
            view.CarregarConfiguracaoFalha(mensagem);
        }

        public void CarregarConfiguracaoSucesso(string connectionstring)
        {
            view.CarregarConfiguracaoSucesso(connectionstring);
        }
    }
}
