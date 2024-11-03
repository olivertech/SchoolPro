using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fee_Type",
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
                    table.PrimaryKey("PK_Fee_Type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "School_Fee",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    value = table.Column<decimal>(type: "numeric", nullable: false),
                    due_date = table.Column<DateOnly>(type: "date", nullable: false),
                    payment_date = table.Column<DateOnly>(type: "date", nullable: false),
                    status_fee = table.Column<string>(type: "text", nullable: false),
                    SchoolEnrollmentId = table.Column<Guid>(type: "uuid", nullable: true),
                    document_id = table.Column<Guid>(type: "uuid", nullable: true),
                    fee_type_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true),
                    client_school_key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School_Fee", x => x.id);
                    table.ForeignKey(
                        name: "FK_School_Fee_Document_document_id",
                        column: x => x.document_id,
                        principalTable: "Document",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_School_Fee_Fee_Type_fee_type_id",
                        column: x => x.fee_type_id,
                        principalTable: "Fee_Type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_School_Fee_document_id",
                table: "School_Fee",
                column: "document_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_Fee_fee_type_id",
                table: "School_Fee",
                column: "fee_type_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "School_Fee");

            migrationBuilder.DropTable(
                name: "Fee_Type");
        }
    }
}
