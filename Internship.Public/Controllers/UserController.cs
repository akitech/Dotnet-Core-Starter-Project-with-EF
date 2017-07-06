using Internship.Models;
using Internship.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internship.Public.Controllers
{
    public class UserController : Controller
    {
        #region Constructor
        private IUserService userService { get; set; }
        public UserController()
        {
            userService = new UserService(new InternshipContext());
        }

        #endregion

        public IActionResult Create()
        {
            var user = new User();
            return View("Edit", user);
        }

        public IActionResult Edit(int Id)
        {
            var user = userService.Find(Id);
            return View("Edit", user);
        }

        public IActionResult Save(User user)
        {
            if (user.Id == 0) //Means a new user
            {
                userService.Create(user);
            }
            else
            {
                userService.Update(user);
            }

            userService.SaveChanges();
            return RedirectToAction("Edit", new { Id = user.Id });
        }

    }
}
