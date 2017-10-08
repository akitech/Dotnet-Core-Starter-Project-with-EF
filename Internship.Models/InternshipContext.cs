using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Internship.Models
{
    public class InternshipContext : DbContext
    {

        #region Constructors

        //Constructor for Dependency Injection:
        public InternshipContext(DbContextOptions<InternshipContext> options) : base(options)
        {
        }

        public InternshipContext()
        {
        }


        protected static string DbConnectionString { get; set; }

        public static void SetConnectionString(string _DbConnectionString)
        {
            DbConnectionString = _DbConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SetConnectionString("Server=DESKTOP-DVFQKOP\\SQLEXPRESS;Database=CPTRequestForm;Trusted_Connection=True;MultipleActiveResultSets=true;");
            optionsBuilder.UseSqlServer(DbConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
        #endregion

        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CptApplication> CptApplications { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<EmploymentAgreement> EmployementAgreements { get; set; }
        public DbSet<LearningObjective> LearningObjectives { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

    }

}