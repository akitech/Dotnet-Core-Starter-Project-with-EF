using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Internship.Models.Migrations
{
    public partial class SecondPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Employers_EmployerId1",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_CPTForms_Employers_EmployerId1",
                table: "CPTForms");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Employers_EmployerId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employers",
                table: "Employers");

            migrationBuilder.AlterColumn<int>(
                name: "EmployerId",
                table: "Employers",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Employers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employers",
                table: "Employers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Employers_EmployerId1",
                table: "Applications",
                column: "EmployerId1",
                principalTable: "Employers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CPTForms_Employers_EmployerId1",
                table: "CPTForms",
                column: "EmployerId1",
                principalTable: "Employers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Employers_EmployerId",
                table: "Users",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Employers_EmployerId1",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_CPTForms_Employers_EmployerId1",
                table: "CPTForms");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Employers_EmployerId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employers",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Employers");

            migrationBuilder.AlterColumn<int>(
                name: "EmployerId",
                table: "Employers",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employers",
                table: "Employers",
                column: "EmployerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Employers_EmployerId1",
                table: "Applications",
                column: "EmployerId1",
                principalTable: "Employers",
                principalColumn: "EmployerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CPTForms_Employers_EmployerId1",
                table: "CPTForms",
                column: "EmployerId1",
                principalTable: "Employers",
                principalColumn: "EmployerId",
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
