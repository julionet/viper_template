//
//  __MODULENAME__Presenter.kt
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

package NAMESPACE.modules._VIPER_.user_interface

import NAMESPACE.modules._VIPER_.contracts.ConfiguracaoContracts
import androidx.appcompat.app.AppCompatActivity

class VIPERPresenter (view: VIPERContracts.View?): VIPERContracts.Presenter,
    VIPERContracts.InteractorOutput {
    var view: VIPERContracts.View? = null
    var interactor: VIPERContracts.Interactor? = VIPERInteractor(this)
    var router: VIPERContracts.Router? = null

    init {
        this.view = view
        router = VIPERRouter(view as AppCompatActivity?)
    }

    override fun unload() {
        interactor?.unload()
        router?.unload()
        interactor = null
        router = null
        view = null
    }
}
