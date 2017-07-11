using Internship.Models;
using Internship.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internship.Public.Controllers
{
    public class AuthController : Controller
    {
        #region Constructor
        private IUserService userService { get; set; }
        public AuthController()
        {
            userService = new UserService(new InternshipContext());
        }

        #endregion

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User formPostedData)
        {
            var user = userService.GetUserByEmailAddress(formPostedData.Email);

            if (formPostedData.Password == user.Password)
            {
                return Redirect("~/Home/Welcome");
                //Same as:
                //RedirectToAction("Login", "Welcome");
            }

            else
            {
                return RedirectToAction("Login");
            }


        }
    }
}
