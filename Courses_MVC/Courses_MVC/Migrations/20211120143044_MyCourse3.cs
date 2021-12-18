using Microsoft.EntityFrameworkCore.Migrations;

namespace Courses_MVC.Migrations
{
    public partial class MyCourse3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "register");

            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "receipt",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "exerciseInUser",
                nullable: false,
                defaultValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "exerciseInUser");

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "register",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "receipt",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldDefaultValue: 1);
        }
    }
}
