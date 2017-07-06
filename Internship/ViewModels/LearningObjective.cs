using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Internship.ViewModels
{
    public class LearningObjective
    {
        [Key, ForeignKey("LearningObjectiveId")]
        public int Id { get; set; }
        public virtual LearningObjective LearningObjectiveId { get; set; }
        [ForeignKey("CPTformId")]
        public virtual CPTform CPTformId { get; set; }
        [ForeignKey("EmployementAgreementId")]
        public virtual EmployementAgreement EmployementAgreementId { get; set; }
        [ForeignKey("EmployerId")]
        public virtual Employer EmployerId { get; set; }
        [ForeignKey("ApplicationId")]
        public virtual Application ApplicationId { get; set; }
        [ForeignKey("UserId")]
        public virtual User UserId { get; set; }
        public string measureableLearningObjective1 { get; set; }
        public double supervisorsRatingOfLearningObjective1 { get; set; } //does this really have to be a double? or can it be something smaller, this comment goes for all the doubles in this class
        public string  measureableLearningObjective2 { get; set; }
        public double supervisorsRatingOfLearningObjective2 { get; set; }
        public string measureableLearningObjective3 { get; set; }
        public double supervisorsRatingOfLearningObjective3 { get; set; }
    }
}