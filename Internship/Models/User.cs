using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Internship.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public virtual CPTform CPTform { get; set; }
        [Required]
        public virtual EmployementAgreement EmployementAgreement { get; set; }
        [Required]
        public virtual Employer Employer { get; set; }
        [Required]
        public virtual Application Application { get; set; }
        [Required]
        public virtual LearningObjective LearningObjective { get; set; }
        public string studentFirstNameerty { get; set; }
        public string studentMiddleName { get; set; }
        public string studentLastName { get; set; }
        public int wNum { get; set; }
        public string studentEmail { get; set; }
        public int studentCellPhone { get; set; }
        public int studentWorkPhone { get; set; }
        public string studentPresentAddress { get; set; }
        public string studentPermanentAddress { get; set; }
        public bool isStudentInternational { get; set; }
        public enum userType { Type1, Type2 }


    }
}