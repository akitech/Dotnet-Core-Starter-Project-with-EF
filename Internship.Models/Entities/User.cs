using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace Internship.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public int CPTFormId { get; set; }
        [Required]
        public int EmploymentAgreementId { get; set; }
        [Required]
        public int EmployerId { get; set; }
        [Required]
        public int ApplicationId { get; set; }
        [Required]
        public int LearningObjectiveId { get; set; }
        public string studentFirstName { get; set; }
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