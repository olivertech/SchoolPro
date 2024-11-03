using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Database_Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    responsable_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    responsable_email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    responsable_cellphone_1 = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    responsable_cellphone_2 = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    client_key = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    telephone = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: true),
                    cellphone = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    facebook = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    instagram = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    twitter = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    linkedin = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    github = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true),
                    street_address = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    address_line_2 = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    neighborhood = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    city = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    state = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    postal_code = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true),
                    client_school_key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Parent",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    birthdate = table.Column<DateOnly>(type: "date", nullable: true),
                    gender = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true),
                    kinship = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    contact_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true),
                    client_school_key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.id);
                    table.ForeignKey(
                        name: "FK_Parent_Contact_contact_id",
                        column: x => x.contact_id,
                        principalTable: "Contact",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    cnpj = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    state_registration = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    count_registration = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    is_branch = table.Column<bool>(type: "boolean", nullable: false),
                    school_key = table.Column<Guid>(type: "uuid", nullable: false),
                    contact_id = table.Column<Guid>(type: "uuid", nullable: true),
                    client_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.id);
                    table.ForeignKey(
                        name: "FK_School_Client_client_id",
                        column: x => x.client_id,
                        principalTable: "Client",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_School_Contact_contact_id",
                        column: x => x.contact_id,
                        principalTable: "Contact",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true),
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
                    table.PrimaryKey("PK_Student", x => x.id);
                    table.ForeignKey(
                        name: "FK_Student_Contact_address_id",
                        column: x => x.address_id,
                        principalTable: "Contact",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    file_path = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    student_id = table.Column<Guid>(type: "uuid", nullable: true),
                    ParentId = table.Column<Guid>(type: "uuid", nullable: true),
                    school_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true),
                    client_school_key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.id);
                    table.ForeignKey(
                        name: "FK_Document_School_school_id",
                        column: x => x.school_id,
                        principalTable: "School",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "parent_Id",
                        column: x => x.ParentId,
                        principalTable: "Parent",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "student_Id",
                        column: x => x.student_id,
                        principalTable: "Student",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Student_Parent",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    student_id = table.Column<Guid>(type: "uuid", nullable: true),
                    parent_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateOnly>(type: "date", nullable: false),
                    updated_at = table.Column<DateOnly>(type: "date", nullable: true),
                    deleted_at = table.Column<DateOnly>(type: "date", nullable: true),
                    client_school_key = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Parent", x => x.id);
                    table.ForeignKey(
                        name: "parent_id",
                        column: x => x.parent_id,
                        principalTable: "Parent",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "student_id",
                        column: x => x.student_id,
                        principalTable: "Student",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "id", "client_key", "created_at", "deleted_at", "description", "is_active", "name", "responsable_cellphone_1", "responsable_cellphone_2", "responsable_email", "responsable_name", "updated_at" },
                values: new object[] { new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"), new Guid("45533ff6-3ba5-11ef-9476-0242ac130002"), new DateOnly(2024, 11, 3), null, "Rede de Ensino 123 de Oliveira 4", true, "Rede de Ensino 123 de Oliveira 4", "(11) 11111-1111", "(22) 22222-2222", "joao.silva@123deoliveira4.com", "João da Silva", null });

            migrationBuilder.InsertData(
                table: "School",
                columns: new[] { "id", "cnpj", "client_id", "contact_id", "count_registration", "created_at", "deleted_at", "description", "is_active", "is_branch", "name", "school_key", "state_registration", "updated_at" },
                values: new object[] { new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"), "12345678000199", new Guid("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"), null, null, new DateOnly(2024, 11, 3), null, "Matriz da Rede de Ensino 123 de Oliveira 4", true, false, "Matriz da Rede de Ensino 123 de Oliveira 4", new Guid("6c9b91d0-3ba5-11ef-9476-0242ac130002"), null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Document_ParentId",
                table: "Document",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_school_id",
                table: "Document",
                column: "school_id");

            migrationBuilder.CreateIndex(
                name: "IX_Document_student_id",
                table: "Document",
                column: "student_id");

            migrationBuilder.CreateIndex(
                name: "IX_Parent_contact_id",
                table: "Parent",
                column: "contact_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_client_id",
                table: "School",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_contact_id",
                table: "School",
                column: "contact_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_address_id",
                table: "Student",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Parent_parent_id",
                table: "Student_Parent",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Parent_student_id",
                table: "Student_Parent",
                column: "student_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Student_Parent");

            migrationBuilder.DropTable(
                name: "School");

            migrationBuilder.DropTable(
                name: "Parent");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
