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
        public string Degree { get; set; }
        public int CreditHoursRegisteredInSemester { get; set; }
        public double MajorGPA { get; set; }
        public DateTime ExpectededGraduationDate { get; set; }
    }




}