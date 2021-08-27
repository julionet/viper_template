//
//  __MODULENAME__Interactor.kt
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

package NAMESPACE.modules._VIPER_.user_interface

import NAMESPACE.modules._VIPER_.contracts.VIPERContracts

class VIPERInteractor (output: VIPERContracts.InteractorOutput?): VIPERContracts.Interactor {
    private var output: VIPERContracts.InteractorOutput? = null

    init {
        this.output = output
    }

    override fun unload() {
        output = null
    }
}