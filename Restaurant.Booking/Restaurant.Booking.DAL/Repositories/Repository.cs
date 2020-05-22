using Restaurant.Booking.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Booking.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext Context;

        public Repository(ApplicationDbContext context)
        {
            Context = context;
        }
        public async Task<TEntity> Get(int id)
        {
            return await Task.Run(() => Context.Set<TEntity>().Find(id));
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await Task.Run(() => Context.Set<TEntity>().ToList());
        }

        public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return await Task.Run(() => Context.Set<TEntity>().Where(predicate));
        }

        public async void Add(TEntity entity)
        {
            await Task.Run(() => Context.Set<TEntity>().Add(entity));
        }

        public async void AddRange(IEnumerable<TEntity> entities)
        {
            await Task.Run(() => Context.Set<TEntity>().AddRange(entities));
        }


        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }
    }
}
