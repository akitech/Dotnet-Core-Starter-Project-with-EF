using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internship.Models
{
    public class EmploymentAgreement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int EmployerId { get; set; }
        [Required]
        public int CPTFormId { get; set; }
        [Required]
        public int LearningObjectiveId { get; set; }
        [Required]
        public int ApplicationId { get; set; }
        [Required]
        public virtual User UserId { get; set; }

        public string DescriptionOfEmployment { get; set; }
        public DateTime EmploymentBeginDate { get; set; }
        public DateTime EmploymentEndDate { get; set; }

        public string JobTitle { get; set; }
        public string JobResponsibilities { get; set; }

        public SalaryType SalaryType { get; set; }
        public double Salary { get; set; }
        public double HoursPerWeek { get; set; }
    }
}