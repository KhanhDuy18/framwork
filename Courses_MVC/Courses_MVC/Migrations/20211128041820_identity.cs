using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Courses_MVC.Migrations
{
    public partial class identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_user_userId",
                table: "comment");

            migrationBuilder.DropForeignKey(
                name: "FK_exercise_user_teacherId",
                table: "exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_exerciseInUser_user_studentId",
                table: "exerciseInUser");

            migrationBuilder.DropForeignKey(
                name: "FK_register_user_userId",
                table: "register");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "register",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "studentId",
                table: "exerciseInUser",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "teacherId",
                table: "exercise",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "comment",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "AppRole",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 100, nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    discription = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 100, nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    address = table.Column<string>(maxLength: 200, nullable: true),
                    birthday = table.Column<DateTime>(type: "datetime", nullable: false),
                    gender = table.Column<int>(nullable: false, defaultValue: 0),
                    qualification = table.Column<string>(maxLength: 200, nullable: true),
                    startWorking = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(maxLength: 100, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: true),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(maxLength: 100, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 100, nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 100, nullable: false),
                    RoleId = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 100, nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_comment_AppUser_userId",
                table: "comment",
                column: "userId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_exercise_AppUser_teacherId",
                table: "exercise",
                column: "teacherId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_exerciseInUser_AppUser_studentId",
                table: "exerciseInUser",
                column: "studentId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_AppUser_userId",
                table: "comment");

            migrationBuilder.DropForeignKey(
                name: "FK_exercise_AppUser_teacherId",
                table: "exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_exerciseInUser_AppUser_studentId",
                table: "exerciseInUser");

            migrationBuilder.DropForeignKey(
                name: "FK_register_AppUser_userId",
                table: "register");

            migrationBuilder.DropTable(
                name: "AppRole");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "register",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "studentId",
                table: "exerciseInUser",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "teacherId",
                table: "exercise",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "comment",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    roleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    discription = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    nameRole = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.roleId);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    address = table.Column<string>(type: "text", nullable: true),
                    birthday = table.Column<DateTime>(type: "datetime", nullable: false),
                    fullName = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    mail = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    qualification = table.Column<string>(type: "text", nullable: true),
                    roleId = table.Column<int>(type: "int", nullable: false),
                    salary = table.Column<int>(type: "int", nullable: true),
                    sdt = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    startWorking = table.Column<DateTime>(type: "datetime", nullable: true),
                    userName = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    userPassword = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.userId);
                    table.ForeignKey(
                        name: "FK_user_role_roleId",
                        column: x => x.roleId,
                        principalTable: "role",
                        principalColumn: "roleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_user_roleId",
                table: "user",
                column: "roleId");

            migrationBuilder.AddForeignKey(
                name: "FK_comment_user_userId",
                table: "comment",
                column: "userId",
                principalTable: "user",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_exercise_user_teacherId",
                table: "exercise",
                column: "teacherId",
                principalTable: "user",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_exerciseInUser_user_studentId",
                table: "exerciseInUser",
                column: "studentId",
                principalTable: "user",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_register_user_userId",
                table: "register",
                column: "userId",
                principalTable: "user",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
