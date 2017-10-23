using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
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
            if (!optionsBuilder.IsConfigured)
            {
                var appSettingsPath = Directory.GetCurrentDirectory();
                var appsettings = Path.Combine(appSettingsPath, "appsettings.json");

                // If appsettings.json does not exist on this project, check on Web Project.
                // This to be used only when Dependency Injection is not posible
                // Example: EF Core CLI, Unit Testing.
                if (!File.Exists(appsettings))
                    appSettingsPath = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), "Internship.Public");

                // Build Configuration:
                var configuration = new ConfigurationBuilder().SetBasePath(appSettingsPath)
                   .AddJsonFile("appsettings.json", optional: true)
                   .AddJsonFile("appsettings.Development.json", optional: true)
                   .Build();

                // Check if configuration is good:
                if (string.IsNullOrEmpty(configuration.GetConnectionString("(default)")))
                    throw new Exception("Connection string (default) not set. Please set them on DataService or Web Project.");

                optionsBuilder.UseMySql(configuration.GetConnectionString("(default)"));
            }
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