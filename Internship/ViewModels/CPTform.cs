using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Internship.ViewModels;

namespace Internship.ViewModels
{
    public class CPTform
    {
        [Key, ForeignKey("CPTformId")]
        public int Id { get; set; }
        public virtual CPTform CPTformId { get; set; }
        [ForeignKey("ApplicationId")]
        public virtual Application ApplicationId { get; set; }
        [ForeignKey("EmployementAgreementId")]
        public virtual EmployementAgreement EmploymentAgreementId { get; set; }
        [ForeignKey("EmployerId")]
        public virtual Employer EmployerId { get; set; }
        [ForeignKey("LearningObjectiveId")]
        public virtual LearningObjective LearningObjectiveId { get; set; }
        [ForeignKey("UserId")]
        public virtual User UserId { get; set; }
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