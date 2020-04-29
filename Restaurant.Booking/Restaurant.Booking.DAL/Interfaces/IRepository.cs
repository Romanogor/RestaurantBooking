using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Restaurant.Booking.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> rpedicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
            
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
