using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "System_Log",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    action = table.Column<string>(type: "text", nullable: false),
                    json = table.Column<string>(type: "jsonb", nullable: true),
                    timed_at = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Log", x => x.id);
                    table.ForeignKey(
                        name: "FK_System_Log_User_user_id",
                        column: x => x.user_id,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_System_Log_user_id",
                table: "System_Log",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "System_Log");
        }
    }
}
