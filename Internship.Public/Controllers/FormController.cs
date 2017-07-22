using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Internship.Public.Controllers
{
    public class FormController : Controller
    {


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