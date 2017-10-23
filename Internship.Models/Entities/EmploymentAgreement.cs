using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internship.Models
{
    public class EmploymentAgreement
    {
        [Key]
        public int Id { get; set; }

        // We link to Cpt applications with this foreign key:
        //public int CptApplicationId { get; set; }
        //[ForeignKey("CptApplicationId")]
        //public virtual CptApplication CptApplication { get; set; }

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