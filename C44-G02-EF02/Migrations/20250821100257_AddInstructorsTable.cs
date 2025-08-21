using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C44_G02_EF02.Migrations
{
    public partial class AddInstructorsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HeadInstructorID",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HiringDate",
                table: "Departments",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Ins_ID",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    HourRateBouns = table.Column<decimal>(type: "decimal(10,2)", nullable: false, defaultValue: 0m),
                    Dept_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.ID);
                    table.CheckConstraint("CK_Instructor_HourRateBouns", "HourRateBouns >= 0");
                    table.CheckConstraint("CK_Instructor_Salary", "Salary > 0");
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_Dept_ID",
                        column: x => x.Dept_ID,
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_HeadInstructorID",
                table: "Departments",
                column: "HeadInstructorID");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Department_HiringDate",
                table: "Departments",
                sql: "HiringDate <= GETDATE()");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors",
                column: "Dept_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_HeadInstructorID",
                table: "Departments",
                column: "HeadInstructorID",
                principalTable: "Instructors",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_HeadInstructorID",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_HeadInstructorID",
                table: "Departments");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Department_HiringDate",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "HeadInstructorID",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "HiringDate",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Ins_ID",
                table: "Departments");
        }
    }
}
