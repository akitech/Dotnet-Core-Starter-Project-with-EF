using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Internship.ViewModels
{
    public class Employer
    {
        [Key, ForeignKey("EmployerId")]
        public int Id { get; set; }
        public virtual Employer EmployerId { get; set; }
        [ForeignKey("CPTformId")]
        public virtual CPTform CPTformId { get; set; }
        [ForeignKey("EmployementAgreementId")]
        public virtual EmployementAgreement EmployementAgreementId { get; set; }
        [ForeignKey("LearningObjectiveId")]
        public virtual LearningObjective LearningObjectiveId { get; set; }
        [ForeignKey("ApplicationId")]
        public virtual Application ApplicationId { get; set; }
        [ForeignKey("UserId")]
        public virtual User UserId { get; set; }
        public string employersName { get; set; }
        public string employersAddress { get; set; }
        public string supervisorTitle { get; set; }
        public string supervisorEmail { get; set; }
        public int supervisorPhone { get; set; }


    }
}