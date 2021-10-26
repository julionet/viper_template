using NAMESPACE.Modules.__MODULENAME__.Interactors;
using NAMESPACE.Modules.__MODULENAME__.Interfaces;
using NAMESPACE.Modules.__MODULENAME__.Presenters;
using NAMESPACE.Modules.__MODULENAME__.Views;
using System.Windows.Forms;

namespace NAMESPACE.Modules.__MODULENAME__.Routers
{
    public class VIPERRouter : IPresenterToRouterVIPER
    {
        public static Form New(int funcao)
        {
            return new VIPERRouter().LoadModule(funcao);
        }

        private Form LoadModule(int funcao)
        {
            var presenter = new VIPERPresenter();
            var interactor = new VIPERInteractor();
            var router = new VIPERRouter();
            var form = new VIPERView(funcao);
            
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
            
            interactor.presenter = presenter;

            return form;
        }
    }
}
