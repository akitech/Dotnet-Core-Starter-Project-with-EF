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
        [ForeignKey("CPTform")]
        public int CPTformId { get; set; }
        [ForeignKey("EmploymentAgreement")]
        public int EmploymentAgreementId { get; set; }
        [ForeignKey("LearningObjective")]
        public int LearningObjectiveId { get; set; }
        [ForeignKey("Application")]
        public int ApplicationId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string employersName { get; set; }
        public string employersAddress { get; set; }
        public string supervisorTitle { get; set; }
        public string supervisorEmail { get; set; }
        public int supervisorPhone { get; set; }


    }
}