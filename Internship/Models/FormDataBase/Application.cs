using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Internship.Models
{
    public class Application
    {
        [Key]
        public int FormId { get; set; }
        public string Degree { get; set; }

        public string Concentration { get; set; }

        [Display(Name = "Semester Hours Earned")]
        public int SemesterHoursEarned { get; set; }

        [Display(Name = "Major GPA")]
        public decimal MajorGPA { get; set; }

        [Display(Name = "Expected Graduation Time")]
        [DataType(DataType.Date)]
        public DateTime ExpectedGraduationTime { get; set; }
        public enum IsAppApproved
        {
            Yes,
            No
        }
    }
}