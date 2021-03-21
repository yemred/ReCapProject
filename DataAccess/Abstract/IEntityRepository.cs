
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        void Add(T entity);
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T GeTById(Expression<Func<T, bool>> filter);
        void Update(T entitiy);
        void Delete(T entity);

    }
}
