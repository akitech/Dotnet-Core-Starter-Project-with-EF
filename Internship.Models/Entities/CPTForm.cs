using System;
using System.ComponentModel.DataAnnotations;

namespace Internship.Models
{
    public class CPTForm
    {
        [Key]
        public int CPTFormId { get; set; }
        [Required]
        public int EmploymentAgreementId { get; set; }
        public virtual EmploymentAgreement EmployementAgreement { get; set; }
        [Required]
        public int EmployerId { get; set; }
        public virtual Employer Employer { get; set; }
        [Required]
        public int LearningObjectiveId { get; set; }
        public virtual LearningObjective LearningObjective { get; set; }
   
        public enum CptRecommendationType
        {
            mandatoryForGraduation,
            employmentWillResultInAcademicCredit
        }
        public string CourseName { get; set; }

        public string AcademicAdvisorName { get; set; }

        public int AcademicAdvisorTelephone { get; set; }

        public string AcademicAdvisorEmail { get; set; }

        public bool IsEmployedCurrentlyOnCampus { get; set; }

        public bool IsEmployedCurrentlyOffCampus { get; set; }

        public bool IsRequestForSummerEmployment { get; set; }
        public enum IsEligibleAndIntendToEnrollFTFallSem
        {
            yes,
            no,
            notApplicable
        }
        public bool HasPreviousCptAuthorization1 { get; set; }
        public DateTime BeginningEmploymentDateOfPreviousCptAuthorization1 { get; set; }
        public DateTime EndingEmploymentDateOfPreviousCptAuthorization1 { get; set; }
        public bool WasPreviousCptAuthorizationPartTime1 { get; set; }
        public bool HasPreviousCptAuthorization2 { get; set; }
        public DateTime BeginningEmploymentDateOfPreviousCptAuthorization2 { get; set; }
        public DateTime EndingEmploymentDateOfPreviousCptAuthorization2 { get; set; }
        public bool WasPreviousCptAuthorizationPartTime2 { get; set; }
    }

}