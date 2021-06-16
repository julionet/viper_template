//
//  __MODULENAME__Router.java
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

package NAMESPACE.modules._VIPER_.user_interface;

import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentActivity;

import NAMESPACE.modules._VIPER_.contracts.VIPERContracts;

public class VIPERRouter implements VIPERContracts.Router {

    private FragmentActivity activity;

    VIPERRouter(Fragment fragment) {
        this.activity = fragment.requireActivity();
    }

    @Override
    public void unload() {
        this.activity = null;
    }
}
