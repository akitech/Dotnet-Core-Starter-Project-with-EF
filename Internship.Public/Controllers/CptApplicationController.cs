using Internship.Models;
using Internship.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Internship.Public.Controllers
{
    public class CptApplicationController : BaseController
    {
        private ICptApplicationService _cptApplicationService { get; set; }
        public CptApplicationController(ICptApplicationService service)
        {
            _cptApplicationService = service;
        }

        [HttpGet]
        public IActionResult Student(int? id)
        {
            CptApplication model = null; 
            if (id != null && id > 0)
            {
                model = _cptApplicationService.GetById(id.Value);
            }
            else
            {
                model = new CptApplication();
                var loggedInUser = GetLoggedInUser();
                if (loggedInUser.UserType != UserType.Student)
                {
                    throw new Exception("Only students can initiate a CPT Form.");
                }
                model.StudentId = loggedInUser.Id;
                model.Student = loggedInUser;
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Student(CptApplication app)
        {
            try
            {
                app.ApplicationStep = ApplicationStep.AcademicAdvisor;
                if (app.Id == 0)
                {
                    _cptApplicationService.Create(app);
                }
                else
                {
                    _cptApplicationService.Update(app);
                }
                _cptApplicationService.SaveChanges();
                return RedirectToDashboard("Your application has been saved.");
            }
            catch (Exception ex)
            {
                throw new Exception("The application failed to save. Error: " + ex.Message + "\n" + JsonConvert.SerializeObject(app, Formatting.Indented));
            }

        }


        [HttpGet]
        public IActionResult Advisor(int? id)
        {
            var application = new CptApplication();
            if (id.HasValue || id.Value > 0)
            {
                application = _cptApplicationService.GetById(id.Value);
            }
            return View(application);
        }

        [HttpGet]
        public IActionResult Instructor(int? id)
        {
            var application = new CptApplication();
            if (id.HasValue && id.Value > 0)
            {
                application = _cptApplicationService.GetById(id.Value);
            }
            return View(application);
        }

        [HttpGet]
        public IActionResult Dean(int? id)
        {
            var application = new CptApplication();
            if (id.HasValue && id.Value > 0)
            {
                application = _cptApplicationService.GetById(id.Value);
            }
            return View(application);
        }

        [HttpGet]
        public IActionResult Supervisor(int? id)
        {
            var application = new CptApplication();
            if (id.HasValue && id.Value > 0)
            {
                application = _cptApplicationService.GetById(id.Value);
            }
            return View(application);
        }



    }
}