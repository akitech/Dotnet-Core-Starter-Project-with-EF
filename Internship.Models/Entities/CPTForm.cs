
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internship.Models
{
    public class CPTForm
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("Employer")]
        public int EmployerId { get; set; }
        public Employer Employer { get; set; }


        [ForeignKey("EmploymentAgreement")]
        public int EmploymentAgreementId { get; set; }
        public EmploymentAgreement EmploymentAgreement { get; set; }


        [ForeignKey("LearningObjective")]
        public int LeaningObjectiveId { get; set; }
        public LearningObjective LearningObjective { get; set; }

    }
}