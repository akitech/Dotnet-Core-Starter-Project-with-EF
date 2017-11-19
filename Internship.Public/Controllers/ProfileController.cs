using Internship.Models;
using Internship.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Internship.Public.Controllers
{
    public class ProfileController : BaseController
    {
        private IUserService _userService { get; set; }
        private IAddressService _addressService { get; set; }
        public ProfileController(IUserService service, IAddressService aService)
        {
            _userService = service;
            _addressService = aService;
        }

        [HttpGet]
        [Authorize(UserType.Student)]
        public IActionResult Edit()
        {
            var user = GetLoggedInUser();
            if (user.PermanentAddress == null)
            {
                user.PermanentAddress = new Address();
            }
            if (user.CurrentAddress == null)
            {
                user.CurrentAddress = new Address();
            }
            return View(user);
        }
        
        [HttpPost]
        [Authorize(UserType.Student)]
        public IActionResult Edit(User model)
        {
            var loggedInUser = GetLoggedInUser();


            _addressService.Update(model.CurrentAddress);
            _addressService.Update(model.PermanentAddress);
            _addressService.SaveChanges();

            // Patch selected data only
            var data = new Dictionary<string, object>();
            data["FirstName"] = model.FirstName;
            data["MiddleName"] = model.MiddleName;
            data["LastName"] = model.LastName;
            data["WNumber"] = model.WNumber;
            data["Degree"] = model.Degree;
            data["Concentration"] = model.Concentration;
            data["CellPhone"] = model.CellPhone;
            data["HomePhone"] = model.HomePhone;

            _userService.Patch(loggedInUser, data);
            _userService.SaveChanges();

            SetLoggedInUser(loggedInUser);

            return RedirectToDashboard("Your user profile has been saved");
        }



    }
}