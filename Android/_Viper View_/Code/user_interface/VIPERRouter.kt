//
//  __MODULENAME__Router.kt
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

package NAMESPACE.modules._VIPER_.user_interface

import androidx.appcompat.app.AppCompatActivity
import NAMESPACE.modules._VIPER_.contracts.VIPERContracts

class VIPERRouter (activity: AppCompatActivity?): VIPERContracts.Router {
    private var activity: AppCompatActivity? = null

    init {
        this.activity = activity
    }

    override fun unload() {
        activity = null
    }
}