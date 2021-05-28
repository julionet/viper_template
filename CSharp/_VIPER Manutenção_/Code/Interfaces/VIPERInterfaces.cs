//
//  __MODULENAME__Interfaces.cs
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

using System.Windows.Forms;

namespace NAMESPACE.Interfaces
{
    public interface IViewToPresenterVIPER
    {
    }

    public interface IPresenterToViewVIPER
    {
    }

    public interface IPresenterToInteractorVIPER
    {
    }

    public interface IInteractorToPresenterVIPER
    {
    }

    public interface IPresenterToRouterVIPER
    {
        Form LoadModule();
    }
}
