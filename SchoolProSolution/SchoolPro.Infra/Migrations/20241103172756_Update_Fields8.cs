using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "role_id",
                table: "User",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true),
                    client_school_key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "id", "client_school_key", "created_at", "deleted_at", "description", "is_active", "name", "updated_at" },
                values: new object[] { new Guid("45533ff6-3ba5-11ef-9476-0242ac130002"), "9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002-9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002", new DateOnly(2024, 11, 3), null, "Perfil de Administrador", true, "Administrador", null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: new Guid("9a150059-614b-47c3-b56f-59deededd8d6"),
                column: "role_id",
                value: new Guid("45533ff6-3ba5-11ef-9476-0242ac130002"));

            migrationBuilder.CreateIndex(
                name: "IX_User_role_id",
                table: "User",
                column: "role_id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_role_id",
                table: "User",
                column: "role_id",
                principalTable: "Role",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_role_id",
                table: "User");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropIndex(
                name: "IX_User_role_id",
                table: "User");

            migrationBuilder.DropColumn(
                name: "role_id",
                table: "User");
        }
    }
}
