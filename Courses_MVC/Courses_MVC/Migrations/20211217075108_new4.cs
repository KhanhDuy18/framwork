using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Courses_MVC.Migrations
{
    public partial class new4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "receipt");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "qualification",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "startWorking",
                table: "AppUser");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "lesson",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "exerciseInUser",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "lesson");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "receipt",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "exerciseInUser",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AddColumn<int>(
                name: "gender",
                table: "AppUser",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "qualification",
                table: "AppUser",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "startWorking",
                table: "AppUser",
                type: "datetime",
                nullable: true);
        }
    }
}
