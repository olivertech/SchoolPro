using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: new Guid("9a150059-614b-47c3-b56f-59deededd8d6"),
                column: "password",
                value: "$2a$10$dg0T/t5ElR/EjCdbOW2pm.3GPphHOn3X2.V6WSqpfWDlLdEBgu.yC");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: new Guid("9a150059-614b-47c3-b56f-59deededd8d6"),
                column: "password",
                value: "123");
        }
    }
}
