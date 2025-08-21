using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C44_G02_EF02.Migrations
{
    public partial class AddCourse_InstTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructor_Course",
                columns: table => new
                {
                    Inst_ID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    Evaluate = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor_Course", x => new { x.Inst_ID, x.Course_ID });
                    table.CheckConstraint("CK_Instructor_Course_Evaluate", "Evaluate BETWEEN 1 AND 10");
                    table.ForeignKey(
                        name: "FK_Instructor_Course_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instructor_Course_Instructors_Inst_ID",
                        column: x => x.Inst_ID,
                        principalTable: "Instructors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Course_Course_ID",
                table: "Instructor_Course",
                column: "Course_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructor_Course");
        }
    }
}
