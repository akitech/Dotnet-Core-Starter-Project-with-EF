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
        public virtual CPTform CPTformId { get; set; }
        [ForeignKey("EmployementAgreement")]
        public virtual EmployementAgreement EmployementAgreementId { get; set; }
        [ForeignKey("LearningObjective")]
        public virtual LearningObjective LearningObjectiveId { get; set; }
        [ForeignKey("Application")]
        public virtual Application ApplicationId { get; set; }
        [ForeignKey("User")]
        public virtual User UserId { get; set; }
        public string employersName { get; set; }
        public string employersAddress { get; set; }
        public string supervisorTitle { get; set; }
        public string supervisorEmail { get; set; }
        public int supervisorPhone { get; set; }


    }
}