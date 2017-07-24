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
        public int EmployerId { get; set; }
     
        [Required]
        public int UserId { get; set; }
        [Required]
        public int EmploymentAgreementId { get; set; }
        public virtual EmploymentAgreement EmployementAgreement { get; set; }
        [Required]
        public int CPTFormId { get; set; }

        [Required]
        public int LearningObjectiveId { get; set; }
        public virtual LearningObjective LearningObjective { get; set; }
        [Required]
       
        public string employersName { get; set; }
        public string employersAddress { get; set; }
        public string supervisorName{ get; set; }
        public string supervisorTitle { get; set; }
        public string supervisorEmail { get; set; }
        public int supervisorPhone { get; set; }


    }
}