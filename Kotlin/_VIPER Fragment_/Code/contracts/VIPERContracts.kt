//
//  __MODULENAME__Contracts.kt
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

package NAMESPACE.modules._VIPER_.contracts

interface VIPERContracts {
    interface Presenter {
        fun unload()

    }

    interface View {

    }

    interface Router {
        fun unload()

    }

    interface Interactor : InteractorOutput {
        fun unload()

    }

    interface InteractorOutput {

    }
}