using System;
using System.Collections.Generic;
using System.Linq;

namespace Internship.Models
{
    public class EmployementAgreementViewModel
    {
        public User user { get; set; }

        public Employer employer { get; set; }
        public Application application { get; set; }
        public EmploymentAgreement EmploymentAgreement { get; set; }


    }

}