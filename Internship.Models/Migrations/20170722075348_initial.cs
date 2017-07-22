using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Internship.Models.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    EmployerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationId = table.Column<int>(nullable: false),
                    CPTFormId = table.Column<int>(nullable: false),
                    EmploymentAgreementId = table.Column<int>(nullable: false),
                    LearningObjectiveId = table.Column<int>(nullable: false),
                    employersAddress = table.Column<string>(nullable: true),
                    employersName = table.Column<string>(nullable: true),
                    supervisorEmail = table.Column<string>(nullable: true),
                    supervisorName = table.Column<string>(nullable: true),
                    supervisorPhone = table.Column<int>(nullable: false),
                    supervisorTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.EmployerId);
                });

            migrationBuilder.CreateTable(
                name: "EmployementAgreements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescriptionOfEmployment = table.Column<string>(nullable: true),
                    EmploymentBeginDate = table.Column<DateTime>(nullable: false),
                    EmploymentEndDate = table.Column<DateTime>(nullable: false),
                    HoursPerWeek = table.Column<double>(nullable: false),
                    JobResponsibilities = table.Column<string>(nullable: true),
                    JobTitle = table.Column<string>(nullable: true),
                    Salary = table.Column<double>(nullable: false),
                    SalaryType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployementAgreements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LearningObjectives",
                columns: table => new
                {
                    LearningObjectiveId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationId = table.Column<int>(nullable: false),
                    CPTFormId = table.Column<int>(nullable: false),
                    EmployerId = table.Column<int>(nullable: false),
                    EmploymentAgreementId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    measureableLearningObjective1 = table.Column<string>(nullable: true),
                    measureableLearningObjective2 = table.Column<string>(nullable: true),
                    measureableLearningObjective3 = table.Column<string>(nullable: true),
                    supervisorsRatingOfLearningObjective1 = table.Column<double>(nullable: false),
                    supervisorsRatingOfLearningObjective2 = table.Column<double>(nullable: false),
                    supervisorsRatingOfLearningObjective3 = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningObjectives", x => x.LearningObjectiveId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationId = table.Column<int>(nullable: false),
                    CPTFormId = table.Column<int>(nullable: false),
                    EmployerId = table.Column<int>(nullable: false),
                    EmploymentAgreementId = table.Column<int>(nullable: false),
                    LearningObjectiveId = table.Column<int>(nullable: false),
                    isStudentInternational = table.Column<bool>(nullable: false),
                    studentCellPhone = table.Column<int>(nullable: false),
                    studentEmail = table.Column<string>(nullable: true),
                    studentFirstName = table.Column<string>(nullable: true),
                    studentLastName = table.Column<string>(nullable: true),
                    studentMiddleName = table.Column<string>(nullable: true),
                    studentPermanentAddress = table.Column<string>(nullable: true),
                    studentPresentAddress = table.Column<string>(nullable: true),
                    studentWorkPhone = table.Column<int>(nullable: false),
                    wNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Employers_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "Employers",
                        principalColumn: "EmployerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AcademicTerm = table.Column<string>(nullable: true),
                    Concentration = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    EmployerId = table.Column<int>(nullable: false),
                    EmployerId1 = table.Column<int>(nullable: true),
                    EmploymentAgreementId = table.Column<int>(nullable: false),
                    IsApplicationApprovedByDept = table.Column<bool>(nullable: false),
                    IsApplicationSignedByDeptHead = table.Column<bool>(nullable: false),
                    LearningObjectiveId = table.Column<int>(nullable: false),
                    LearningObjectiveId1 = table.Column<int>(nullable: true),
                    Major = table.Column<string>(nullable: true),
                    dataInstructorSignedApplicationForm = table.Column<DateTime>(nullable: false),
                    dataSignedByAcademicAdvisor = table.Column<DateTime>(nullable: false),
                    dataSupervisorSignedUponCompletion = table.Column<DateTime>(nullable: false),
                    dateApplicationReceivedByyDept = table.Column<DateTime>(nullable: false),
                    dateApplicationSignedByDean = table.Column<DateTime>(nullable: false),
                    dateApplicationsignedByDeptHead = table.Column<DateTime>(nullable: false),
                    expectededGraduationDate = table.Column<DateTime>(nullable: false),
                    isApplicationFormSignedByInstructor = table.Column<bool>(nullable: false),
                    isApplicationSignedByDean = table.Column<bool>(nullable: false),
                    isPartTime = table.Column<bool>(nullable: false),
                    isSignedByAcademicAdvisor = table.Column<bool>(nullable: false),
                    isSignedByStudentApplication = table.Column<bool>(nullable: false),
                    isSignedBySupervisorUponCompletion = table.Column<bool>(nullable: false),
                    majorGPA = table.Column<decimal>(nullable: false),
                    reasonWhyOrWhyNotApplicationIsApprovedByDept = table.Column<string>(nullable: true),
                    semesterHoursEarned = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_Applications_Employers_EmployerId1",
                        column: x => x.EmployerId1,
                        principalTable: "Employers",
                        principalColumn: "EmployerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applications_EmployementAgreements_EmploymentAgreementId",
                        column: x => x.EmploymentAgreementId,
                        principalTable: "EmployementAgreements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applications_LearningObjectives_LearningObjectiveId1",
                        column: x => x.LearningObjectiveId1,
                        principalTable: "LearningObjectives",
                        principalColumn: "LearningObjectiveId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CPTForms",
                columns: table => new
                {
                    CPTFormId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AcademicAdvisorEmail = table.Column<string>(nullable: true),
                    AcademicAdvisorName = table.Column<string>(nullable: true),
                    AcademicAdvisorTelephone = table.Column<int>(nullable: false),
                    BeginningEmploymentDateOfPreviousCptAuthorization1 = table.Column<DateTime>(nullable: false),
                    BeginningEmploymentDateOfPreviousCptAuthorization2 = table.Column<DateTime>(nullable: false),
                    CourseName = table.Column<string>(nullable: true),
                    EmployerId = table.Column<int>(nullable: false),
                    EmployerId1 = table.Column<int>(nullable: true),
                    EmploymentAgreementId = table.Column<int>(nullable: false),
                    EndingEmploymentDateOfPreviousCptAuthorization1 = table.Column<DateTime>(nullable: false),
                    EndingEmploymentDateOfPreviousCptAuthorization2 = table.Column<DateTime>(nullable: false),
                    HasPreviousCptAuthorization1 = table.Column<bool>(nullable: false),
                    HasPreviousCptAuthorization2 = table.Column<bool>(nullable: false),
                    IsEmployedCurrentlyOffCampus = table.Column<bool>(nullable: false),
                    IsEmployedCurrentlyOnCampus = table.Column<bool>(nullable: false),
                    IsRequestForSummerEmployment = table.Column<bool>(nullable: false),
                    LearningObjectiveId = table.Column<int>(nullable: false),
                    LearningObjectiveId1 = table.Column<int>(nullable: true),
                    WasPreviousCptAuthorizationPartTime1 = table.Column<bool>(nullable: false),
                    WasPreviousCptAuthorizationPartTime2 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPTForms", x => x.CPTFormId);
                    table.ForeignKey(
                        name: "FK_CPTForms_Employers_EmployerId1",
                        column: x => x.EmployerId1,
                        principalTable: "Employers",
                        principalColumn: "EmployerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CPTForms_EmployementAgreements_EmploymentAgreementId",
                        column: x => x.EmploymentAgreementId,
                        principalTable: "EmployementAgreements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CPTForms_LearningObjectives_LearningObjectiveId1",
                        column: x => x.LearningObjectiveId1,
                        principalTable: "LearningObjectives",
                        principalColumn: "LearningObjectiveId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_EmployerId1",
                table: "Applications",
                column: "EmployerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_EmploymentAgreementId",
                table: "Applications",
                column: "EmploymentAgreementId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_LearningObjectiveId1",
                table: "Applications",
                column: "LearningObjectiveId1");

            migrationBuilder.CreateIndex(
                name: "IX_CPTForms_EmployerId1",
                table: "CPTForms",
                column: "EmployerId1");

            migrationBuilder.CreateIndex(
                name: "IX_CPTForms_EmploymentAgreementId",
                table: "CPTForms",
                column: "EmploymentAgreementId");

            migrationBuilder.CreateIndex(
                name: "IX_CPTForms_LearningObjectiveId1",
                table: "CPTForms",
                column: "LearningObjectiveId1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmployerId",
                table: "Users",
                column: "EmployerId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "CPTForms");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "EmployementAgreements");

            migrationBuilder.DropTable(
                name: "LearningObjectives");

            migrationBuilder.DropTable(
                name: "Employers");
        }
    }
}
