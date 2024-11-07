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
            migrationBuilder.AddColumn<string>(
                name: "document",
                table: "User",
                type: "character varying(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "id",
                keyValue: new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                column: "created_at",
                value: new DateOnly(2024, 11, 6));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "id",
                keyValue: new Guid("45533ff6-3ba5-11ef-9476-0242ac130002"),
                column: "created_at",
                value: new DateOnly(2024, 11, 6));

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "id",
                keyValue: new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                column: "created_at",
                value: new DateOnly(2024, 11, 6));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: new Guid("9a150059-614b-47c3-b56f-59deededd8d6"),
                columns: new[] { "created_at", "document" },
                values: new object[] { new DateOnly(2024, 11, 6), "02188285786" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "document",
                table: "User");

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "id",
                keyValue: new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                column: "created_at",
                value: new DateOnly(2024, 11, 3));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "id",
                keyValue: new Guid("45533ff6-3ba5-11ef-9476-0242ac130002"),
                column: "created_at",
                value: new DateOnly(2024, 11, 3));

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "id",
                keyValue: new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                column: "created_at",
                value: new DateOnly(2024, 11, 3));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: new Guid("9a150059-614b-47c3-b56f-59deededd8d6"),
                column: "created_at",
                value: new DateOnly(2024, 11, 3));
        }
    }
}
