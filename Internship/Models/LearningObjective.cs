using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Internship.Models
{
    public class LearningObjective
    {
        [Key] 
        public int LearningObjectiveId { get; set; }
        [Required]
        public int CPTformId { get; set; }
        [Required]
        public int EmployementAgreementId { get; set; }
        [Required]
        public int EmployerId { get; set; }
        [Required]
        public int ApplicationId { get; set; }
        [Required]
        public int UserId { get; set; }
        public string measureableLearningObjective1 { get; set; }
        public double supervisorsRatingOfLearningObjective1 { get; set; } //does this really have to be a double? or can it be something smaller, this comment goes for all the doubles in this class
        public string  measureableLearningObjective2 { get; set; }
        public double supervisorsRatingOfLearningObjective2 { get; set; }
        public string measureableLearningObjective3 { get; set; }
        public double supervisorsRatingOfLearningObjective3 { get; set; }
    }
}