using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Internship.Models
{
    public class Employer
    {

        public Employer()
        {
            EmployersAddress = new Address();
        }

        [Key]
        public int Id { get; set; }

        public string CompanyName { get; set; }
        public string EmployersName { get; set; }
        public int EmployersAddressId { get; set; }
        [ForeignKey("EmployersAddressId")]
        public Address EmployersAddress { get; set; }

        public string SupervisorName { get; set; }
        public string SupervisorTitle { get; set; }
        public string SupervisorEmail { get; set; }
        public int SupervisorPhone { get; set; }

    }
}