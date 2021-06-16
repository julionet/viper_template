using VIPER.Modules.Configuracao.Interfaces;

namespace VIPER.Modules.Configuracao.Presenters
{
    public class ConfiguracaoPresenter : IViewToPresenterConfiguracao, IInteractorToPresenterConfiguracao
    {
        public IPresenterToInteractorConfiguracao interactor;
        public IPresenterToRouterConfiguracao router;
        public IPresenterToViewConfiguracao view;

    }
}
