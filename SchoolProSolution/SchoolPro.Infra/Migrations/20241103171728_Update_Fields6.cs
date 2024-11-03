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
            migrationBuilder.DropForeignKey(
                name: "FK_Document_DocumentTypes_document_type_id",
                table: "Document");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentTypes",
                table: "DocumentTypes");

            migrationBuilder.RenameTable(
                name: "DocumentTypes",
                newName: "Document_Type");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Document_Type",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Document_Type",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Document_Type",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Document_Type",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Document_Type",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "Document_Type",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Document_Type",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "ClientSchoolKey",
                table: "Document_Type",
                newName: "client_school_key");

            migrationBuilder.AlterColumn<Guid>(
                name: "document_type_id",
                table: "Document",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Document_Type",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Document_Type",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_active",
                table: "Document_Type",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "client_school_key",
                table: "Document_Type",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Document_Type",
                table: "Document_Type",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Document_Type_document_type_id",
                table: "Document",
                column: "document_type_id",
                principalTable: "Document_Type",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_Document_Type_document_type_id",
                table: "Document");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Document_Type",
                table: "Document_Type");

            migrationBuilder.RenameTable(
                name: "Document_Type",
                newName: "DocumentTypes");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "DocumentTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "DocumentTypes",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "DocumentTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "DocumentTypes",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "DocumentTypes",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "DocumentTypes",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "DocumentTypes",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "client_school_key",
                table: "DocumentTypes",
                newName: "ClientSchoolKey");

            migrationBuilder.AlterColumn<Guid>(
                name: "document_type_id",
                table: "Document",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "DocumentTypes",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "DocumentTypes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "DocumentTypes",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientSchoolKey",
                table: "DocumentTypes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentTypes",
                table: "DocumentTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_DocumentTypes_document_type_id",
                table: "Document",
                column: "document_type_id",
                principalTable: "DocumentTypes",
                principalColumn: "Id");
        }
    }
}
