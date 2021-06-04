//
//  __MODULENAME__View.java
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

package NAMESPACE.modules._VIPER_.user_interface;

import android.os.Bundle;

import androidx.appcompat.app.AppCompatActivity;

import NAMESPACE.R;
import NAMESPACE.modules._VIPER_.contracts.VIPERContracts;

public class VIPERView extends AppCompatActivity implements VIPERContracts.View {

    public VIPERContracts.Presenter presenter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        this.presenter = new VIPERPresenter(this);
    }

    @Override
    protected void onDestroy() {
        this.presenter.unload();
        this.presenter = null;
        super.onDestroy();
    }
}
