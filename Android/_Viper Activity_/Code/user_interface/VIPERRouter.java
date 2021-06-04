//
//  __MODULENAME__Router.java
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

package NAMESPACE.modules._VIPER_.user_interface;

import androidx.appcompat.app.AppCompatActivity;

import NAMESPACE.modules._VIPER_.contracts.VIPERContracts;

public class VIPERRouter implements VIPERContracts.Router {

    private AppCompatActivity activity;

    public VIPERRouter(AppCompatActivity activity) {
        this.activity = activity;
    }

    @Override
    public void unload() {
        this.activity = null;
    }
}
