//
//  __MODULENAME__Router.swift
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

import Foundation
import UIKit

class VIPERRouter: VIPERPresenterToRouterProtocol {
    
    static func loadModule() -> UIViewController {
        let view = mainstoryboard.instantiateViewController(withIdentifier: "VIPERView") as? VIPERView
        let presenter: VIPERViewToPresenterProtocol & VIPERInteractorToPresenterProtocol = VIPERPresenter()
        let interactor: VIPERPresenterToInteractorProtocol = VIPERInteractor()
        let router: VIPERPresenterToRouterProtocol = VIPERRouter()
        
        view?.presenter = presenter
        presenter.view = view
        presenter.interactor = interactor
        presenter.router = router
        interactor.presenter = presenter
        
        return view!
    }
    
    static var mainstoryboard: UIStoryboard{
        return UIStoryboard(name: "Main", bundle: Bundle.main)
    }
}
