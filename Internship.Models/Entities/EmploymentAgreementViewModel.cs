namespace Internship.Models.Entities
{
    public class EmployementAgreementViewModel
    {
        public User user { get; set; }

        public Employer employer { get; set; }
        public Application application { get; set; }
        public EmploymentAgreement EmploymentAgreement { get; set; }


    }

}