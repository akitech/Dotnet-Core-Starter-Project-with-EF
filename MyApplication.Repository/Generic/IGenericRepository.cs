using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApplication.Repository.Generic
{
    interface IGenericRepository<T> where T : class
    {
        DbSet<T> DbSet();
        IQueryable<T> All();
        IQueryable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        T Find(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Patch(int id, Dictionary<string, object> dictionary);
        void Patch(T entity, Dictionary<string, object> dictionary);
        void SaveChanges();
        void Dispose();
    }
}
