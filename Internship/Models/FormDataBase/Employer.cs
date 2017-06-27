using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Internship.Models
{
    public class Employer
    {
        public int EmployerId { get; set; }

        [Display(Name = "First Name")]
        public string EmployerFirstName { get; set; }

        [Display(Name = "Middle")]
        public string EmployerMiddleName { get; set; }

        [Display(Name = "Last Name")]
        public string EmployerLastName { get; set; }

        [Display(Name = "Employer's Address")]
        public string EmployersAddress { get; set; }

        [Display(Name = "Supervisor's Title")]
        public string SupervisorTitle { get; set; }

        [Display(Name = "Supervisor's Email")]
        public string EmployerEmail { get; set; }

        [Display(Name = "Supervisor's Phone")]
        public int EmployerCellNumber { get; set; }

        [Display(Name = "Employment Begining Date")]
        [DataType(DataType.Date)]
        public DateTime EmployBeginDate { get; set; }

        [Display(Name = "Employment Ending Date")]
        [DataType(DataType.Date)]
        public DateTime EmployEndingDate { get; set; }

        
        public enum PartFull
        {
            [Display(Name = "Part Time")]
            PartTime,
            [Display(Name = "Full Time")]
            FullTime
        }

        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [Display(Name = "Job Responsibilites")]
        public string JobResp { get; set; }
        public enum SalarayType
        {
            Biweekly,
            Monthly,
            Hourly
        }

        public string Signature { get; set; }

        [Display(Name = "Student Signature Date")]
        [DataType(DataType.Date)]
        public DateTime StudentSigDate { get; set; }


    }
}