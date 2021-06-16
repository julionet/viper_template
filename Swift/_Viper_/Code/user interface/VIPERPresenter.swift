//
//  __MODULENAME__Presenter.swift
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

import Foundation

class VIPERPresenter: VIPERViewToPresenterProtocol {
    
    var view: VIPERPresenterToViewProtocol?
    var interactor: VIPERPresenterToInteractorProtocol?
    var router: VIPERPresenterToRouterProtocol?
    
}

extension VIPERPresenter: VIPERInteractorToPresenterProtocol {
    
}