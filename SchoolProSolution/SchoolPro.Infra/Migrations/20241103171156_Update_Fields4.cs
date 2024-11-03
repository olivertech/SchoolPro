using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Access_Token",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    token = table.Column<string>(type: "text", nullable: false),
                    timed_at = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    expiring_at = table.Column<DateOnly>(type: "date", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true),
                    client_school_key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Access_Token", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_access_token_id",
                table: "User",
                column: "access_token_id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Access_Token_access_token_id",
                table: "User",
                column: "access_token_id",
                principalTable: "Access_Token",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Access_Token_access_token_id",
                table: "User");

            migrationBuilder.DropTable(
                name: "Access_Token");

            migrationBuilder.DropIndex(
                name: "IX_User_access_token_id",
                table: "User");
        }
    }
}
