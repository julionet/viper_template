using NAMESPACE.Modules.__MODULENAME__.Interfaces;

namespace NAMESPACE.Modules.__MODULENAME__.Presenters
{
    public class VIPERPresenter : IViewToPresenterVIPER, IInteractorToPresenterVIPER
    {
        public IPresenterToInteractorVIPER interactor;
        public IPresenterToRouterVIPER router;
        public IPresenterToViewVIPER view;

    }
}
