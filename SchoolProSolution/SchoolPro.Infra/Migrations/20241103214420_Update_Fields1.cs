using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "school_key",
                table: "School",
                type: "text",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<string>(
                name: "client_key",
                table: "Client",
                type: "text",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "id",
                keyValue: new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                column: "client_key",
                value: "iaxqRaCHDNR5KZrriHVq59U96PedeKTm");

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "id",
                keyValue: new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                column: "school_key",
                value: "HejGkZngN6A2JzLQ2g5luuye8qSzhmg5");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "school_key",
                table: "School",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<Guid>(
                name: "client_key",
                table: "Client",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "id",
                keyValue: new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                column: "client_key",
                value: new Guid("45533ff6-3ba5-11ef-9476-0242ac130002"));

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "id",
                keyValue: new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                column: "school_key",
                value: new Guid("6c9b91d0-3ba5-11ef-9476-0242ac130002"));
        }
    }
}
