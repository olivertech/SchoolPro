using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "School_Calendar",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    time_from = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    time_to = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    school_subject_id = table.Column<Guid>(type: "uuid", nullable: true),
                    school_year_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true),
                    client_school_key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School_Calendar", x => x.id);
                    table.ForeignKey(
                        name: "FK_School_Calendar_School_Subject_school_subject_id",
                        column: x => x.school_subject_id,
                        principalTable: "School_Subject",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_School_Calendar_School_Year_school_year_id",
                        column: x => x.school_year_id,
                        principalTable: "School_Year",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_School_Calendar_school_subject_id",
                table: "School_Calendar",
                column: "school_subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_Calendar_school_year_id",
                table: "School_Calendar",
                column: "school_year_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "School_Calendar");
        }
    }
}
