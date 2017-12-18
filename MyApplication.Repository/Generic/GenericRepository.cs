using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApplication.Repository.Generic
{
    public class GenericRepository<T> : IGenericRepository<T>, IDisposable where T : class
    {
        private DbContext _dbContext { get; set; }
        private DbSet<T> _dbSet { get; set; }

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        #region Basic Service Verbs

        public virtual IQueryable<T> All()
        {
            return _dbSet;
        }
        public virtual DbSet<T> DbSet()
        {
            return _dbSet;
        }

        public IQueryable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _dbSet.Where(predicate);
            return query;
        }

        public virtual T Find(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Create(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _dbContext.Entry(entity).State = EntityState.Deleted;
        }

        public void Patch(int id, Dictionary<string, object> dictionary)
        {
            var entity = _dbSet.Find(id);
            _dbContext.Entry(entity).CurrentValues.SetValues(dictionary);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Patch(T entity, Dictionary<string, object> dictionary)
        {
            _dbContext.Entry(entity).CurrentValues.SetValues(dictionary);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
        public virtual void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public virtual void Dispose()
        {
            _dbContext.Dispose();
        }

        #endregion

    }
}
