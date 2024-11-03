using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "StudentClassId",
                table: "Student",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Student_Class",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    room_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true),
                    client_school_key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Class", x => x.id);
                    table.ForeignKey(
                        name: "FK_Student_Class_Room_room_id",
                        column: x => x.room_id,
                        principalTable: "Room",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentClassId",
                table: "Student",
                column: "StudentClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Class_room_id",
                table: "Student_Class",
                column: "room_id");

            migrationBuilder.AddForeignKey(
                name: "student_class_Id",
                table: "Student",
                column: "StudentClassId",
                principalTable: "Student_Class",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "student_class_Id",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Student_Class");

            migrationBuilder.DropIndex(
                name: "IX_Student_StudentClassId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StudentClassId",
                table: "Student");
        }
    }
}
