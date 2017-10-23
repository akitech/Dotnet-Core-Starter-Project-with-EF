using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Internship.Models.Migrations
{
    public partial class CreatedDatabasefromCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CellPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Concentration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditHoursRegisteredInSemester = table.Column<int>(type: "int", nullable: false),
                    CurrentAddressId = table.Column<int>(type: "int", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectededGraduationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsInternational = table.Column<bool>(type: "bit", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MajorGPA = table.Column<double>(type: "float", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddressId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    WNumber = table.Column<int>(type: "int", nullable: false),
                    WorkPhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Employers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CptApplicationId = table.Column<int>(type: "int", nullable: false),
                    EmployersAddressId = table.Column<int>(type: "int", nullable: false),
                    EmployersName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorPhone = table.Column<int>(type: "int", nullable: false),
                    SupervisorTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "EmployementAgreements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CptApplicationId = table.Column<int>(type: "int", nullable: false),
                    DescriptionOfEmployment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentBeginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmploymentEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoursPerWeek = table.Column<double>(type: "float", nullable: false),
                    JobResponsibilities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    SalaryType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployementAgreements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CptApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationStep = table.Column<int>(type: "int", nullable: false),
                    DateSignedByAcademicAdvisor = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateSignedByDean = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateSignedByDepartment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateSignedByEmployer = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateSignedByInstructor = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateSignedByStudent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateSignedBySupervisorUponCompletion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployerId = table.Column<int>(type: "int", nullable: false),
                    EmploymentAgreementId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InternshipSemester = table.Column<int>(type: "int", nullable: false),
                    IsPartTime = table.Column<bool>(type: "bit", nullable: false),
                    ReasonsForNoneApproval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CptApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CptApplications_Employers_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "Employers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CptApplications_EmployementAgreements_EmploymentAgreementId",
                        column: x => x.EmploymentAgreementId,
                        principalTable: "EmployementAgreements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CptApplications_Users_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LearningObjectives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CptApplicationId = table.Column<int>(type: "int", nullable: false),
                    MeasureableLearningObjective = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorRating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningObjectives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LearningObjectives_CptApplications_CptApplicationId",
                        column: x => x.CptApplicationId,
                        principalTable: "CptApplications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CptApplications_EmployerId",
                table: "CptApplications",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_CptApplications_EmploymentAgreementId",
                table: "CptApplications",
                column: "EmploymentAgreementId");

            migrationBuilder.CreateIndex(
                name: "IX_CptApplications_StudentId",
                table: "CptApplications",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployementAgreements_CptApplicationId",
                table: "EmployementAgreements",
                column: "CptApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_CptApplicationId",
                table: "Employers",
                column: "CptApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_EmployersAddressId",
                table: "Employers",
                column: "EmployersAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_LearningObjectives_CptApplicationId",
                table: "LearningObjectives",
                column: "CptApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CurrentAddressId",
                table: "Users",
                column: "CurrentAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PermanentAddressId",
                table: "Users",
                column: "PermanentAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employers_CptApplications_CptApplicationId",
                table: "Employers",
                column: "CptApplicationId",
                principalTable: "CptApplications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployementAgreements_CptApplications_CptApplicationId",
                table: "EmployementAgreements",
                column: "CptApplicationId",
                principalTable: "CptApplications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CptApplications_Employers_EmployerId",
                table: "CptApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_CptApplications_EmployementAgreements_EmploymentAgreementId",
                table: "CptApplications");

            migrationBuilder.DropTable(
                name: "LearningObjectives");

            migrationBuilder.DropTable(
                name: "Employers");

            migrationBuilder.DropTable(
                name: "EmployementAgreements");

            migrationBuilder.DropTable(
                name: "CptApplications");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
