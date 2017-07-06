using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internship.Models
{
    public class Application
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        public bool IsPartTime { get; set; }
        public Semester InternshipSemester { get; set; }

        [ForeignKey("CPTForm")]
        public int CPTFormId { get; set; }
        public CPTForm CPTForm { get; set; }


        #region Signature(s) on various Levels
        //Follow the follwing step. The ReasonsForNoneApproval field
        //may be used by anyone. See: public ApplicationStep ApplicationAt
        public DateTime DateSignedByStudent { get; set; }
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
        public bool IsSignedByStudent => DateSignedByStudent != null;
        public bool IsSignedByInstructor => DateSignedByInstructor != null;
        public bool IsSignedByAcademicAdvisor => DateSignedByAcademicAdvisor != null;
        public bool IsSignedByDepartment => DateSignedByDepartment != null;
        public bool IsSignedByDean => DateSignedByDean != null;
        public bool IsSignedBySupervisorUponCompletion => DateSignedBySupervisorUponCompletion != null;


        //See Which Step the Application is stuck at:
        public ApplicationStep ApplicationAt
        {
            get
            {
                if (!IsSignedByStudent)
                    return ApplicationStep.Student;
                if (!IsSignedByInstructor)
                    return ApplicationStep.Instructor;
                if (!IsSignedByAcademicAdvisor)
                    return ApplicationStep.AcademicAdvisor;
                if (!IsSignedByDepartment)
                    return ApplicationStep.Department;
                if (!IsSignedByDean)
                    return ApplicationStep.Dean;

                //Awaiting Completion
                return ApplicationStep.Supervisor;
            }
        }

        //Means the Application is Approved and Student can start Internship
        public bool IsApproved => IsSignedByDean;
        //At the end, after the Supervisor signs
        public bool IsCompleted => IsSignedBySupervisorUponCompletion;

        #endregion



    }
}
