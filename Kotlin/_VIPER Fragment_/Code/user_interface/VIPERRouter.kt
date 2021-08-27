//
//  __MODULENAME__Router.java
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

package NAMESPACE.modules._VIPER_.user_interface

import androidx.fragment.app.Fragment
import NAMESPACE.modules._VIPER_.contracts.VIPERContracts.Router
import androidx.fragment.app.FragmentActivity

class VIPERRouter internal constructor(fragment: Fragment) : Router {
    private var activity: FragmentActivity?
    
    override fun unload() {
        activity = null
    }

    init {
        activity = fragment.requireActivity()
    }
}