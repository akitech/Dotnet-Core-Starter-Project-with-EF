using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Internship.Models
{
    public class ApplicationViewModel
    {
        public Application application { get; set; }
        public User user { get; set; }
        public Employer employer { get; set; }
        public EmployementAgreement EmploymentAgreement { get; set; }

 
    }
}