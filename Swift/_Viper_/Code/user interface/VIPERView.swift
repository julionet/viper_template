//
//  __MODULENAME__View.swift
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

import Foundation
import UIKit

class VIPERView: UIViewController {
    
    var presenter: VIPERViewToPresenterProtocol?

    override func viewDidLoad() {
        super.viewDidLoad()

    }
}

extension VIPERView: VIPERPresenterToViewProtocol {

}
