//
//  __MODULENAME__Presenter.java
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

package NAMESPACE.modules._VIPER_.user_interface;

import androidx.fragment.app.Fragment;

import NAMESPACE.modules._VIPER_.contracts.VIPERContracts;

public class VIPERPresenter implements VIPERContracts.Presenter, VIPERContracts.InteractorOutput {

    public VIPERContracts.View view;
    public VIPERContracts.Interactor interactor = new VIPERInteractor(this);
    public VIPERContracts.Router router;

    VIPERPresenter(VIPERContracts.View view) {
        this.view = view;
		this.router = new VIPERRouter((Fragment) this.view);
    }

    @Override
    public void unload() {
        this.interactor.unload();
        this.router.unload();
        this.interactor = null;
        this.router = null;
        this.view = null;
    }
}
