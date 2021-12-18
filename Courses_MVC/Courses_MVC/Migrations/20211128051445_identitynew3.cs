using Microsoft.EntityFrameworkCore.Migrations;

namespace Courses_MVC.Migrations
{
    public partial class identitynew3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_exercise_AppUser_teacherId",
                table: "exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_register_AppUser_userId",
                table: "register");

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "register",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(767)");

            migrationBuilder.AlterColumn<string>(
                name: "teacherId",
                table: "exercise",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(767)");

            migrationBuilder.AddForeignKey(
                name: "FK_exercise_AppUser_teacherId",
                table: "exercise",
                column: "teacherId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_register_AppUser_userId",
                table: "register",
                column: "userId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_exercise_AppUser_teacherId",
                table: "exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_register_AppUser_userId",
                table: "register");

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "register",
                type: "varchar(767)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "teacherId",
                table: "exercise",
                type: "varchar(767)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_exercise_AppUser_teacherId",
                table: "exercise",
                column: "teacherId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_register_AppUser_userId",
                table: "register",
                column: "userId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
