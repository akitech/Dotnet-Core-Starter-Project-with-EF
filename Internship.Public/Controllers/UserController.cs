using Internship.Models;
using Internship.Public.Helpers;
using Internship.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Internship.Public.Controllers
{
    public class UserController : BaseController
    {
        #region Constructor
        private IUserService _userService { get; set; }
        private IConfiguration _configuration { get; set; }
        public UserController(IConfiguration configuration, IUserService userService)
        {
            _configuration = configuration;
            _userService = userService;
        }
        #endregion

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User model)
        {
            model.Email = model.Email + "@selu.edu";
            var user = _userService.GetUserByEmailAddress(model.Email);

            if (user == null)
            {
                ViewBag.Message = "Sorry, the account does not exist. Please register first.";
                return View();
            }

            if (!user.IsActive)
            {
                ViewBag.Message = "Sorry, your account is not verified. Please check your email and click on activation link.";
                return View();
            }

            if (!PasswordHelper.VerifyHashedPassword(model.Password, user.Password))
            {
                ViewBag.Message = "Sorry, the provided username and password does not match.";
                return View();
            }

            // Save User Session
            SetLoggedInUser(user);

            return Redirect("~/");
        }

        [HttpGet]
        public IActionResult Activate(string id)
        {
            var user = _userService.GetUserByToken(id);
            if(user == null)
            {
                ViewBag.Success = false;
                return View();
            }
            else
            {
                ViewBag.Success = true;
            }
            user.IsActive = true;
            user.Token = null;
            _userService.Update(user);
            _userService.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            user.Email = user.Email + "@selu.edu";
            if (_userService.GetUserByEmailAddress(user.Email) != null)
            {
                ViewBag.Message = "The account already exists. Please login.";
                return View();
            }

            user.UserType = UserType.Student;
            user.IsActive = false;
            user.Token = Guid.NewGuid().ToString();
            user.Password = PasswordHelper.GeneratePasswordHash(user.Password);
            user.CurrentAddress = new Address();
            user.PermanentAddress = new Address();
            _userService.Create(user);
            _userService.SaveChanges();
            ViewBag.Message = "Your account has been created. Please check your email to verify your email address.";

            // Send Email
            using (var emailProvider = new EmailProvider(_configuration))
            {
                var to = user.Email;
                var subject = "Verify your email address for CPT Request Form";
                var link = "http://localhost:2299/User/Activate/" + user.Token;

                var templateFileName = "Views\\EmailTemplates\\activate.html";
                var templateFilePath = Path.Combine(Directory.GetCurrentDirectory(), templateFileName);

                var message = System.IO.File.ReadAllText(templateFileName)
                                .Replace("{{name}}", user.FullName)
                                .Replace("{{link}}", link);

                emailProvider.Send(to, subject, message);
            }


            return View();
        }

    }
}
