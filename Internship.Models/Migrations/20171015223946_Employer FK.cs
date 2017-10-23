using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Internship.Models.Migrations
{
    public partial class EmployerFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employers_CptApplications_CptApplicationId",
                table: "Employers");

            migrationBuilder.DropIndex(
                name: "IX_Employers_CptApplicationId",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "CptApplicationId",
                table: "Employers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CptApplicationId",
                table: "Employers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employers_CptApplicationId",
                table: "Employers",
                column: "CptApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employers_CptApplications_CptApplicationId",
                table: "Employers",
                column: "CptApplicationId",
                principalTable: "CptApplications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
