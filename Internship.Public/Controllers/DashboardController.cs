using Internship.Models;
using Internship.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Internship.Public.Controllers
{
    public class DashboardController: BaseController
    {
        private ICptApplicationService _cptApplicationService;
        public DashboardController(ICptApplicationService cptApplicationService)
        {
            _cptApplicationService = cptApplicationService;
        }

        [Authorize]
        public IActionResult Index()
        {
            // Take People to their dashboard
            var loggedInUser = GetLoggedInUser();
            switch (loggedInUser.UserType)
            {

                case UserType.Student:
                    return RedirectToAction("Student", "Dashboard");

                case UserType.AcademicAdvisor:
                    return RedirectToAction("Advisor", "Dashboard");

                default:
                    return RedirectToAction("UnauthorizedUser");
            }
        }
        
        [Authorize(UserType.Student)]
        public IActionResult Student()
        {
            ViewBag.Message = GetTemporaryMessage();

            var loggedInStudent = GetLoggedInUser();
            var studentForms = _cptApplicationService.GetStudentForms(loggedInStudent.Id);
            return View(studentForms);

        }

        [Authorize]
        public IActionResult Advisor()
        {
            var loggedInAdvisor = GetLoggedInUser();
            var advisorForms = _cptApplicationService.GetStudentForms();
            return View(advisorForms);
        }

        [Authorize]
        public IActionResult Accept(string id, string signedBy)
        {
            int applicationId = System.Int32.Parse(id);
            var now = DateTime.Now;
            var application = _cptApplicationService.Find(applicationId);

            if (signedBy == "advisor")
            {
                application.DateSignedByAcademicAdvisor = now;
            } else if (signedBy == "instructor")
            {
                application.DateSignedByInstructor = now;
            } else if (signedBy == "dean")
            {
                application.DateSignedByDean = now;
            } else if (signedBy == "supervisor")
            {
                application.DateSignedBySupervisorUponCompletion = now;
            }

            this._cptApplicationService.Update(application);
            this._cptApplicationService.SaveChanges();
            return RedirectToAction("Advisor", "Dashboard");
        }

        [Authorize]
        public IActionResult Employer()
        {
            var loggedInAdvisor = GetLoggedInUser();
            var advisorForms = _cptApplicationService.GetStudentForms();
            return View(advisorForms);
        }

        [Authorize]
        public IActionResult Dean()
        {
            var loggedInAdvisor = GetLoggedInUser();
            var advisorForms = _cptApplicationService.GetStudentForms();
            return View(advisorForms);
        }

        [Authorize]
        public IActionResult Instructor()
        {
            var loggedInAdvisor = GetLoggedInUser();
            var advisorApprovedForms = _cptApplicationService.GetAdvisorApprovedForms();
            return View(advisorApprovedForms);
        }

        [Authorize]
        public IActionResult Department()
        {
            var instructorApprovedForms = _cptApplicationService.GetInstructorApprovedForms();
            return View(instructorApprovedForms);
        }

    }
}
