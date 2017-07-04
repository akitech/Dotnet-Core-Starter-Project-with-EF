using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Internship.Models;

namespace Internship.Models
{
    public class CPTform
    {
        [Key]
        public int CPTformId { get; set; }
        [Required]
        public int ApplicationIdId { get; set; }
        [Required]
        public int EmploymentAgreementId { get; set; }
        [Required]
        public int EmployerId { get; set; }
        [Required]
        public int LearningObjectiveId { get; set; }
        [Required]
        public int UserId { get; set; }
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