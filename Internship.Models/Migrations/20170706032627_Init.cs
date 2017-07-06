using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Internship.Models.Migrations
{
    public partial class Init : Migration
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MeasureableLearningObjective1 = table.Column<string>(nullable: true),
                    MeasureableLearningObjective2 = table.Column<string>(nullable: true),
                    MeasureableLearningObjective3 = table.Column<string>(nullable: true),
                    SupervisorsRatingOfLearningObjective1 = table.Column<double>(nullable: false),
                    SupervisorsRatingOfLearningObjective3 = table.Column<double>(nullable: false),
                    supervisorsRatingOfLearningObjective2 = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningObjectives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployersAddressId = table.Column<int>(nullable: false),
                    EmployersName = table.Column<string>(nullable: true),
                    SupervisorEmail = table.Column<string>(nullable: true),
                    SupervisorName = table.Column<string>(nullable: true),
                    SupervisorPhone = table.Column<int>(nullable: false),
                    SupervisorTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employers_Addresses_EmployersAddressId",
                        column: x => x.EmployersAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreditHoursRegisteredInSemester = table.Column<int>(nullable: false),
                    CurrentAddressId = table.Column<int>(nullable: false),
                    Degree = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ExpectededGraduationDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    IsInternational = table.Column<bool>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Major = table.Column<string>(nullable: true),
                    MajorGPA = table.Column<double>(nullable: false),
                    MiddleName = table.Column<string>(nullable: true),
                    PermanentAddressId = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    UserType = table.Column<int>(nullable: false),
                    WNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Addresses_CurrentAddressId",
                        column: x => x.CurrentAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Addresses_PermanentAddressId",
                        column: x => x.PermanentAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CPTForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployerId = table.Column<int>(nullable: false),
                    EmploymentAgreementId = table.Column<int>(nullable: false),
                    LeaningObjectiveId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPTForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CPTForms_Employers_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "Employers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CPTForms_EmployementAgreements_EmploymentAgreementId",
                        column: x => x.EmploymentAgreementId,
                        principalTable: "EmployementAgreements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CPTForms_LearningObjectives_LeaningObjectiveId",
                        column: x => x.LeaningObjectiveId,
                        principalTable: "LearningObjectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CPTFormId = table.Column<int>(nullable: false),
                    DateSignedByAcademicAdvisor = table.Column<DateTime>(nullable: false),
                    DateSignedByDean = table.Column<DateTime>(nullable: false),
                    DateSignedByDepartment = table.Column<DateTime>(nullable: false),
                    DateSignedByInstructor = table.Column<DateTime>(nullable: false),
                    DateSignedByStudent = table.Column<DateTime>(nullable: false),
                    DateSignedBySupervisorUponCompletion = table.Column<DateTime>(nullable: false),
                    InternshipSemester = table.Column<int>(nullable: false),
                    IsPartTime = table.Column<bool>(nullable: false),
                    ReasonsForNoneApproval = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_CPTForms_CPTFormId",
                        column: x => x.CPTFormId,
                        principalTable: "CPTForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_CPTFormId",
                table: "Applications",
                column: "CPTFormId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_UserId",
                table: "Applications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CPTForms_EmployerId",
                table: "CPTForms",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_CPTForms_EmploymentAgreementId",
                table: "CPTForms",
                column: "EmploymentAgreementId");

            migrationBuilder.CreateIndex(
                name: "IX_CPTForms_LeaningObjectiveId",
                table: "CPTForms",
                column: "LeaningObjectiveId");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_EmployersAddressId",
                table: "Employers",
                column: "EmployersAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CurrentAddressId",
                table: "Users",
                column: "CurrentAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PermanentAddressId",
                table: "Users",
                column: "PermanentAddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "CPTForms");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Employers");

            migrationBuilder.DropTable(
                name: "EmployementAgreements");

            migrationBuilder.DropTable(
                name: "LearningObjectives");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
