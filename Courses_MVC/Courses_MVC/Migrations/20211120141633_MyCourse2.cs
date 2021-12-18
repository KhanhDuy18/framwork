using Microsoft.EntityFrameworkCore.Migrations;

namespace Courses_MVC.Migrations
{
    public partial class MyCourse2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "gender",
                table: "user",
                maxLength: 10,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "gender",
                table: "user",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 10,
                oldDefaultValue: 0);
        }
    }
}
