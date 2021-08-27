//
//  __MODULENAME__View.kt
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

package NAMESPACE.modules._VIPER_.user_interface

import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import NAMESPACE.modules._VIPER_.contracts.VIPERContracts

class VIPERView: AppCompatActivity(), VIPERContracts.View {
    private var presenter: VIPERContracts.Presenter? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        
        presenter = VIPERPresenter(this)
    }

    override fun onDestroy() {
        presenter?.unload()
        presenter = null
        super.onDestroy()
    }
}