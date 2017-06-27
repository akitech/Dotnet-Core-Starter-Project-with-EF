using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Internship.Models
{
    public class Employer
    {
        public int EmployerId { get; set; }

        [Display(Name = "First Name")]
        public string EmployerFirstName { get; set; }

        [Display(Name = "Middle")]
        public string EmployerMiddleName { get; set; }

        [Display(Name = "Last Name")]
        public string EmployerLastName { get; set; }


    }
}