using Internship.Models;
using Internship.Public.Helpers;
using Internship.Services;
using Microsoft.AspNetCore.Mvc;
<<<<<<< Updated upstream
=======
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
>>>>>>> Stashed changes

namespace Internship.Public.Controllers
{
    public class DashboardController: BaseController
    {
        private ICptApplicationService _cptApplicationService;
        private IEmailProvider _emailProvider;
        public DashboardController(ICptApplicationService cptApplicationService, IEmailProvider emailProvider)
        {
            _cptApplicationService = cptApplicationService;
            this._emailProvider = emailProvider;
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

        [Authorize(UserType.AcademicAdvisor)]
        public IActionResult Advisor()
        {
<<<<<<< Updated upstream
            return View();
=======
            var loggedInAdvisor = GetLoggedInUser();
            var advisorForms = _cptApplicationService.GetStudentForms();
            ViewBag.Message = GetTemporaryMessage();
            return View(advisorForms);
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
>>>>>>> Stashed changes
        }


        [Authorize]
        public IActionResult Accept(string id, string signedBy)
        {
            int applicationId = System.Int32.Parse(id);
            var now = DateTime.Now;
            // var application = _cptApplicationService.Find(applicationId);
            var application = _cptApplicationService.Where(a => a.Id == applicationId)
                                .Include(a => a.Student)
                                .FirstOrDefault();

            application.IsRejected = false;
            application.ReasonsForNoneApproval = null;

            if (signedBy == "Advisor")
            {

                application.DateSignedByAcademicAdvisor = now;
                application.ApplicationStep = ApplicationStep.Instructor;

                _emailProvider.Send(application.Student.Email, "CPT Application Status",
                                "Your form has been approved by the advisor.");

            }
            else if (signedBy == "Instructor")
            {
                application.DateSignedByInstructor = now;
                application.ApplicationStep = ApplicationStep.Department;
                _emailProvider.Send(application.Student.Email, "CPT Application Status",
                    "Your form has been approved by Instructor.");
            }
            else if (signedBy == "Department")
            {
                application.DateSignedByDepartment = now;
                application.ApplicationStep = ApplicationStep.Dean;
                _emailProvider.Send(application.Student.Email, "CPT Application Status",
                    "Your form has been approved by Department Head.");
            }
            else if (signedBy == "Dean")
            {
                application.DateSignedByDean = now;
                application.ApplicationStep = ApplicationStep.Supervisor;
                _emailProvider.Send(application.Student.Email, "CPT Application Status",
                    "Your form has been approved by Dean.");

            }
            else if (signedBy == "Supervisor")
            {
                application.DateSignedBySupervisorUponCompletion = now;
                application.ApplicationStep = ApplicationStep.IsApproved;
                _emailProvider.Send(application.Student.Email, "CPT Application Status",
                     "Your form has been approved by Supervisor.");


            }

            SetTemporaryMessage("The application has been accepted");

            this._cptApplicationService.Update(application);
            this._cptApplicationService.SaveChanges();
            return RedirectToAction(signedBy,"Dashboard");
        }

        [HttpGet]
        public IActionResult Reject(int id)
        {
            var application = _cptApplicationService.GetById(id);
            return View(application);
        }

        [Authorize]
        public IActionResult Reject(int id, string ReasonsForNoneApproval)
        {
            int applicationId = id;          
            // var application = _cptApplicationService.Find(applicationId);
            var application = _cptApplicationService.Where(a => a.Id == applicationId)
                                .Include(a => a.Student)
                                .FirstOrDefault();
            application.IsRejected = true;
            application.ReasonsForNoneApproval = ReasonsForNoneApproval;

            if (application.ApplicationStep == ApplicationStep.AcademicAdvisor)
            {

                application.DateSignedByAcademicAdvisor = null;
                application.ApplicationStep = ApplicationStep.Instructor;

                _emailProvider.Send(application.Student.Email, "CPT Application Status",
                                "Your form has been rejected by the advisor.");

            }
            else if (application.ApplicationStep == ApplicationStep.Instructor)
            {
                application.DateSignedByInstructor = null;
                application.ApplicationStep = ApplicationStep.Department;
                _emailProvider.Send(application.Student.Email, "CPT Application Status",
                    "Your form has been rejected by Instructor.");
            }
            else if (application.ApplicationStep == ApplicationStep.Department)
            {
                application.DateSignedByDepartment = null;
                application.ApplicationStep = ApplicationStep.Dean;
                _emailProvider.Send(application.Student.Email, "CPT Application Status",
                    "Your form has been rejected by Department Head.");
            }
            else if (application.ApplicationStep == ApplicationStep.Dean)
            {
                application.DateSignedByDean = null;
                application.ApplicationStep = ApplicationStep.Supervisor;
                _emailProvider.Send(application.Student.Email, "CPT Application Status",
                    "Your form has been rejected by Dean.");

            }
            else if (application.ApplicationStep == ApplicationStep.Supervisor)
            {
                application.DateSignedBySupervisorUponCompletion = null;
                application.ApplicationStep = ApplicationStep.Supervisor;
                _emailProvider.Send(application.Student.Email, "CPT Application Status",
                     "Your form has been rejected by Supervisor.");


            }

            SetTemporaryMessage("The application has been rejected.");

            this._cptApplicationService.Update(application);
            this._cptApplicationService.SaveChanges();
            return RedirectToAction("Index");
        }

        /*[Authorize]
        public IActionResult Reject(string id, string signedBy)
        {
            int applicationId = System.Int32.Parse(id);
            var application = _cptApplicationService.Find(applicationId);
            application.IsRejected = true;

            SetTemporaryMessage("The application has been rejected.");

            this._cptApplicationService.Update(application);
            this._cptApplicationService.SaveChanges();
            return RedirectToAction(signedBy, "Dashboard");
        }*/

        
    }
}
