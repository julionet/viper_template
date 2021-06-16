//
//  __MODULENAME__Database.swift
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

import Foundation
import UIKit
import CoreData

class VIPERDatabase: DatabaseProtocol {
    typealias T = TVIPER


    static func insert(id: Int32) {
        let appDelegate = UIApplication.shared.delegate as! AppDelegate
        let context = appDelegate.persistentContainer.viewContext
        let entity = NSEntityDescription.entity(forEntityName: "TVIPER", in: context)
        let object = NSManagedObject(entity: entity!, insertInto: context)
        object.setValue(id, forKey: "id")
        
        appDelegate.saveContext()
    }
    
    static func update(registro: TVIPER) {
        let appDelegate = UIApplication.shared.delegate as! AppDelegate
        if let object = getById(id: registro.id) {
            
            appDelegate.saveContext()
        }
    }
    
    static func delete(registro: TVIPER) {
        let appDelegate = UIApplication.shared.delegate as! AppDelegate
        let context = appDelegate.persistentContainer.viewContext
        context.delete(registro)
        appDelegate.saveContext()
    }
    
    static func deleteAll() {
        let appDelegate = UIApplication.shared.delegate as! AppDelegate
        let context = appDelegate.persistentContainer.viewContext
        for registro in getAll() {
            context.delete(registro)
        }
        appDelegate.saveContext()
    }
    
    static func getAll() -> [TVIPER] {
        let appDelegate = UIApplication.shared.delegate as! AppDelegate
        let context = appDelegate.persistentContainer.viewContext
        
        do {
            let VIPERs = try context.fetch(TVIPER.fetchRequest()) as! [TVIPER]
            return VIPERs.sorted { $0.id! < $1.id! }
        } catch {
            return [TVIPER]()
        }
    }
    
    static func getById(id: Int32) -> TVIPER? {
        let registros = getAll()
        
        let filtro = registros.filter { (registro) -> Bool in
            if registro.id == id {
                return true
            } else {
                return false
            }
        }
        
        if filtro.count != 0 {
            return filtro[0] as TVIPER
        } else {
            return nil
        }
    }
}
