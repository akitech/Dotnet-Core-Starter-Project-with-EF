using Internship.Models;
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
                return View();
            }
        }
        

        [Authorize(UserType.Dean)]
        public string Dean()
        {
            return "Hi, dean";
        }


        [Authorize(UserType.Student)]
        public string Student()
        {
            return "Hi, student";
        }

        [Authorize]
        public string NormalLogin()
        {
            return "Hi, user";
        }


        public string UnauthorizedUser()
        {
            return "Sorry, you are not authorized to view this page. Please login with proper credentials.";
        }

    }
    
}
