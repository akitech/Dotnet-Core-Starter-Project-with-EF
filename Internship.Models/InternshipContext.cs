using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;

namespace Internship.Models
{
    public class InternshipContext : DbContext
    {

        #region Constructors

        //Constructor for Dependency Injection:
        //TODO: In Future, maybe Dependency Injection is the way to go.
        //public InternshipContext(DbContextOptions<InternshipContext> options) : base(options)
        //{
        //}

        public InternshipContext()
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }


        protected static string DbConnectionString { get; set; }

        public static void SetConnectionString(string _DbConnectionString)
        {
            DbConnectionString = _DbConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SetConnectionString("Server=(localdb)\\mssqllocaldb;Database=Internship_v2;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(DbConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
        #endregion

        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<CPTForm> CPTForms { get; set; }
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