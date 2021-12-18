using Microsoft.EntityFrameworkCore.Migrations;

namespace Courses_MVC.Migrations
{
    public partial class new3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.RenameTable(
                name: "UserTokens",
                newName: "AppUserToken");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "AppUserRole");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                newName: "AppUserLogin");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                newName: "AppUserClaim");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                newName: "AppRoleClaim");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.RenameTable(
                name: "AppUserToken",
                newName: "UserTokens");

            migrationBuilder.RenameTable(
                name: "AppUserRole",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "AppUserLogin",
                newName: "UserLogins");

            migrationBuilder.RenameTable(
                name: "AppUserClaim",
                newName: "UserClaims");

            migrationBuilder.RenameTable(
                name: "AppRoleClaim",
                newName: "RoleClaims");

            
        }
    }
}
