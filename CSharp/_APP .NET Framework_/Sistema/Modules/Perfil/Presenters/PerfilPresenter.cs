using Chronus.App.Modules.Perfil.Interfaces;

namespace Chronus.App.Modules.Perfil.Presenters
{
    public class PerfilPresenter : IViewToPresenterPerfil, IInteractorToPresenterPerfil
    {
        public IPresenterToInteractorPerfil interactor;
        public IPresenterToRouterPerfil router;
        public IPresenterToViewPerfil view;

    }
}
