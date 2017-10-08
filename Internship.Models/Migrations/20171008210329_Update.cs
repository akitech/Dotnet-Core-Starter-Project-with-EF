using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Internship.Models.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employers_CptApplicationId",
                table: "Employers");

            migrationBuilder.DropIndex(
                name: "IX_EmployementAgreements_CptApplicationId",
                table: "EmployementAgreements");

            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "CptApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmploymentAgreementId",
                table: "CptApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employers_CptApplicationId",
                table: "Employers",
                column: "CptApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployementAgreements_CptApplicationId",
                table: "EmployementAgreements",
                column: "CptApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_CptApplications_EmployerId",
                table: "CptApplications",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_CptApplications_EmploymentAgreementId",
                table: "CptApplications",
                column: "EmploymentAgreementId");

            migrationBuilder.AddForeignKey(
                name: "FK_CptApplications_Employers_EmployerId",
                table: "CptApplications",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CptApplications_EmployementAgreements_EmploymentAgreementId",
                table: "CptApplications",
                column: "EmploymentAgreementId",
                principalTable: "EmployementAgreements",
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

            migrationBuilder.DropIndex(
                name: "IX_Employers_CptApplicationId",
                table: "Employers");

            migrationBuilder.DropIndex(
                name: "IX_EmployementAgreements_CptApplicationId",
                table: "EmployementAgreements");

            migrationBuilder.DropIndex(
                name: "IX_CptApplications_EmployerId",
                table: "CptApplications");

            migrationBuilder.DropIndex(
                name: "IX_CptApplications_EmploymentAgreementId",
                table: "CptApplications");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "CptApplications");

            migrationBuilder.DropColumn(
                name: "EmploymentAgreementId",
                table: "CptApplications");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_CptApplicationId",
                table: "Employers",
                column: "CptApplicationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployementAgreements_CptApplicationId",
                table: "EmployementAgreements",
                column: "CptApplicationId",
                unique: true);
        }
    }
}
