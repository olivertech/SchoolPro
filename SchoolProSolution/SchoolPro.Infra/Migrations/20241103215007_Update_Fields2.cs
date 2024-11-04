using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "school_key",
                table: "School");

            migrationBuilder.AddColumn<string>(
                name: "school_secret_key",
                table: "School",
                type: "character varying(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "client_key",
                table: "Client",
                type: "character varying(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "id",
                keyValue: new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                column: "school_secret_key",
                value: "HejGkZngN6A2JzLQ2g5luuye8qSzhmg5");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "school_secret_key",
                table: "School");

            migrationBuilder.AddColumn<string>(
                name: "school_key",
                table: "School",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "client_key",
                table: "Client",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(32)",
                oldMaxLength: 32);

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "id",
                keyValue: new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                column: "school_key",
                value: "HejGkZngN6A2JzLQ2g5luuye8qSzhmg5");
        }
    }
}
