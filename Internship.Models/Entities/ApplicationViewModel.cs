using System;
using System.Collections.Generic;
using System.Text;

namespace Internship.Models.Entities
    class ApplicationViewModel
    {
        public Application application { get; set; }
        public User user { get; set; }
        public Employer employer { get; set; }
        public EmploymentAgreement EmploymentAgreement { get; set; }

    }
}
