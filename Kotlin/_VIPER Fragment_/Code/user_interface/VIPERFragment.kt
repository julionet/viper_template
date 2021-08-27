//
//  __MODULENAME__Fragment.kt
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

package NAMESPACE.modules._VIPER_.user_interface

import android.content.Context
import androidx.fragment.app.Fragment
import NAMESPACE.modules._VIPER_.contracts.VIPERContracts

class VIPERFragment : Fragment(), VIPERContracts.View {
    private var presenter: VIPERContracts.Presenter? = null

    private var _context: Context? = null

    override fun onResume() {
        super.onResume()
    }

    override fun onAttach(context: Context) {
        super.onAttach(context)
        _context = context
        presenter = VIPERPresenter(this)
    }

    override fun onDetach() {
        super.onDetach()
        _context = null
        presenter!!.unload()
        presenter = null
    }
}