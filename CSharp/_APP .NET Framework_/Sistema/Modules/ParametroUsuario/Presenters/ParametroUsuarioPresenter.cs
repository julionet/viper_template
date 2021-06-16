using Chronus.App.Modules.ParametroUsuario.Interfaces;

namespace Chronus.App.Modules.ParametroUsuario.Presenters
{
    public class ParametroUsuarioPresenter : IViewToPresenterParametroUsuario, IInteractorToPresenterParametroUsuario
    {
        public IPresenterToInteractorParametroUsuario interactor;
        public IPresenterToRouterParametroUsuario router;
        public IPresenterToViewParametroUsuario view;

    }
}
