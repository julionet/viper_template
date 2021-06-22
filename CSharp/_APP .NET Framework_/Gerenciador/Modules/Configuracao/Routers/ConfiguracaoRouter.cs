using VIPER.Modules.Configuracao.Interactors;
using VIPER.Modules.Configuracao.Interfaces;
using VIPER.Modules.Configuracao.Presenters;
using VIPER.Modules.Configuracao.Views;
using System.Windows.Forms;

namespace VIPER.Modules.Configuracao.Routers
{
    public class ConfiguracaoRouter : IPresenterToRouterConfiguracao
    {
        public static Form New(int funcao)
        {
            return new ConfiguracaoRouter().LoadModule(funcao);
        }

        private Form LoadModule(int funcao)
        {
            ConfiguracaoPresenter presenter = new ConfiguracaoPresenter();
            ConfiguracaoInteractor interactor = new ConfiguracaoInteractor();
            ConfiguracaoRouter router = new ConfiguracaoRouter();
            ConfiguracaoView form = new ConfiguracaoView(funcao);
            
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
            
            interactor.presenter = presenter;

            return form;
        }
    }
}
