using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Courses_MVC.Migrations
{
    public partial class MyCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "discount",
                columns: table => new
                {
                    discountId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    discription = table.Column<string>(maxLength: 1000, nullable: false),
                    time = table.Column<DateTime>(type: "datetime", nullable: false),
                    sale = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_discount", x => x.discountId);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    roleId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nameRole = table.Column<string>(maxLength: 45, nullable: false),
                    discription = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.roleId);
                });

            migrationBuilder.CreateTable(
                name: "topic",
                columns: table => new
                {
                    topicId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    topicName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topic", x => x.topicId);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    userName = table.Column<string>(maxLength: 45, nullable: false),
                    userPassword = table.Column<string>(maxLength: 45, nullable: false),
                    address = table.Column<string>(nullable: true),
                    fullName = table.Column<string>(maxLength: 45, nullable: false),
                    birthday = table.Column<DateTime>(type: "datetime", nullable: false),
                    gender = table.Column<int>(nullable: false),
                    mail = table.Column<string>(maxLength: 25, nullable: false),
                    sdt = table.Column<string>(maxLength: 10, nullable: false),
                    qualification = table.Column<string>(nullable: true),
                    salary = table.Column<int>(nullable: true),
                    startWorking = table.Column<DateTime>(nullable: true),
                    roleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.userId);
                    table.ForeignKey(
                        name: "FK_user_role_roleId",
                        column: x => x.roleId,
                        principalTable: "role",
                        principalColumn: "roleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "course",
                columns: table => new
                {
                    courseId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    courseName = table.Column<string>(maxLength: 50, nullable: false),
                    discription = table.Column<string>(maxLength: 1000, nullable: false),
                    price = table.Column<int>(nullable: false, defaultValue: 0),
                    originalPrice = table.Column<int>(nullable: false),
                    imgCourse = table.Column<string>(maxLength: 50, nullable: false),
                    totalTime = table.Column<DateTime>(type: "date", nullable: false),
                    totalStudent = table.Column<int>(nullable: false),
                    topicId = table.Column<int>(nullable: false),
                    discountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course", x => x.courseId);
                    table.ForeignKey(
                        name: "FK_course_discount_discountId",
                        column: x => x.discountId,
                        principalTable: "discount",
                        principalColumn: "discountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_course_topic_topicId",
                        column: x => x.topicId,
                        principalTable: "topic",
                        principalColumn: "topicId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "comment",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false),
                    courseId = table.Column<int>(nullable: false),
                    content = table.Column<string>(maxLength: 1000, nullable: false),
                    evaluate = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comment", x => new { x.courseId, x.userId });
                    table.ForeignKey(
                        name: "FK_comment_course_courseId",
                        column: x => x.courseId,
                        principalTable: "course",
                        principalColumn: "courseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_comment_user_userId",
                        column: x => x.userId,
                        principalTable: "user",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "lesson",
                columns: table => new
                {
                    lessonId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(maxLength: 200, nullable: false),
                    author = table.Column<string>(maxLength: 50, nullable: false),
                    content = table.Column<string>(maxLength: 1000, nullable: false),
                    courseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lesson", x => x.lessonId);
                    table.ForeignKey(
                        name: "FK_lesson_course_courseId",
                        column: x => x.courseId,
                        principalTable: "course",
                        principalColumn: "courseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "register",
                columns: table => new
                {
                    registerId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    timeReg = table.Column<DateTime>(type: "datetime", nullable: false),
                    status = table.Column<string>(nullable: true),
                    userId = table.Column<int>(nullable: false),
                    courseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_register", x => x.registerId);
                    table.ForeignKey(
                        name: "FK_register_course_courseId",
                        column: x => x.courseId,
                        principalTable: "course",
                        principalColumn: "courseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_register_user_userId",
                        column: x => x.userId,
                        principalTable: "user",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "exercise",
                columns: table => new
                {
                    exerciseId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    content = table.Column<string>(maxLength: 1000, nullable: false),
                    deadline = table.Column<DateTime>(type: "date", nullable: false),
                    lessonId = table.Column<int>(nullable: false),
                    teacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercise", x => x.exerciseId);
                    table.ForeignKey(
                        name: "FK_exercise_lesson_lessonId",
                        column: x => x.lessonId,
                        principalTable: "lesson",
                        principalColumn: "lessonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_exercise_user_teacherId",
                        column: x => x.teacherId,
                        principalTable: "user",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "receipt",
                columns: table => new
                {
                    receiptId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    totalPrice = table.Column<float>(nullable: false, defaultValue: 0f),
                    status = table.Column<string>(nullable: true),
                    timeReceipt = table.Column<DateTime>(type: "datetime", nullable: false),
                    registerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receipt", x => x.receiptId);
                    table.ForeignKey(
                        name: "FK_receipt_register_registerId",
                        column: x => x.registerId,
                        principalTable: "register",
                        principalColumn: "registerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "exerciseInUser",
                columns: table => new
                {
                    exerciseId = table.Column<int>(nullable: false),
                    studentId = table.Column<int>(nullable: false),
                    submit = table.Column<DateTime>(type: "datetime", nullable: false),
                    scores = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exerciseInUser", x => x.exerciseId);
                    table.ForeignKey(
                        name: "FK_exerciseInUser_exercise_exerciseId",
                        column: x => x.exerciseId,
                        principalTable: "exercise",
                        principalColumn: "exerciseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_exerciseInUser_user_studentId",
                        column: x => x.studentId,
                        principalTable: "user",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comment_userId",
                table: "comment",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_course_discountId",
                table: "course",
                column: "discountId");

            migrationBuilder.CreateIndex(
                name: "IX_course_topicId",
                table: "course",
                column: "topicId");

            migrationBuilder.CreateIndex(
                name: "IX_exercise_lessonId",
                table: "exercise",
                column: "lessonId");

            migrationBuilder.CreateIndex(
                name: "IX_exercise_teacherId",
                table: "exercise",
                column: "teacherId");

            migrationBuilder.CreateIndex(
                name: "IX_exerciseInUser_studentId",
                table: "exerciseInUser",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_lesson_courseId",
                table: "lesson",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_receipt_registerId",
                table: "receipt",
                column: "registerId");

            migrationBuilder.CreateIndex(
                name: "IX_register_courseId",
                table: "register",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_register_userId",
                table: "register",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_user_roleId",
                table: "user",
                column: "roleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comment");

            migrationBuilder.DropTable(
                name: "exerciseInUser");

            migrationBuilder.DropTable(
                name: "receipt");

            migrationBuilder.DropTable(
                name: "exercise");

            migrationBuilder.DropTable(
                name: "register");

            migrationBuilder.DropTable(
                name: "lesson");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "course");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "discount");

            migrationBuilder.DropTable(
                name: "topic");
        }
    }
}
