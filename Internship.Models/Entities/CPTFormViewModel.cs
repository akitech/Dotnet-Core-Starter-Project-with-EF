using System;
using System.Collections.Generic;
using System.Text;
//using Internship.Public;

namespace Internship.Models.Entities
{
    public class CPTFormViewModel
    {
        public CPTForm cptform { get; set; }
        public Application application { get; set; }
        public User user { get; set; }
        public EmploymentAgreement EmploymentAgreement { get; set; }

    }
}
