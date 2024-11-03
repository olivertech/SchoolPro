using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "School_Calendar",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    school_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true),
                    client_school_key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.id);
                    table.ForeignKey(
                        name: "FK_Room_School_school_id",
                        column: x => x.school_id,
                        principalTable: "School",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_School_Calendar_RoomId",
                table: "School_Calendar",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_school_id",
                table: "Room",
                column: "school_id");

            migrationBuilder.AddForeignKey(
                name: "FK_School_Calendar_Room_RoomId",
                table: "School_Calendar",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_School_Calendar_Room_RoomId",
                table: "School_Calendar");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropIndex(
                name: "IX_School_Calendar_RoomId",
                table: "School_Calendar");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "School_Calendar");
        }
    }
}
