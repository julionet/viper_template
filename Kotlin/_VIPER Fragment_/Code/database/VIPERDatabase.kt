//
//  __MODULENAME__Database.kt
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

package NAMESPACE.database

import android.database.Cursor
import NAMESPACE.modules._VIPER_.entity.VIPER
import android.database.sqlite.SQLiteDatabase
import NAMESPACE.utils.Constantes

import android.content.ContentValues
import android.content.Context

class VIPERDatabase(context: Context): DAOContracts<VIPER> {
    private var db: SQLiteDatabase? = null

    init {
        db = DBHelper.databaseInstance(context)
    }

    override fun insert(entity: VIPER?) {
        val values = ContentValues()
        values.put("id", entity?.id)
        db?.insert(Constantes.TABLE_[VIPER], "", values)
    }

    override fun update(entity: VIPER?) {
        val values = ContentValues()
        values.put("id", entity?.id)
        db?.update(Constantes.TABLE_[VIPER], values, "id = ?", arrayOf(java.lang.String.valueOf(entity?.id)))
    }

    override fun delete(id: Int?) {
        db?.delete(Constantes.TABLE_[VIPER], "id = ?", arrayOf(java.lang.String.valueOf(id)))
    }

    override fun deleteAll() {
        db?.delete(Constantes.TABLE_[VIPER], null, null)
    }

    override fun getAll(): List<VIPER?> {
        val c = db?.query(Constantes.TABLE_[VIPER], null, null, null, null, null, null)
        return toList(c)
    }

    override fun getById(id: Int?): VIPER? {
        val c = db?.query(Constantes.TABLE_[VIPER], null, "id = $id", null, null, null, null)
        val result: List<VIPER?> = toList(c)
        return if (result.isNotEmpty()) {
            result[0]
        } else {
            null
        }
    }

    override fun dropTable() {
        db?.execSQL("drop table if exists " + Constantes.TABLE_[VIPER] + ";")
    }

    override fun toList(c: Cursor?): List<VIPER?> {
        val result: MutableList<VIPER> = ArrayList()
        if (c!!.moveToFirst()) {
            do {
                val entity = VIPER()
                entity.id = c.getInt(c.getColumnIndex("id"))
                result.add(entity)
            } while (c.moveToNext())
        }
        c.close()
        return result
    }
}