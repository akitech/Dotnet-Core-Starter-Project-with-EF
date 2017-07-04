using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Internship.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public virtual CPTform CPTform { get; set; }
        [Required]
        public virtual EmployementAgreement EmployementAgreement { get; set; }
        [Required]
        public virtual LearningObjective LearningObjective { get; set; }
        [Required]
        public virtual Application Application { get; set; }
        [Required]
        public virtual User User { get; set; }
        public string employersName { get; set; }
        public string employersAddress { get; set; }
        public string supervisorTitle { get; set; }
        public string supervisorEmail { get; set; }
        public int supervisorPhone { get; set; }


    }
}