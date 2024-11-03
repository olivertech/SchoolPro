using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentClassId",
                table: "Student",
                newName: "student_class_id");

            migrationBuilder.RenameIndex(
                name: "IX_Student_StudentClassId",
                table: "Student",
                newName: "IX_Student_student_class_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "student_class_id",
                table: "Student",
                newName: "StudentClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_student_class_id",
                table: "Student",
                newName: "IX_Student_StudentClassId");
        }
    }
}
