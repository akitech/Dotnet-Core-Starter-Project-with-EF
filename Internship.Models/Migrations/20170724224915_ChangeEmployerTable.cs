using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Internship.Models.Migrations
{
    public partial class ChangeEmployerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Employers_EmployerId1",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_EmployementAgreements_EmploymentAgreementId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_CPTForms_EmployementAgreements_EmploymentAgreementId",
                table: "CPTForms");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Employers_EmployerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_EmployerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_CPTForms_EmploymentAgreementId",
                table: "CPTForms");

            migrationBuilder.DropIndex(
                name: "IX_Applications_EmploymentAgreementId",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "ApplicationId",
                table: "Employers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "EmployerId1",
                table: "Applications",
                newName: "EmploymentAgreementId1");

            migrationBuilder.RenameIndex(
                name: "IX_Applications_EmployerId1",
                table: "Applications",
                newName: "IX_Applications_EmploymentAgreementId1");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "EmployementAgreements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CPTFormId",
                table: "EmployementAgreements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "EmployementAgreements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LearningObjectiveId",
                table: "EmployementAgreements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "employersName",
                table: "Employers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmploymentAgreementId1",
                table: "Employers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmploymentAgreementId1",
                table: "CPTForms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "CPTForms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Applications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmploymentAgreementId",
                table: "Users",
                column: "EmploymentAgreementId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employers_EmploymentAgreementId1",
                table: "Employers",
                column: "EmploymentAgreementId1");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_LearningObjectiveId",
                table: "Employers",
                column: "LearningObjectiveId");

            migrationBuilder.CreateIndex(
                name: "IX_CPTForms_EmploymentAgreementId1",
                table: "CPTForms",
                column: "EmploymentAgreementId1");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_EmployerId",
                table: "Applications",
                column: "EmployerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Employers_EmployerId",
                table: "Applications",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "EmployerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_EmployementAgreements_EmploymentAgreementId1",
                table: "Applications",
                column: "EmploymentAgreementId1",
                principalTable: "EmployementAgreements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CPTForms_EmployementAgreements_EmploymentAgreementId1",
                table: "CPTForms",
                column: "EmploymentAgreementId1",
                principalTable: "EmployementAgreements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employers_EmployementAgreements_EmploymentAgreementId1",
                table: "Employers",
                column: "EmploymentAgreementId1",
                principalTable: "EmployementAgreements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employers_LearningObjectives_LearningObjectiveId",
                table: "Employers",
                column: "LearningObjectiveId",
                principalTable: "LearningObjectives",
                principalColumn: "LearningObjectiveId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_EmployementAgreements_EmploymentAgreementId",
                table: "Users",
                column: "EmploymentAgreementId",
                principalTable: "EmployementAgreements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Employers_EmployerId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_EmployementAgreements_EmploymentAgreementId1",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_CPTForms_EmployementAgreements_EmploymentAgreementId1",
                table: "CPTForms");

            migrationBuilder.DropForeignKey(
                name: "FK_Employers_EmployementAgreements_EmploymentAgreementId1",
                table: "Employers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employers_LearningObjectives_LearningObjectiveId",
                table: "Employers");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_EmployementAgreements_EmploymentAgreementId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_EmploymentAgreementId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Employers_EmploymentAgreementId1",
                table: "Employers");

            migrationBuilder.DropIndex(
                name: "IX_Employers_LearningObjectiveId",
                table: "Employers");

            migrationBuilder.DropIndex(
                name: "IX_CPTForms_EmploymentAgreementId1",
                table: "CPTForms");

            migrationBuilder.DropIndex(
                name: "IX_Applications_EmployerId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "EmployementAgreements");

            migrationBuilder.DropColumn(
                name: "CPTFormId",
                table: "EmployementAgreements");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "EmployementAgreements");

            migrationBuilder.DropColumn(
                name: "LearningObjectiveId",
                table: "EmployementAgreements");

            migrationBuilder.DropColumn(
                name: "EmploymentAgreementId1",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "EmploymentAgreementId1",
                table: "CPTForms");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CPTForms");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Employers",
                newName: "ApplicationId");

            migrationBuilder.RenameColumn(
                name: "EmploymentAgreementId1",
                table: "Applications",
                newName: "EmployerId1");

            migrationBuilder.RenameIndex(
                name: "IX_Applications_EmploymentAgreementId1",
                table: "Applications",
                newName: "IX_Applications_EmployerId1");

            migrationBuilder.AlterColumn<string>(
                name: "employersName",
                table: "Employers",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmployerId",
                table: "Users",
                column: "EmployerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CPTForms_EmploymentAgreementId",
                table: "CPTForms",
                column: "EmploymentAgreementId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_EmploymentAgreementId",
                table: "Applications",
                column: "EmploymentAgreementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Employers_EmployerId1",
                table: "Applications",
                column: "EmployerId1",
                principalTable: "Employers",
                principalColumn: "EmployerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_EmployementAgreements_EmploymentAgreementId",
                table: "Applications",
                column: "EmploymentAgreementId",
                principalTable: "EmployementAgreements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CPTForms_EmployementAgreements_EmploymentAgreementId",
                table: "CPTForms",
                column: "EmploymentAgreementId",
                principalTable: "EmployementAgreements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Employers_EmployerId",
                table: "Users",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "EmployerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
