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
        [ForeignKey("CPTform")]
        public int CPTformId { get; set; }
        [ForeignKey("Application")]
        public int ApplicationId { get; set; }
        [ForeignKey("Employer")]
        public int EmployerId { get; set; }
        [ForeignKey("LearningObjectives")]
        public int LearningObjectivesId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
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