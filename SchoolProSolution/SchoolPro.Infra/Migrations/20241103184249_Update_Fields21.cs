using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student_Grade",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    minimal_grade = table.Column<decimal>(type: "numeric", nullable: false, defaultValue: 5m),
                    grade = table.Column<decimal>(type: "numeric", nullable: false),
                    date_grade = table.Column<DateOnly>(type: "date", nullable: false),
                    student_id = table.Column<Guid>(type: "uuid", nullable: false),
                    school_subject_id = table.Column<Guid>(type: "uuid", nullable: false),
                    student_class_id = table.Column<Guid>(type: "uuid", nullable: false),
                    school_enrollment_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true),
                    client_school_key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Grade", x => x.id);
                    table.ForeignKey(
                        name: "FK_Student_Grade_School_Enrollment_school_enrollment_id",
                        column: x => x.school_enrollment_id,
                        principalTable: "School_Enrollment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Grade_School_Subject_school_subject_id",
                        column: x => x.school_subject_id,
                        principalTable: "School_Subject",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Grade_Student_Class_student_class_id",
                        column: x => x.student_class_id,
                        principalTable: "Student_Class",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Grade_Student_student_id",
                        column: x => x.student_id,
                        principalTable: "Student",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_Grade_school_enrollment_id",
                table: "Student_Grade",
                column: "school_enrollment_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Grade_school_subject_id",
                table: "Student_Grade",
                column: "school_subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Grade_student_class_id",
                table: "Student_Grade",
                column: "student_class_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Grade_student_id",
                table: "Student_Grade",
                column: "student_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student_Grade");
        }
    }
}
