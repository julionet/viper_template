//
//  __MODULENAME__Controller.java
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

package NAMESPACE.modules._VIPER_.controllers;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;

import java.util.List;

import NAMESPACE.database.DBHelper;
import NAMESPACE.modules._VIPER_.dao.VIPERDAO;
import NAMESPACE.modules._VIPER_.entity.VIPER;

public class VIPERController {

    public static void inserir(Context context, VIPER entity) {
        DBHelper helper = new DBHelper(context);
        try (SQLiteDatabase database = helper.getWritableDatabase()) {
            try {
                VIPERDAO dao = new VIPERDAO(database);
                dao.insert(entity);
            } finally {
                database.close();
            }
            helper.close();
        }
    }

    public static void alterar(Context context, VIPER entity) {
        DBHelper helper = new DBHelper(context);
        try (SQLiteDatabase database = helper.getWritableDatabase()) {
            try {
                VIPERDAO dao = new VIPERDAO(database);
                dao.update(entity);
            } finally {
                database.close();
            }
            helper.close();
        }
    }

    public static void excluir(Context context, int id) {
        DBHelper helper = new DBHelper(context);
        try (SQLiteDatabase database = helper.getWritableDatabase()) {
            try {
                VIPERDAO dao = new VIPERDAO(database);
                dao.delete(id);
            } finally {
                database.close();
            }
            helper.close();
        }
    }

    public static void excluirTodos(Context context) {
        DBHelper helper = new DBHelper(context);
        try (SQLiteDatabase database = helper.getWritableDatabase()) {
            try {
                VIPERDAO dao = new VIPERDAO(database);
                dao.deleteAll();
            } finally {
                database.close();
            }
            helper.close();
        }
    }

    public static List<VIPER> selecionarTodos(Context context) {
        try (DBHelper helper = new DBHelper(context);
             SQLiteDatabase database = helper.getReadableDatabase()) {
            try {
                VIPERDAO dao = new VIPERDAO(database);
                return dao.getAll();
            } finally {
                database.close();
            }
        }
    }

    public static VIPER selecionar(Context context, int id) {
        try (DBHelper helper = new DBHelper(context);
             SQLiteDatabase database = helper.getReadableDatabase()) {
            try {
                VIPERDAO dao = new VIPERDAO(database);
                return dao.getById(id);
            } finally {
                database.close();
            }
        }
    }

    public static void excluirTabela(Context context) {
        DBHelper helper = new DBHelper(context);
        try (SQLiteDatabase database = helper.getWritableDatabase()) {
            try {
                VIPERDAO dao = new VIPERDAO(database);
                dao.dropTable();
            } finally {
                database.close();
            }
            helper.close();
        }
    }
}

