using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internship.Models
{
    public class CptApplication
    {
        public CptApplication()
        {
            ApplicationStep = ApplicationStep.Student;
            LearningObjectives = new List<LearningObjective>();
            Employer = new Employer();
            EmploymentAgreement = new EmploymentAgreement();
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            DateSignedByDean = DateTime.Now;
            DateSignedByStudent = DateTime.Now;
            DateSignedByDepartment = DateTime.Now;
            DateSignedByInstructor = DateTime.Now;
            DateSignedByEmployer = DateTime.Now;
            DateSignedBySupervisorUponCompletion = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual User Student { get; set; }

        public bool IsPartTime { get; set; }
        public Semester InternshipSemester { get; set; }
        public ApplicationStep ApplicationStep { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int EmployerId { get; set; }
        [ForeignKey("EmployerId")]
        public Employer Employer { get; set; }

        public int AdvisorId { get; set; }
        [ForeignKey("AdvisorId")]
        public User Advisor { get; set; }

        public int EmploymentAgreementId { get; set; }
        [ForeignKey("EmploymentAgreementId")]
        public EmploymentAgreement EmploymentAgreement { get; set; }

        public List<LearningObjective> LearningObjectives { get; set; }


        #region Signature(s) on various Levels
        //Follow the follwing step. The ReasonsForNoneApproval field
        //may be used by anyone. See: public ApplicationStep ApplicationAt
        public DateTime DateSignedByStudent { get; set; }
        public DateTime DateSignedByEmployer { get; set; }
        public DateTime DateSignedByInstructor { get; set; }
        public DateTime DateSignedByAcademicAdvisor { get; set; }
        public DateTime DateSignedByDepartment { get; set; }
        public DateTime DateSignedByDean { get; set; }
        public DateTime DateSignedBySupervisorUponCompletion { get; set; }
        public string ReasonsForNoneApproval { get; set; }

        
        //Note these are not properties on database,
        //but only get fields which will be evalauted as necessary.
        //The idea is, if date is there, it is signed.
        //Reduces Redundancy.
        [NotMapped]
        public bool IsSignedByStudent => DateSignedByStudent != null;
        [NotMapped]
        public bool IsSignedByInstructor => DateSignedByInstructor != null;
        [NotMapped]
        public bool IsSignedByAcademicAdvisor => DateSignedByAcademicAdvisor != null;
        [NotMapped]
        public bool IsSignedByDepartment => DateSignedByDepartment != null;
        [NotMapped]
        public bool IsSignedByDean => DateSignedByDean != null;
        [NotMapped]
        public bool IsSignedBySupervisorUponCompletion => DateSignedBySupervisorUponCompletion != null;
        //Means the Application is Approved and Student can start Internship        
        [NotMapped]
        public bool IsApproved => IsSignedByDean;
        //At the end, after the Supervisor signs
        [NotMapped]
        public bool IsCompleted => IsSignedBySupervisorUponCompletion;


        #endregion



    }
}
