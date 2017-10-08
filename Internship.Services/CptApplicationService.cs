using Internship.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
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
                .Include(app => app.LearningObjectives)
                .Include(app => app.EmploymentAgreement)
                .FirstOrDefault();
        }

        public List<CptApplication> GetByStudentId(int studentId)
        {
            return Where(app => app.StudentId == studentId)
                .Include(app => app.Employer)
                .Include(app => app.Student)
                .Include(app => app.LearningObjectives)
                .Include(app => app.EmploymentAgreement)
                .ToList();
        }

    }
}
