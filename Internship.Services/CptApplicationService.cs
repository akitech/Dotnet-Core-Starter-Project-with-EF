using Internship.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Internship.Services
{

    public class CptApplicationService : GenericService<CptApplication>, ICptApplicationService
    {
        public CptApplicationService(InternshipContext _context) : base(_context)
        {
        }

        public CptApplication GetById(int id)
        {
            return Where(app => app.Id == id)
                .Include(app => app.Employer)
                .Include(app => app.Student)
                .Include(app => app.Supervisor)
                .Include(app => app.LearningObjectives)
                .Include(app => app.EmploymentAgreement)
                .Include(app => app.Advisor)
                .FirstOrDefault();
        }

        public List<CptApplication> GetStudentForms(int studentId)
        {
            return Where(app => app.StudentId == studentId)
                .Include(app => app.Employer)
                .Include(app => app.Student)
                .Include(app => app.Supervisor)
                .Include(app => app.LearningObjectives)
                .Include(app => app.EmploymentAgreement)
                .Include(app => app.Advisor)
                .ToList();
        }

    }
}
