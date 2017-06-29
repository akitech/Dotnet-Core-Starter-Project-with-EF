using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Internship.Models
{
    public class User
    {
        public int Id { get; set; }
        public int WID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        [Display(Name = "Cell Number")]
        public int CellNumber { get; set; }

        [Display(Name = "Work Number")]
        public int WorkNumber { get; set; }

        [Display(Name = "Home Number")]
        public int HomeNumber { get; set; }

        [Display(Name = "Present Address")]
        public string PresentAddress { get; set; }

        [Display(Name = "Permanent Address")]
        public string PermanentAddress { get; set; }
    }
}