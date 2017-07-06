using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Internship.ViewModels
{
    public class EmployementAgreement
    {
        [Key, ForeignKey("EmployementAgreementId")]
        public int Id { get; set; }
        public virtual EmployementAgreement EmployementAgreementId { get; set; }
        [ForeignKey("CPTformId")]
        public virtual CPTform CPTformId { get; set; }
        [ForeignKey("ApplicationId")]
        public virtual Application ApplicationId { get; set; }
        [ForeignKey("EmployerId")]
        public virtual Employer EmployerId { get; set; }
        [ForeignKey("LearningObjectiveId")]
        public virtual LearningObjective LearningObjectiveId { get; set; }
        [ForeignKey("UserId")]
        public virtual User UserId { get; set; }
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