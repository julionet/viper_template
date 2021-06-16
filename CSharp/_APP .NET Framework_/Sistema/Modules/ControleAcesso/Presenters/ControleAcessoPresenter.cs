using Chronus.App.Modules.ControleAcesso.Interfaces;

namespace Chronus.App.Modules.ControleAcesso.Presenters
{
    public class ControleAcessoPresenter : IViewToPresenterControleAcesso, IInteractorToPresenterControleAcesso
    {
        public IPresenterToInteractorControleAcesso interactor;
        public IPresenterToRouterControleAcesso router;
        public IPresenterToViewControleAcesso view;

    }
}
