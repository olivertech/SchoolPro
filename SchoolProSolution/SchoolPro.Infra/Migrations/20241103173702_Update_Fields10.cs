using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "School_Subject",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true),
                    client_school_key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School_Subject", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher_School_Subject",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    teacher_id = table.Column<Guid>(type: "uuid", nullable: true),
                    school_subject_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true),
                    client_school_key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher_School_Subject", x => x.id);
                    table.ForeignKey(
                        name: "school_subject_Id",
                        column: x => x.school_subject_id,
                        principalTable: "School_Subject",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "teacher_Id",
                        column: x => x.teacher_id,
                        principalTable: "Teacher",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_School_Subject_school_subject_id",
                table: "Teacher_School_Subject",
                column: "school_subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_School_Subject_teacher_id",
                table: "Teacher_School_Subject",
                column: "teacher_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "teacher_Id",
                table: "Document");

            migrationBuilder.DropTable(
                name: "Teacher_School_Subject");

            migrationBuilder.DropTable(
                name: "School_Subject");
        }
    }
}
