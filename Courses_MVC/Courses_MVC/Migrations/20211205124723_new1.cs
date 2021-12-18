using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Courses_MVC.Migrations
{
    public partial class new1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
 

            migrationBuilder.AlterColumn<string>(
                name: "totalTime",
                table: "course",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
 

            migrationBuilder.AlterColumn<DateTime>(
                name: "totalTime",
                table: "course",
                type: "date",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

        }
    }
}
