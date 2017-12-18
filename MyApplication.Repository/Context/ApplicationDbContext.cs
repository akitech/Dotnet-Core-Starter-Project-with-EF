using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyApplication.Models;
using System;
using System.IO;
using System.Linq;

namespace MyApplication.Repository.Context
{
    public class ApplicationDbContext : DbContext
    {

        #region Constructors

        //Constructor for Dependency Injection:
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public ApplicationDbContext()
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
                // Make Sure to change "MyApplication.Api" if you change the project name
                if (!File.Exists(appsettings))
                    appSettingsPath = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), "MyApplication.Api");

                // Build Configuration:
                var configuration = new ConfigurationBuilder().SetBasePath(appSettingsPath)
                   .AddJsonFile("appsettings.json", optional: true)
                   .AddJsonFile("appsettings.Development.json", optional: true)
                   .Build();

                // Check if configuration is good:
                if (string.IsNullOrEmpty(configuration.GetConnectionString("(default)")))
                    throw new Exception("Connection string (default) not set. Please set them on Repository or Web Project.");

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("(default)"));
            }
        }
        #endregion
        
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

    }

}