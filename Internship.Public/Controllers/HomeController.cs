using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Internship.Models;

namespace Internship.Public.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("~/User/Create");
        }

        public IActionResult Welcome()
        {
            return View();
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
