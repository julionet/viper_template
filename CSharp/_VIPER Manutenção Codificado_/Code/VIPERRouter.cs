using NAMESPACE.Modules.__MODULENAME__.Interactors;
using NAMESPACE.Modules.__MODULENAME__.Interfaces;
using NAMESPACE.Modules.__MODULENAME__.Presenters;
using NAMESPACE.Modules.__MODULENAME__.Views;
using System.Windows.Forms;

namespace NAMESPACE.Modules.__MODULENAME__.Routers
{
    public class VIPERRouter : IPresenterToRouterVIPER
    {
        public static Form New()
        {
            return new VIPERRouter().LoadModule();
        }

        private Form LoadModule()
        {
            VIPERPresenter presenter = new VIPERPresenter();
            VIPERInteractor interactor = new VIPERInteractor();
            VIPERRouter router = new VIPERRouter();
            VIPERView form = new VIPERView();
            
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
            
            interactor.presenter = presenter;

            return form;
        }
    }
}
