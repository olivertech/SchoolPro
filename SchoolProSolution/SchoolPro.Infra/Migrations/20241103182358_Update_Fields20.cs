using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_School_Enrollment_Document_document_id",
                table: "School_Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_School_Enrollment_document_id",
                table: "School_Enrollment");

            migrationBuilder.DropColumn(
                name: "document_id",
                table: "School_Enrollment");

            migrationBuilder.AddColumn<Guid>(
                name: "school_enrollment_id",
                table: "Document",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Document_school_enrollment_id",
                table: "Document",
                column: "school_enrollment_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_School_Enrollment_school_enrollment_id",
                table: "Document",
                column: "school_enrollment_id",
                principalTable: "School_Enrollment",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_School_Enrollment_school_enrollment_id",
                table: "Document");

            migrationBuilder.DropIndex(
                name: "IX_Document_school_enrollment_id",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "school_enrollment_id",
                table: "Document");

            migrationBuilder.AddColumn<Guid>(
                name: "document_id",
                table: "School_Enrollment",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_School_Enrollment_document_id",
                table: "School_Enrollment",
                column: "document_id");

            migrationBuilder.AddForeignKey(
                name: "FK_School_Enrollment_Document_document_id",
                table: "School_Enrollment",
                column: "document_id",
                principalTable: "Document",
                principalColumn: "id");
        }
    }
}
