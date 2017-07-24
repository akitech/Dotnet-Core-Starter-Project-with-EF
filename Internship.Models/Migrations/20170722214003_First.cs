using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Internship.Models.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "wNum",
                table: "Users",
                newName: "WNumber");

            migrationBuilder.RenameColumn(
                name: "studentWorkPhone",
                table: "Users",
                newName: "PermanentAddressId");

            migrationBuilder.RenameColumn(
                name: "studentPresentAddress",
                table: "Users",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "studentPermanentAddress",
                table: "Users",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "studentMiddleName",
                table: "Users",
                newName: "Major");

            migrationBuilder.RenameColumn(
                name: "studentLastName",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "studentFirstName",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "studentEmail",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "studentCellPhone",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "isStudentInternational",
                table: "Users",
                newName: "IsInternational");

            migrationBuilder.AddColumn<int>(
                name: "CreditHoursRegisteredInSemester",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentAddressId",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Degree",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpectededGraduationDate",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "MajorGPA",
                table: "Users",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isStudentInternational",
                table: "Applications",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "studentCellPhone",
                table: "Applications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "studentEmail",
                table: "Applications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "studentFirstName",
                table: "Applications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "studentLastName",
                table: "Applications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "studentMiddleName",
                table: "Applications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "studentPermanentAddress",
                table: "Applications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "studentPresentAddress",
                table: "Applications",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "studentWorkPhone",
                table: "Applications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "wNum",
                table: "Applications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CurrentAddressId",
                table: "Users",
                column: "CurrentAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PermanentAddressId",
                table: "Users",
                column: "PermanentAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Addresses_CurrentAddressId",
                table: "Users",
                column: "CurrentAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Addresses_PermanentAddressId",
                table: "Users",
                column: "PermanentAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Addresses_CurrentAddressId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Addresses_PermanentAddressId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CurrentAddressId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PermanentAddressId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreditHoursRegisteredInSemester",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CurrentAddressId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ExpectededGraduationDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MajorGPA",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "isStudentInternational",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "studentCellPhone",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "studentEmail",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "studentFirstName",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "studentLastName",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "studentMiddleName",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "studentPermanentAddress",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "studentPresentAddress",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "studentWorkPhone",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "wNum",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "WNumber",
                table: "Users",
                newName: "wNum");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Users",
                newName: "studentPresentAddress");

            migrationBuilder.RenameColumn(
                name: "PermanentAddressId",
                table: "Users",
                newName: "studentWorkPhone");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Users",
                newName: "studentPermanentAddress");

            migrationBuilder.RenameColumn(
                name: "Major",
                table: "Users",
                newName: "studentMiddleName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "studentLastName");

            migrationBuilder.RenameColumn(
                name: "IsInternational",
                table: "Users",
                newName: "isStudentInternational");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "studentCellPhone");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "studentFirstName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "studentEmail");
        }
    }
}
