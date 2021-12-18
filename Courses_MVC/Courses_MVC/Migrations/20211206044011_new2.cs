using Microsoft.EntityFrameworkCore.Migrations;

namespace Courses_MVC.Migrations
{
    public partial class new2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "discription",
                table: "AppRole");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppRole",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(767)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AppRole",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AppRole");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppRole",
                type: "varchar(767)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "discription",
                table: "AppRole",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true);
        }
    }
}
