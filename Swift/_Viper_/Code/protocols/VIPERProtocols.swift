//
//  __MODULENAME__Protocols.swift
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

import Foundation
import UIKit

protocol VIPERPresenterToViewProtocol: class {
    
}

protocol VIPERInteractorToPresenterProtocol: class {
    
}

protocol VIPERPresenterToInteractorProtocol: class {
    var presenter: VIPERInteractorToPresenterProtocol? {get set}
    
}

protocol VIPERViewToPresenterProtocol: class {
    var view: VIPERPresenterToViewProtocol? {get set}
    var interactor: VIPERPresenterToInteractorProtocol? {get set}
    var router: VIPERPresenterToRouterProtocol? {get set}
    
}

protocol VIPERPresenterToRouterProtocol: class {
    static func loadModule() -> UIViewController
    
}
