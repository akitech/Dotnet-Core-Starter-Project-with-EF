using System.ComponentModel;

namespace Internship.Models
{
    public enum Semester
    {
        Fall = 1,
        Spring = 2,
        Summer = 3
    }
    public enum ApplicationStep
    {
        Student = 1,       
        [Description("Academic Advisor")]
        AcademicAdvisor = 2,
        Instructor = 3,
        Department = 4,
        Dean = 5,
        Supervisor = 6,
        IsApproved = 7
    }
    public enum UserType
    {
        Student = 1,
        Instructor = 2,
        [Description("Academic Advisor")]
        AcademicAdvisor = 3,
        Department = 4,
        Dean = 5,
        Supervisor = 6 
    }
    public enum SalaryType
    {
        Hourly = 1,
        [Description("Bi-Weekly")]
        BiWeekly = 2,
        Monthly = 3,
        Aggregate = 4
    }

}