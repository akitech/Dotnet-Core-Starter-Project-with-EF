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

            if (signedBy == "Advisor")
            {
                application.DateSignedByAcademicAdvisor = now;
            }
            else if (signedBy == "Instructor")
            {
                application.DateSignedByInstructor = now;
            }
            else if (signedBy == "Department")
            {
                application.DateSignedByDepartment = now;
            }
            else if (signedBy == "Dean")
            {
                application.DateSignedByDean = now;
            }
            else if (signedBy == "Supervisor")
            {
                application.DateSignedBySupervisorUponCompletion = now;
            }
            
            this._cptApplicationService.Update(application);
            this._cptApplicationService.SaveChanges();
            return RedirectToAction(signedBy,"Dashboard");
        }

        [Authorize]
        public IActionResult Employer()
        {
            var loggedInEmployer = GetLoggedInUser();
            var advisorForms = _cptApplicationService.GetStudentForms();
            return View(advisorForms);
        }

        [Authorize]
        public IActionResult Dean()
        {
            var loggedInDean = GetLoggedInUser();
            var departmentApprovedForms = _cptApplicationService.GetDepartmentApprovedForms();
            return View(departmentApprovedForms);
        }

        [Authorize]
        public IActionResult Instructor()
        {
            var loggedInInstructor = GetLoggedInUser();
            var advisorApprovedForms = _cptApplicationService.GetAdvisorApprovedForms();
            return View(advisorApprovedForms);
        }

        [Authorize]
        public IActionResult Department()
        {
            var loggedInDepartment = GetLoggedInUser();
            var instructorApprovedForms = _cptApplicationService.GetInstructorApprovedForms();
            return View(instructorApprovedForms);
        }

        [Authorize]
        public IActionResult Supervisor()
        {
            var loggedInSupervisor = GetLoggedInUser();
            var deanApprovedForms = _cptApplicationService.GetDeanApprovedForms();
            return View(deanApprovedForms);
        }

        public IActionResult StudentCPTApplicationDetails(int id, string viewedBy)
        {
            var application = this._cptApplicationService.GetById(id);
            return View(application);
        }

    }
}
