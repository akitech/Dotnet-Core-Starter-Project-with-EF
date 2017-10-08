using Internship.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Internship.Services
{
    public class UserService : GenericService<User>, IUserService
    {
        public UserService(InternshipContext _context) : base(_context)
        {
        }

        public User GetUserByEmailAddress(string email)
        {
            return
                 Where(u => u.Email == email)
                .IncludeAddress()
                .FirstOrDefault();
        }
        public User GetUserByToken(string token)
        {
            return
                 Where(u => u.Token == token)
                .FirstOrDefault();
        }

        public override User Find(int id)
        {
            return 
                Where(u => u.Id == id)
               .IncludeAddress()
               .FirstOrDefault();
        }

        public List<User> SearchByName(string keyword)
        {
            return
                Where(u => u.FirstName.Contains(keyword) ||
                           u.LastName.Contains(keyword))
                .IncludeAddress()
                .ToList();
        }

    }

    public static class UserServiceExtensions
    {
        public static IQueryable<User> IncludeAddress(this IQueryable<User> set)
        {
            return set
                .Include("CurrentAddress")
                .Include("PermanentAddress");
        }
    }

}
