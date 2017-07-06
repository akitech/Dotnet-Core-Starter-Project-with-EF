using Internship.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Internship.Services
{
    public class GenericService<T> : IGenericService<T>, IDisposable where T : class
    {
        private DbContext context { get; set; }
        private DbSet<T> dbSet { get; set; }

        public GenericService(DbContext _context)
        {
            context = _context;
            dbSet = _context.Set<T>();
        }

        #region Basic Service Verbs

        public virtual IQueryable<T> All()
        {
            return dbSet;
        }
        public virtual DbSet<T> DbSet()
        {
            return dbSet;
        }

        public IQueryable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = dbSet.Where(predicate);
            return query;
        }

        public virtual T Find(int id)
        {
            return dbSet.Find(id);
        }

        public virtual void Create(T entity)
        {
            dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
            context.Entry(entity).State = EntityState.Deleted;
        }

        public void Patch(int id, Dictionary<string, object> dictionary)
        {
            var entity = dbSet.Find(id);
            context.Entry(entity).CurrentValues.SetValues(dictionary);
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Patch(T entity, Dictionary<string, object> dictionary)
        {
            context.Entry(entity).CurrentValues.SetValues(dictionary);
            context.Entry(entity).State = EntityState.Modified;
        }
        public virtual void SaveChanges()
        {
            context.SaveChanges();
        }

        public virtual void Dispose()
        {
            context.Dispose();
        }

        #endregion

    }
}
