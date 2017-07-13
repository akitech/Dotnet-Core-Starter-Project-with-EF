using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Internship.Controllers
{
    public class FormController : Controller
    {
        // GET: CPTForm
        

        public ActionResult CPTForm()
        {
            return View();
        }

        public ActionResult Application()
        {
            return View();
        }
        public ActionResult EmployementAgreement()
        {
            return View();
        }
        public ActionResult LearningObjective() {
            return View();
        }
    }
}