using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Internship.Models.Migrations
{
    public partial class AdvisorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupervisorId",
                table: "CptApplications",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CptApplications_SupervisorId",
                table: "CptApplications",
                column: "SupervisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CptApplications_Users_SupervisorId",
                table: "CptApplications",
                column: "SupervisorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CptApplications_Users_SupervisorId",
                table: "CptApplications");

            migrationBuilder.DropIndex(
                name: "IX_CptApplications_SupervisorId",
                table: "CptApplications");

            migrationBuilder.DropColumn(
                name: "SupervisorId",
                table: "CptApplications");
        }
    }
}
