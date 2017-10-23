using Internship.Models;
using Internship.Services;
using Microsoft.AspNetCore.Mvc;

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

        [Authorize(UserType.AcademicAdvisor)]
        public IActionResult Advisor()
        {
            return View();
        }

    }
}
