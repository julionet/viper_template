//
//  __MODULENAME__Router.cs
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

using NAMESPACE.Interactors;
using NAMESPACE.Interfaces;
using NAMESPACE.Presenters;
using NAMESPACE.Views;
using System.Windows.Forms;

namespace NAMESPACE.Routers
{
    public class VIPERRouter : IPresenterToRouterVIPER
    {
        public static Form New()
        {
            return new VIPERRouter().Inicializar();
        }

        public Form Inicializar()
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
		
		public Form LoadModule()
        {
            throw new System.NotImplementedException();
        }
    }
}
