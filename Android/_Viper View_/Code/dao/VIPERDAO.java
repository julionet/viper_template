//
//  __MODULENAME__DAO.java
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

package NAMESPACE.modules._VIPER_.dao;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

import java.util.ArrayList;
import java.util.List;

import NAMESPACE.database.DAOContracts;
import NAMESPACE.modules._VIPER_.entity.VIPER;
import NAMESPACE.utils.Constantes;

public class VIPERDAO implements DAOContracts<VIPER> {

	private final SQLiteDatabase db;

    public VIPERDAO(Context context) {
        this.db = DBHelper.getDatabaseInstance(context);
    }
	
	@Override
    public void insert(VIPER entity) {
        try {
            ContentValues values = new ContentValues();
            values.put("id", entity.getId());
            try {
                db.insert(Constantes.TABLE_[VIPER], "", values);
            } catch (Exception ignored) { }
        } finally {
            db.close();
        }
    }

    @Override
    public void update(VIPER entity) {
        try {
            ContentValues values = new ContentValues();
            values.put("id", entity.getId());
            try {
                db.update(Constantes.TABLE_[VIPER], values, "id = ?", new String[]{String.valueOf(entity.getId())});
            } catch (Exception ignored) { }
        } finally {
            db.close();
        }
    }

    @Override
    public void delete(int id) {
        try {
            try {
                db.delete(Constantes.TABLE_[VIPER], "id = ?", new String[]{String.valueOf(id)});
            } catch (Exception ignored) { }
        } finally {
            db.close();
        }
    }

    @Override
    public void deleteAll() {
        try {
            try {
                db.delete(Constantes.TABLE_[VIPER], null, null);
            } catch (Exception ignored) { }
        } finally {
            db.close();
        }
    }

    @Override
    public List<VIPER> getAll() {
        try {
            Cursor c = db.query(Constantes.TABLE_[VIPER], null, null, null, null, null, "descricao");
            return toList(c);
        } finally {
            db.close();
        }
    }

    @Override
    public VIPER getById(int id) {
        try {
            Cursor c = db.query(Constantes.TABLE_[VIPER], null, "id = " + id, null, null, null, null);
            List<VIPER> registros = toList(c);
            if (registros.size() != 0) {
                return registros.get(0);
            } else {
                return null;
            }
        } finally {
            db.close();
        }
    }

    @Override
    public void dropTable() {
        try {
            db.execSQL("drop table if exists " + Constantes.TABLE_[VIPER] + ";");
        } finally {
            db.close();
        }
    }

    @Override
    public List<VIPER> toList(Cursor c) {
        List<VIPER> registros = new ArrayList<>();
        if (c.moveToFirst()) {
            do {
                VIPER registro = new VIPER();
                registro.setId(c.getInt(c.getColumnIndex("id")));
                registros.add(registro);
            } while (c.moveToNext());
        }
        return registros;
    }
}