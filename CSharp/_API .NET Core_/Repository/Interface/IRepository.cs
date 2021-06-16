//
//  IRepository.cs
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using VIPER.Entity;
using Microsoft.EntityFrameworkCore;

namespace VIPER.Repository.Interface
{
    public interface IRepository<T>
    {
        DbContext GetContext();
        string Insert(T entity);
        string Update(T entity);
        string Delete(T entity);
        string Delete(int id);
        void Cancel(T entity);
        string JoinEntity<TEntity>(ICollection<TEntity> list, string s) where TEntity : BaseClass;
        IQueryable<T> Filter(string condition);
        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        IQueryable<T> GetTop(int n);
        T GetById(int id);
        int GetCount();
        string SaveChanges();
    }
}
