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
        //public string studentFirstName { get; set; }
        //public string studentMiddleName { get; set; }
        //public string studentLastName { get; set; }
        //public int wNum { get; set; }
        //public string studentEmail { get; set; }
        //public int studentCellPhone { get; set; }
        //public int studentWorkPhone { get; set; }
        //public string studentPresentAddress { get; set; }
        //public string studentPermanentAddress { get; set; }
        //public bool isStudentInternational { get; set; }
        //public enum userType { Type1, Type2 }

        //variables from tiak's user class

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public UserType UserType { get; set; }

        //Student Attributes:
        //MARK: TO-DO:
        //Maybe create a Student class that extends User?
        //Maybe create a Dean class that extends User? etc.

        public int WNumber { get; set; }

        [ForeignKey("CurrentAddress")]
        public int CurrentAddressId { get; set; }
        public Address CurrentAddress { get; set; }

        [ForeignKey("PermanentAddress")]
        public int PermanentAddressId { get; set; }
        public Address PermanentAddress { get; set; }

        public bool IsInternational { get; set; }

        public string Major { get; set; }

        public string Password { get; set; }
        public string Degree { get; set; }
        public int CreditHoursRegisteredInSemester { get; set; }
        public double MajorGPA { get; set; }
        public DateTime ExpectededGraduationDate { get; set; }
    }


}
