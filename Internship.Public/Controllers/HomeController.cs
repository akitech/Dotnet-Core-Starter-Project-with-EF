using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Internship.Public.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("~/User/Register");
        }

        public IActionResult Welcome()
        {
            return View();
        }


        public IActionResult Error()
        {
            return View();
        }

        public string Url()
        {

            var templateFileName = "Views\\EmailTemplates\\activate.html";
            var templateFilePath = Path.Combine(Directory.GetCurrentDirectory(), templateFileName);

            return System.IO.File.ReadAllText(templateFilePath);
        }
    }
}
