using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Internship.Models;

namespace Internship.Models.Migrations
{
    [DbContext(typeof(InternshipContext))]
    partial class InternshipContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Internship.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("State");

                    b.Property<int>("Zip");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Internship.Models.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CPTFormId");

                    b.Property<DateTime>("DateSignedByAcademicAdvisor");

                    b.Property<DateTime>("DateSignedByDean");

                    b.Property<DateTime>("DateSignedByDepartment");

                    b.Property<DateTime>("DateSignedByInstructor");

                    b.Property<DateTime>("DateSignedByStudent");

                    b.Property<DateTime>("DateSignedBySupervisorUponCompletion");

                    b.Property<int>("InternshipSemester");

                    b.Property<bool>("IsPartTime");

                    b.Property<string>("ReasonsForNoneApproval");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CPTFormId");

                    b.HasIndex("UserId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Internship.Models.CPTForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmployerId");

                    b.Property<int>("EmploymentAgreementId");

                    b.Property<int>("LeaningObjectiveId");

                    b.HasKey("Id");

                    b.HasIndex("EmployerId");

                    b.HasIndex("EmploymentAgreementId");

                    b.HasIndex("LeaningObjectiveId");

                    b.ToTable("CPTForms");
                });

            modelBuilder.Entity("Internship.Models.Employer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmployersAddressId");

                    b.Property<string>("EmployersName");

                    b.Property<string>("SupervisorEmail");

                    b.Property<string>("SupervisorName");

                    b.Property<int>("SupervisorPhone");

                    b.Property<string>("SupervisorTitle");

                    b.HasKey("Id");

                    b.HasIndex("EmployersAddressId");

                    b.ToTable("Employers");
                });

            modelBuilder.Entity("Internship.Models.EmploymentAgreement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescriptionOfEmployment");

                    b.Property<DateTime>("EmploymentBeginDate");

                    b.Property<DateTime>("EmploymentEndDate");

                    b.Property<double>("HoursPerWeek");

                    b.Property<string>("JobResponsibilities");

                    b.Property<string>("JobTitle");

                    b.Property<double>("Salary");

                    b.Property<int>("SalaryType");

                    b.HasKey("Id");

                    b.ToTable("EmployementAgreements");
                });

            modelBuilder.Entity("Internship.Models.LearningObjective", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MeasureableLearningObjective1");

                    b.Property<string>("MeasureableLearningObjective2");

                    b.Property<string>("MeasureableLearningObjective3");

                    b.Property<double>("SupervisorsRatingOfLearningObjective1");

                    b.Property<double>("SupervisorsRatingOfLearningObjective3");

                    b.Property<double>("supervisorsRatingOfLearningObjective2");

                    b.HasKey("Id");

                    b.ToTable("LearningObjectives");
                });

            modelBuilder.Entity("Internship.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreditHoursRegisteredInSemester");

                    b.Property<int>("CurrentAddressId");

                    b.Property<string>("Degree");

                    b.Property<string>("Email");

                    b.Property<DateTime>("ExpectededGraduationDate");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsInternational");

                    b.Property<string>("LastName");

                    b.Property<string>("Major");

                    b.Property<double>("MajorGPA");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Password");

                    b.Property<int>("PermanentAddressId");

                    b.Property<string>("Phone");

                    b.Property<int>("UserType");

                    b.Property<int>("WNumber");

                    b.HasKey("Id");

                    b.HasIndex("CurrentAddressId");

                    b.HasIndex("PermanentAddressId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Internship.Models.Application", b =>
                {
                    b.HasOne("Internship.Models.CPTForm", "CPTForm")
                        .WithMany()
                        .HasForeignKey("CPTFormId");

                    b.HasOne("Internship.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Internship.Models.CPTForm", b =>
                {
                    b.HasOne("Internship.Models.Employer", "Employer")
                        .WithMany()
                        .HasForeignKey("EmployerId");

                    b.HasOne("Internship.Models.EmploymentAgreement", "EmploymentAgreement")
                        .WithMany()
                        .HasForeignKey("EmploymentAgreementId");

                    b.HasOne("Internship.Models.LearningObjective", "LearningObjective")
                        .WithMany()
                        .HasForeignKey("LeaningObjectiveId");
                });

            modelBuilder.Entity("Internship.Models.Employer", b =>
                {
                    b.HasOne("Internship.Models.Address", "EmployersAddress")
                        .WithMany()
                        .HasForeignKey("EmployersAddressId");
                });

            modelBuilder.Entity("Internship.Models.User", b =>
                {
                    b.HasOne("Internship.Models.Address", "CurrentAddress")
                        .WithMany()
                        .HasForeignKey("CurrentAddressId");

                    b.HasOne("Internship.Models.Address", "PermanentAddress")
                        .WithMany()
                        .HasForeignKey("PermanentAddressId");
                });
        }
    }
}
