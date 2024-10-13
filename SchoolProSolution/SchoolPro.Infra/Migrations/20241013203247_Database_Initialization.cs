using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Database_Initialization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    street_address = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    address_line_2 = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    neighborhood = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    city = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    state = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    postal_code = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "School_Subject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student_Class",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Class", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    birthdate = table.Column<DateOnly>(type: "date", nullable: true),
                    gender = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    birthdate = table.Column<DateOnly>(type: "date", nullable: true),
                    gender = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true),
                    kinship = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    address_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parent_Address_address_id",
                        column: x => x.address_id,
                        principalTable: "Address",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    address_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.Id);
                    table.ForeignKey(
                        name: "FK_School_Address_address_id",
                        column: x => x.address_id,
                        principalTable: "Address",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    birthdate = table.Column<DateOnly>(type: "date", nullable: true),
                    gender = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true),
                    address_id = table.Column<Guid>(type: "uuid", nullable: true),
                    StudentClassId = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Address_address_id",
                        column: x => x.address_id,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "student_class_Id",
                        column: x => x.StudentClassId,
                        principalTable: "Student_Class",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Teacher_School_Subject",
                columns: table => new
                {
                    teacher_id = table.Column<Guid>(type: "uuid", nullable: false),
                    school_subject_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher_School_Subject", x => new { x.school_subject_id, x.teacher_id });
                    table.ForeignKey(
                        name: "school_subject_Id",
                        column: x => x.school_subject_id,
                        principalTable: "School_Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "teacher_Id",
                        column: x => x.teacher_id,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    school_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_School_school_id",
                        column: x => x.school_id,
                        principalTable: "School",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    file_path = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    student_id = table.Column<Guid>(type: "uuid", nullable: true),
                    teacher_id = table.Column<Guid>(type: "uuid", nullable: true),
                    parent_id = table.Column<Guid>(type: "uuid", nullable: true),
                    school_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                    table.ForeignKey(
                        name: "parent_Id",
                        column: x => x.parent_id,
                        principalTable: "Parent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "school_Id",
                        column: x => x.school_id,
                        principalTable: "School",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "student_Id",
                        column: x => x.student_id,
                        principalTable: "Student",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "teacher_Id",
                        column: x => x.teacher_id,
                        principalTable: "Teacher",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Student_Parent",
                columns: table => new
                {
                    student_id = table.Column<Guid>(type: "uuid", nullable: false),
                    parent_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Parent", x => new { x.student_id, x.parent_id });
                    table.ForeignKey(
                        name: "parent_id",
                        column: x => x.parent_id,
                        principalTable: "Parent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "student_id",
                        column: x => x.student_id,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "School_Calendar",
                columns: table => new
                {
                    room_id = table.Column<Guid>(type: "uuid", nullable: false),
                    school_subject_id = table.Column<Guid>(type: "uuid", nullable: false),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    time_from = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    time_to = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School_Calendar", x => new { x.room_id, x.school_subject_id });
                    table.ForeignKey(
                        name: "FK_School_Calendar_Room_room_id",
                        column: x => x.room_id,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_School_Calendar_School_Subject_school_subject_id",
                        column: x => x.school_subject_id,
                        principalTable: "School_Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Document_parent_id",
                table: "Document",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_Document_school_id",
                table: "Document",
                column: "school_id");

            migrationBuilder.CreateIndex(
                name: "IX_Document_student_id",
                table: "Document",
                column: "student_id");

            migrationBuilder.CreateIndex(
                name: "IX_Document_teacher_id",
                table: "Document",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_Parent_address_id",
                table: "Parent",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_school_id",
                table: "Room",
                column: "school_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_address_id",
                table: "School",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_Calendar_school_subject_id",
                table: "School_Calendar",
                column: "school_subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_address_id",
                table: "Student",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentClassId",
                table: "Student",
                column: "StudentClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Parent_parent_id",
                table: "Student_Parent",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_School_Subject_teacher_id",
                table: "Teacher_School_Subject",
                column: "teacher_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "School_Calendar");

            migrationBuilder.DropTable(
                name: "Student_Parent");

            migrationBuilder.DropTable(
                name: "Teacher_School_Subject");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Parent");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "School_Subject");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "School");

            migrationBuilder.DropTable(
                name: "Student_Class");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
