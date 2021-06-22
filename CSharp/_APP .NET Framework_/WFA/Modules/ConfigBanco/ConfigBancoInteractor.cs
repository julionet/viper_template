using VIPER.Modules.ConfigBanco.Interfaces;
using VIPER.Service;

namespace VIPER.Modules.ConfigBanco.Interactors
{
    public class ConfigBancoInteractor : IPresenterToInteractorConfigBanco
    {
        public IInteractorToPresenterConfigBanco presenter;

        public void CarregarConfiguracao(string connectionstringname)
        {
            var connectionstring = Servicos.databaseService.CarregarConnectionString(connectionstringname);
            if (string.IsNullOrWhiteSpace(connectionstring))
                presenter.CarregarConfiguracaoFalha("");
            else
                presenter.CarregarConfiguracaoSucesso(connectionstring);
        }
    }
}
