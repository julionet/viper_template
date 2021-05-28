//
//  __MODULENAME__Presenter.cs
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

using NAMESPACE.Interfaces;

namespace NAMESPACE.Presenters
{
    public class VIPERPresenter : IViewToPresenterVIPER, IInteractorToPresenterVIPER
    {
        public IPresenterToInteractorVIPER interactor;
        public IPresenterToRouterVIPER router;
        public IPresenterToViewVIPER view;

    }
}
