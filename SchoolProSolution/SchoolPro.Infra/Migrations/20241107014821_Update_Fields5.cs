using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "User",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "id",
                keyValue: new Guid("45533ff6-3ba5-11ef-9476-0242ac130002"),
                column: "client_school_key",
                value: "iaxqRaCHDNR5KZrriHVq59U96PedeKTm.HejGkZngN6A2JzLQ2g5luuye8qSzhmg5");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "User",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "id",
                keyValue: new Guid("45533ff6-3ba5-11ef-9476-0242ac130002"),
                column: "client_school_key",
                value: "9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002-9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002");
        }
    }
}
