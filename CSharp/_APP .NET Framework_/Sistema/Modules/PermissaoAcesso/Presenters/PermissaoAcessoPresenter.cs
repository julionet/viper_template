using VIPER.Modules.PermissaoAcesso.Interfaces;

namespace VIPER.Modules.PermissaoAcesso.Presenters
{
    public class PermissaoAcessoPresenter : IViewToPresenterPermissaoAcesso, IInteractorToPresenterPermissaoAcesso
    {
        public IPresenterToInteractorPermissaoAcesso interactor;
        public IPresenterToRouterPermissaoAcesso router;
        public IPresenterToViewPermissaoAcesso view;

    }
}
