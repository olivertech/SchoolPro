using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "School_Enrollment",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    enrollment = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    approved = table.Column<bool>(type: "boolean", nullable: false),
                    final_grade = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    student_id = table.Column<Guid>(type: "uuid", nullable: true),
                    school_year_id = table.Column<Guid>(type: "uuid", nullable: true),
                    document_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true),
                    client_school_key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School_Enrollment", x => x.id);
                    table.ForeignKey(
                        name: "FK_School_Enrollment_Document_document_id",
                        column: x => x.document_id,
                        principalTable: "Document",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_School_Enrollment_School_Year_school_year_id",
                        column: x => x.school_year_id,
                        principalTable: "School_Year",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_School_Enrollment_Student_student_id",
                        column: x => x.student_id,
                        principalTable: "Student",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_School_Enrollment_document_id",
                table: "School_Enrollment",
                column: "document_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_Enrollment_school_year_id",
                table: "School_Enrollment",
                column: "school_year_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_Enrollment_student_id",
                table: "School_Enrollment",
                column: "student_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "School_Enrollment");
        }
    }
}
