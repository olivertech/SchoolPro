using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Add_Teacher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Document",
                newName: "parent_id");

            migrationBuilder.RenameIndex(
                name: "IX_Document_ParentId",
                table: "Document",
                newName: "IX_Document_parent_id");

            migrationBuilder.AddColumn<Guid>(
                name: "teacher_id",
                table: "Document",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    birthdate = table.Column<DateOnly>(type: "date", nullable: true),
                    gender = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true),
                    address_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true),
                    client_school_key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.id);
                    table.ForeignKey(
                        name: "FK_Teacher_Contact_address_id",
                        column: x => x.address_id,
                        principalTable: "Contact",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Document_teacher_id",
                table: "Document",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_address_id",
                table: "Teacher",
                column: "address_id");

            migrationBuilder.AddForeignKey(
                name: "teacher_Id",
                table: "Document",
                column: "teacher_id",
                principalTable: "Teacher",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "teacher_Id",
                table: "Document");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Document_teacher_id",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "teacher_id",
                table: "Document");

            migrationBuilder.RenameColumn(
                name: "parent_id",
                table: "Document",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Document_parent_id",
                table: "Document",
                newName: "IX_Document_ParentId");
        }
    }
}
