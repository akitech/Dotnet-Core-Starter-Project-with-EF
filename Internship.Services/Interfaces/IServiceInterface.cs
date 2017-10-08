using Internship.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Internship.Services
{
    public interface IGenericService<T> where T : class
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

    public interface IUserService : IGenericService<User>
    {
        User GetUserByEmailAddress(string email);
        User GetUserByToken(string token);
    }

    public interface IAddressService : IGenericService<Address>
    {

    }

    public interface ICptApplicationService : IGenericService<CptApplication>
    {
        CptApplication GetById(int id);
        List<CptApplication> GetByStudentId(int studentId);
    }

}
