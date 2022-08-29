using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace courses_site_api.Migrations
{
    public partial class intiat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "course_Detailes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imgpath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    discount = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numberofvideos = table.Column<int>(type: "int", nullable: false),
                    numberofhours = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_Detailes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "purchasedcourses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    courseid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchasedcourses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "registrations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    avatarpath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registrations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Reservedcourses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    courseid = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    finalprice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservedcourses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "courses_Categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Course_Detailesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses_Categories", x => x.id);
                    table.ForeignKey(
                        name: "ForeignKey-Courses_category-Course_Detailes",
                        column: x => x.Course_Detailesid,
                        principalTable: "course_Detailes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chats",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receiver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Registrationid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chats", x => x.id);
                    table.ForeignKey(
                        name: "FK_chats_registrations_Registrationid",
                        column: x => x.Registrationid,
                        principalTable: "registrations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comment = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    registrationid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.id);
                    table.ForeignKey(
                        name: "ForeignKey-comments-registration",
                        column: x => x.registrationid,
                        principalTable: "registrations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "courses_Videos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    videopath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Courses_Categoryid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses_Videos", x => x.id);
                    table.ForeignKey(
                        name: "ForeignKey-Courses_videos-Courses_category",
                        column: x => x.Courses_Categoryid,
                        principalTable: "courses_Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_chats_Registrationid",
                table: "chats",
                column: "Registrationid");

            migrationBuilder.CreateIndex(
                name: "IX_comments_registrationid",
                table: "comments",
                column: "registrationid");

            migrationBuilder.CreateIndex(
                name: "IX_courses_Categories_Course_Detailesid",
                table: "courses_Categories",
                column: "Course_Detailesid");

            migrationBuilder.CreateIndex(
                name: "IX_courses_Videos_Courses_Categoryid",
                table: "courses_Videos",
                column: "Courses_Categoryid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chats");

            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "courses_Videos");

            migrationBuilder.DropTable(
                name: "purchasedcourses");

            migrationBuilder.DropTable(
                name: "Reservedcourses");

            migrationBuilder.DropTable(
                name: "registrations");

            migrationBuilder.DropTable(
                name: "courses_Categories");

            migrationBuilder.DropTable(
                name: "course_Detailes");
        }
    }
}
