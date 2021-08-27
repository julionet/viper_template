//
//  __MODULENAME__Fragment.java
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

package NAMESPACE.modules._VIPER_.user_interface;

import android.content.Context;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;

import NAMESPACE.modules._VIPER_.contracts.VIPERContracts;

public class VIPERFragment extends Fragment implements VIPERContracts.View {

    public VIPERContracts.Presenter presenter;

    private Context _context;

    public VIPERFragment() {

    }

    @Override
    public void onResume() {
        super.onResume();

    }

    @Override
    public void onAttach(@NonNull Context context) {
        super.onAttach(context);
        _context = context;

        this.presenter = new VIPERPresenter(this);
    }

    @Override
    public void onDetach() {
        super.onDetach();
        _context = null;

        this.presenter.unload();
        this.presenter = null;
    }
}
