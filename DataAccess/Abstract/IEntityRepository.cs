﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entity.Abstract;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void UpdateColumn(T entity, Expression<Func<T, object>>[] properties);
    }
}