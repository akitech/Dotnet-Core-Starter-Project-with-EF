using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Internship.Models;

namespace Internship.Models.Migrations
{
    [DbContext(typeof(InternshipContext))]
    [Migration("20170722214621_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AcademicTerm");

                    b.Property<string>("Concentration");

                    b.Property<string>("Degree");

                    b.Property<int>("EmployerId");

                    b.Property<int?>("EmployerId1");

                    b.Property<int>("EmploymentAgreementId");

                    b.Property<bool>("IsApplicationApprovedByDept");

                    b.Property<bool>("IsApplicationSignedByDeptHead");

                    b.Property<int>("LearningObjectiveId");

                    b.Property<int?>("LearningObjectiveId1");

                    b.Property<string>("Major");

                    b.Property<DateTime>("dataInstructorSignedApplicationForm");

                    b.Property<DateTime>("dataSignedByAcademicAdvisor");

                    b.Property<DateTime>("dataSupervisorSignedUponCompletion");

                    b.Property<DateTime>("dateApplicationReceivedByyDept");

                    b.Property<DateTime>("dateApplicationSignedByDean");

                    b.Property<DateTime>("dateApplicationsignedByDeptHead");

                    b.Property<DateTime>("expectededGraduationDate");

                    b.Property<bool>("isApplicationFormSignedByInstructor");

                    b.Property<bool>("isApplicationSignedByDean");

                    b.Property<bool>("isPartTime");

                    b.Property<bool>("isSignedByAcademicAdvisor");

                    b.Property<bool>("isSignedByStudentApplication");

                    b.Property<bool>("isSignedBySupervisorUponCompletion");

                    b.Property<bool>("isStudentInternational");

                    b.Property<decimal>("majorGPA");

                    b.Property<string>("reasonWhyOrWhyNotApplicationIsApprovedByDept");

                    b.Property<int>("semesterHoursEarned");

                    b.Property<int>("studentCellPhone");

                    b.Property<string>("studentEmail");

                    b.Property<string>("studentFirstName");

                    b.Property<string>("studentLastName");

                    b.Property<string>("studentMiddleName");

                    b.Property<string>("studentPermanentAddress");

                    b.Property<string>("studentPresentAddress");

                    b.Property<int>("studentWorkPhone");

                    b.Property<int>("wNum");

                    b.HasKey("ApplicationId");

                    b.HasIndex("EmployerId1");

                    b.HasIndex("EmploymentAgreementId");

                    b.HasIndex("LearningObjectiveId1");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Internship.Models.CPTForm", b =>
                {
                    b.Property<int>("CPTFormId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AcademicAdvisorEmail");

                    b.Property<string>("AcademicAdvisorName");

                    b.Property<int>("AcademicAdvisorTelephone");

                    b.Property<DateTime>("BeginningEmploymentDateOfPreviousCptAuthorization1");

                    b.Property<DateTime>("BeginningEmploymentDateOfPreviousCptAuthorization2");

                    b.Property<string>("CourseName");

                    b.Property<int>("EmployerId");

                    b.Property<int?>("EmployerId1");

                    b.Property<int>("EmploymentAgreementId");

                    b.Property<DateTime>("EndingEmploymentDateOfPreviousCptAuthorization1");

                    b.Property<DateTime>("EndingEmploymentDateOfPreviousCptAuthorization2");

                    b.Property<bool>("HasPreviousCptAuthorization1");

                    b.Property<bool>("HasPreviousCptAuthorization2");

                    b.Property<bool>("IsEmployedCurrentlyOffCampus");

                    b.Property<bool>("IsEmployedCurrentlyOnCampus");

                    b.Property<bool>("IsRequestForSummerEmployment");

                    b.Property<int>("LearningObjectiveId");

                    b.Property<int?>("LearningObjectiveId1");

                    b.Property<bool>("WasPreviousCptAuthorizationPartTime1");

                    b.Property<bool>("WasPreviousCptAuthorizationPartTime2");

                    b.HasKey("CPTFormId");

                    b.HasIndex("EmployerId1");

                    b.HasIndex("EmploymentAgreementId");

                    b.HasIndex("LearningObjectiveId1");

                    b.ToTable("CPTForms");
                });

