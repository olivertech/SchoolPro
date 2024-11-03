using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_School_school_id",
                table: "Document");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    picture_path = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    client_id = table.Column<Guid>(type: "uuid", nullable: false),
                    access_token_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                    table.ForeignKey(
                        name: "FK_User_Client_client_id",
                        column: x => x.client_id,
                        principalTable: "Client",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "id", "access_token_id", "client_id", "created_at", "deleted_at", "email", "is_active", "name", "password", "picture_path", "updated_at" },
                values: new object[] { new Guid("9a150059-614b-47c3-b56f-59deededd8d6"), null, new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"), new DateOnly(2024, 11, 3), null, "marcelo@schoolpro.com", true, "Marcelo de Oliveira", "123", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_User_client_id",
                table: "User",
                column: "client_id");

            migrationBuilder.AddForeignKey(
                name: "school_Id",
                table: "Document",
                column: "school_id",
                principalTable: "School",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "school_Id",
                table: "Document");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_School_school_id",
                table: "Document",
                column: "school_id",
                principalTable: "School",
                principalColumn: "id");
        }
    }
}
