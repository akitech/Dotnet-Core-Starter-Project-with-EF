using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Internship.Models.Migrations
{
    public partial class Application_FK_Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployementAgreements_CptApplications_CptApplicationId",
                table: "EmployementAgreements");

            migrationBuilder.DropIndex(
                name: "IX_EmployementAgreements_CptApplicationId",
                table: "EmployementAgreements");

            migrationBuilder.DropColumn(
                name: "CptApplicationId",
                table: "EmployementAgreements");

            migrationBuilder.AlterColumn<int>(
                name: "CptApplicationId",
                table: "LearningObjectives",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CptApplicationId",
                table: "LearningObjectives",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CptApplicationId",
                table: "EmployementAgreements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployementAgreements_CptApplicationId",
                table: "EmployementAgreements",
                column: "CptApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployementAgreements_CptApplications_CptApplicationId",
                table: "EmployementAgreements",
                column: "CptApplicationId",
                principalTable: "CptApplications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
