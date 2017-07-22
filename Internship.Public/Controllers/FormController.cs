using Microsoft.AspNetCore.Mvc;

namespace Internship.Public.Controllers
{
    public class FormController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CPTForm()
        {
            return View();
        }

        public ActionResult Application()
        {
            return View();
        }
        public ActionResult EmploymentAgreement()
        {
            return View();
        }
        public ActionResult LearningObjective()
        {
            return View();
        }
    }
}