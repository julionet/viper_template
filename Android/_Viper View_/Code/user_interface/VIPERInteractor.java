//
//  __MODULENAME__Interactor.java
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

package NAMESPACE.modules._VIPER_.user_interface;

import NAMESPACE.modules._VIPER_.contracts.VIPERContracts;

public class VIPERInteractor implements VIPERContracts.Interactor {

    private VIPERContracts.InteractorOutput output;

    public VIPERInteractor(VIPERContracts.InteractorOutput output) {
        this.output = output;
    }

    @Override
    public void unload() {
        this.output = null;
    }
}
