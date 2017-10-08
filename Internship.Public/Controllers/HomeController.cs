using Microsoft.AspNetCore.Mvc;

namespace Internship.Public.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            var loggedInUser = GetLoggedInUser();
            if (loggedInUser == null)
            {
                return Redirect("~/User/Login");
            }
            else
            {
                return Redirect("~/Home/Welcome");
            }
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
