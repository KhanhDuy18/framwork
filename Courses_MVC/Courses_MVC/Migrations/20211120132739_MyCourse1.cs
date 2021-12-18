using Microsoft.EntityFrameworkCore.Migrations;

namespace Courses_MVC.Migrations
{
    public partial class MyCourse1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_course_courseId",
                table: "comment");

            migrationBuilder.DropForeignKey(
                name: "FK_comment_user_userId",
                table: "comment");

            migrationBuilder.DropForeignKey(
                name: "FK_course_discount_discountId",
                table: "course");

            migrationBuilder.DropForeignKey(
                name: "FK_course_topic_topicId",
                table: "course");

            migrationBuilder.DropForeignKey(
                name: "FK_exercise_lesson_lessonId",
                table: "exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_exercise_user_teacherId",
                table: "exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_exerciseInUser_user_studentId",
                table: "exerciseInUser");

            migrationBuilder.DropForeignKey(
                name: "FK_lesson_course_courseId",
                table: "lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_receipt_register_registerId",
                table: "receipt");

            migrationBuilder.DropForeignKey(
                name: "FK_register_course_courseId",
                table: "register");

            migrationBuilder.DropForeignKey(
                name: "FK_register_user_userId",
                table: "register");

            migrationBuilder.DropForeignKey(
                name: "FK_user_role_roleId",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_exerciseInUser",
                table: "exerciseInUser");

            migrationBuilder.DropIndex(
                name: "IX_exerciseInUser_studentId",
                table: "exerciseInUser");

            migrationBuilder.DropColumn(
                name: "author",
                table: "lesson");

            migrationBuilder.AddPrimaryKey(
                name: "PK_exerciseInUser",
                table: "exerciseInUser",
                columns: new[] { "studentId", "exerciseId" });

            migrationBuilder.CreateIndex(
                name: "IX_exerciseInUser_exerciseId",
                table: "exerciseInUser",
                column: "exerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_comment_course_courseId",
                table: "comment",
                column: "courseId",
                principalTable: "course",
                principalColumn: "courseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comment_user_userId",
                table: "comment",
                column: "userId",
                principalTable: "user",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_course_discount_discountId",
                table: "course",
                column: "discountId",
                principalTable: "discount",
                principalColumn: "discountId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_course_topic_topicId",
                table: "course",
                column: "topicId",
                principalTable: "topic",
                principalColumn: "topicId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_exercise_lesson_lessonId",
                table: "exercise",
                column: "lessonId",
                principalTable: "lesson",
                principalColumn: "lessonId",
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
                name: "FK_lesson_course_courseId",
                table: "lesson",
                column: "courseId",
                principalTable: "course",
                principalColumn: "courseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_receipt_register_registerId",
                table: "receipt",
                column: "registerId",
                principalTable: "register",
                principalColumn: "registerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_register_course_courseId",
                table: "register",
                column: "courseId",
                principalTable: "course",
                principalColumn: "courseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_register_user_userId",
                table: "register",
                column: "userId",
                principalTable: "user",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_role_roleId",
                table: "user",
                column: "roleId",
                principalTable: "role",
                principalColumn: "roleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_course_courseId",
                table: "comment");

            migrationBuilder.DropForeignKey(
                name: "FK_comment_user_userId",
                table: "comment");

            migrationBuilder.DropForeignKey(
                name: "FK_course_discount_discountId",
                table: "course");

            migrationBuilder.DropForeignKey(
                name: "FK_course_topic_topicId",
                table: "course");

            migrationBuilder.DropForeignKey(
                name: "FK_exercise_lesson_lessonId",
                table: "exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_exercise_user_teacherId",
                table: "exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_exerciseInUser_user_studentId",
                table: "exerciseInUser");

            migrationBuilder.DropForeignKey(
                name: "FK_lesson_course_courseId",
                table: "lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_receipt_register_registerId",
                table: "receipt");

            migrationBuilder.DropForeignKey(
                name: "FK_register_course_courseId",
                table: "register");

            migrationBuilder.DropForeignKey(
                name: "FK_register_user_userId",
                table: "register");

            migrationBuilder.DropForeignKey(
                name: "FK_user_role_roleId",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_exerciseInUser",
                table: "exerciseInUser");

            migrationBuilder.DropIndex(
                name: "IX_exerciseInUser_exerciseId",
                table: "exerciseInUser");

            migrationBuilder.AddColumn<string>(
                name: "author",
                table: "lesson",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_exerciseInUser",
                table: "exerciseInUser",
                column: "exerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_exerciseInUser_studentId",
                table: "exerciseInUser",
                column: "studentId");

            migrationBuilder.AddForeignKey(
                name: "FK_comment_course_courseId",
                table: "comment",
                column: "courseId",
                principalTable: "course",
                principalColumn: "courseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_comment_user_userId",
                table: "comment",
                column: "userId",
                principalTable: "user",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_course_discount_discountId",
                table: "course",
                column: "discountId",
                principalTable: "discount",
                principalColumn: "discountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_course_topic_topicId",
                table: "course",
                column: "topicId",
                principalTable: "topic",
                principalColumn: "topicId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_exercise_lesson_lessonId",
                table: "exercise",
                column: "lessonId",
                principalTable: "lesson",
                principalColumn: "lessonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_exercise_user_teacherId",
                table: "exercise",
                column: "teacherId",
                principalTable: "user",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_exerciseInUser_user_studentId",
                table: "exerciseInUser",
                column: "studentId",
                principalTable: "user",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_lesson_course_courseId",
                table: "lesson",
                column: "courseId",
                principalTable: "course",
                principalColumn: "courseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_receipt_register_registerId",
                table: "receipt",
                column: "registerId",
                principalTable: "register",
                principalColumn: "registerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_register_course_courseId",
                table: "register",
                column: "courseId",
                principalTable: "course",
                principalColumn: "courseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_register_user_userId",
                table: "register",
                column: "userId",
                principalTable: "user",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_user_role_roleId",
                table: "user",
                column: "roleId",
                principalTable: "role",
                principalColumn: "roleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
