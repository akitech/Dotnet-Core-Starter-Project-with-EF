using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Internship.Models
{
    public class EmployementAgreement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public virtual CPTform CPTform { get; set; }
        [Required]
        public virtual Application Application { get; set; }
        [Required]
        public virtual Employer Employer { get; set; }
        [Required]
        public virtual LearningObjective LearningObjective { get; set; }
        [Required]
        public virtual User User { get; set; }
        public double hoursPerWeek { get; set; }
        public string descriptionOfEmployment { get; set; }
        public DateTime employmentBeginDate { get; set; }
        public DateTime employmentEndingDate { get; set; }
        public string jobTitle { get; set; }
        public string jobResponsibilities { get; set; }
        public enum salaryType { BiWeekly, Monthly, Hourly }
        public double salary { get; set; }  //is double really nessary??? 
    }
}