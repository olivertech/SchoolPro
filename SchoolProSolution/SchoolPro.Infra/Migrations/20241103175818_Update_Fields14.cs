using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_School_Fee_Document_document_id",
                table: "School_Fee");

            migrationBuilder.DropIndex(
                name: "IX_School_Fee_document_id",
                table: "School_Fee");

            migrationBuilder.DropColumn(
                name: "document_id",
                table: "School_Fee");

            migrationBuilder.AddColumn<Guid>(
                name: "school_fee_id",
                table: "Document",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Document_school_fee_id",
                table: "Document",
                column: "school_fee_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_School_Fee_school_fee_id",
                table: "Document",
                column: "school_fee_id",
                principalTable: "School_Fee",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_School_Fee_school_fee_id",
                table: "Document");

            migrationBuilder.DropIndex(
                name: "IX_Document_school_fee_id",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "school_fee_id",
                table: "Document");

            migrationBuilder.AddColumn<Guid>(
                name: "document_id",
                table: "School_Fee",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_School_Fee_document_id",
                table: "School_Fee",
                column: "document_id");

            migrationBuilder.AddForeignKey(
                name: "FK_School_Fee_Document_document_id",
                table: "School_Fee",
                column: "document_id",
                principalTable: "Document",
                principalColumn: "id");
        }
    }
}
