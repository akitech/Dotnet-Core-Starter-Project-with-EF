using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Internship.ViewModels
{
    public class User
    {
        [Key, ForeignKey("UserId")]
        public int Id { get; set; }
        public virtual User UserId { get; set; }
        [ForeignKey("CPTformId")]
        public virtual CPTform CPTformId { get; set; }
        [ForeignKey("EmployementAgreementId")]
        public virtual EmployementAgreement EmployementAgreementId { get; set; }
        [ForeignKey("EmployerId")]
        public virtual Employer EmployerId { get; set; }
        [ForeignKey("ApplicationId")]
        public virtual Application ApplicationId { get; set; }
        [ForeignKey("LearningObjectiveId")]
        public virtual LearningObjective LearningObjectiveId { get; set; }
        public string studentFirstNameerty { get; set; }
        public string studentMiddleName { get; set; }
        public string studentLastName { get; set; }
        public int wNum { get; set; }
        public string studentEmail { get; set; }
        public int studentCellPhone { get; set; }
        public int studentWorkPhone { get; set; }
        public string studentPresentAddress { get; set; }
        public string studentPermanentAddress { get; set; }
        public bool isStudentInternational { get; set; }
        public enum userType { Type1, Type2 }


    }
}