using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Internship.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }

        public string EmployersName { get; set; }

        [ForeignKey("EmployersAddress")]
        public int EmployersAddressId { get; set; }
        public Address EmployersAddress { get; set; }

        public string SupervisorName { get; set; }
        public string SupervisorTitle { get; set; }
        public string SupervisorEmail { get; set; }
        public int SupervisorPhone { get; set; }

    }
}