            modelBuilder.Entity("Internship.Models.Employer", b =>
                {
                    b.Property<int>("EmployerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplicationId");

                    b.Property<int>("CPTFormId");

                    b.Property<int>("EmploymentAgreementId");

                    b.Property<int>("LearningObjectiveId");

                    b.Property<string>("employersAddress");

                    b.Property<string>("employersName");

                    b.Property<string>("supervisorEmail");

                    b.Property<string>("supervisorName");

                    b.Property<int>("supervisorPhone");

                    b.Property<string>("supervisorTitle");

                    b.HasKey("EmployerId");

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
                    b.Property<int>("LearningObjectiveId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplicationId");

                    b.Property<int>("CPTFormId");

                    b.Property<int>("EmployerId");

                    b.Property<int>("EmploymentAgreementId");

                    b.Property<int>("UserId");

                    b.Property<string>("measureableLearningObjective1");

                    b.Property<string>("measureableLearningObjective2");

                    b.Property<string>("measureableLearningObjective3");

                    b.Property<double>("supervisorsRatingOfLearningObjective1");

                    b.Property<double>("supervisorsRatingOfLearningObjective2");

                    b.Property<double>("supervisorsRatingOfLearningObjective3");

                    b.HasKey("LearningObjectiveId");

                    b.ToTable("LearningObjectives");
                });

            modelBuilder.Entity("Internship.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplicationId");

                    b.Property<int>("CPTFormId");

                    b.Property<int>("CreditHoursRegisteredInSemester");

                    b.Property<int>("CurrentAddressId");

                    b.Property<string>("Degree");

                    b.Property<string>("Email");

                    b.Property<int>("EmployerId");

                    b.Property<int>("EmploymentAgreementId");

                    b.Property<DateTime>("ExpectededGraduationDate");

                    b.Property<string>("FirstName");

                    b.Property<int>("Id");

                    b.Property<bool>("IsInternational");

                    b.Property<string>("LastName");

                    b.Property<int>("LearningObjectiveId");

                    b.Property<string>("Major");

                    b.Property<double>("MajorGPA");

                    b.Property<string>("MiddleName");

                    b.Property<int>("PermanentAddressId");

                    b.Property<string>("Phone");

                    b.Property<int>("UserType");

                    b.Property<int>("WNumber");

                    b.HasKey("UserId");

                    b.HasIndex("CurrentAddressId");

                    b.HasIndex("EmployerId")
                        .IsUnique();

                    b.HasIndex("PermanentAddressId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Internship.Models.Application", b =>
                {
                    b.HasOne("Internship.Models.Employer", "Employer")
                        .WithMany()
                        .HasForeignKey("EmployerId1");

                    b.HasOne("Internship.Models.EmploymentAgreement", "EmployementAgreement")
                        .WithMany()
                        .HasForeignKey("EmploymentAgreementId");

                    b.HasOne("Internship.Models.LearningObjective", "LearningObjective")
                        .WithMany()
                        .HasForeignKey("LearningObjectiveId1");
                });

            modelBuilder.Entity("Internship.Models.CPTForm", b =>
                {
                    b.HasOne("Internship.Models.Employer", "Employer")
                        .WithMany()
                        .HasForeignKey("EmployerId1");

                    b.HasOne("Internship.Models.EmploymentAgreement", "EmployementAgreement")
                        .WithMany()
                        .HasForeignKey("EmploymentAgreementId");

                    b.HasOne("Internship.Models.LearningObjective", "LearningObjective")
                        .WithMany()
                        .HasForeignKey("LearningObjectiveId1");
                });

            modelBuilder.Entity("Internship.Models.User", b =>
                {
                    b.HasOne("Internship.Models.Address", "CurrentAddress")
                        .WithMany()
                        .HasForeignKey("CurrentAddressId");

                    b.HasOne("Internship.Models.Employer")
                        .WithOne("UserId")
                        .HasForeignKey("Internship.Models.User", "EmployerId");

                    b.HasOne("Internship.Models.Address", "PermanentAddress")
                        .WithMany()
                        .HasForeignKey("PermanentAddressId");
                });
        }
    }
}
