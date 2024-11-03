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
                name: "Access_Token",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    token = table.Column<string>(type: "text", nullable: false),
                    timed_at = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    expiring_at = table.Column<DateOnly>(type: "date", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Access_Token", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    responsable_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    responsable_email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    responsable_cellphone_1 = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true),
                    responsable_cellphone_2 = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true),
                    client_key = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                    telephone = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cellphone = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true),
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
                    postal_code = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Document_Type",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Icone = table.Column<string>(type: "text", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_Type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Feature",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    menu_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    menu_tip = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    menu_endpoint = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    menu_icon = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feature", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Fee_Type",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fee_Type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "School_Subject",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School_Subject", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "School_Year",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    year = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    budget = table.Column<decimal>(type: "numeric", nullable: false),
                    billing = table.Column<decimal>(type: "numeric", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School_Year", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    picture_path = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    client_id = table.Column<Guid>(type: "uuid", nullable: false),
                    access_token_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                    table.ForeignKey(
                        name: "FK_User_Access_Token_access_token_id",
                        column: x => x.access_token_id,
                        principalTable: "Access_Token",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Client_client_id",
                        column: x => x.client_id,
                        principalTable: "Client",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                    address_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.id);
                    table.ForeignKey(
                        name: "FK_Parent_Contact_address_id",
                        column: x => x.address_id,
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
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Feature_Role",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    feature_id = table.Column<Guid>(type: "uuid", nullable: true),
                    role_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feature_Role", x => x.id);
                    table.ForeignKey(
                        name: "feature_id",
                        column: x => x.feature_id,
                        principalTable: "Feature",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "role_id",
                        column: x => x.role_id,
                        principalTable: "Role",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "User_Role",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: true),
                    role_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Role", x => x.id);
                    table.ForeignKey(
                        name: "role_id",
                        column: x => x.role_id,
                        principalTable: "Role",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "user_id",
                        column: x => x.user_id,
                        principalTable: "User",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    school_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.id);
                    table.ForeignKey(
                        name: "FK_Room_School_school_id",
                        column: x => x.school_id,
                        principalTable: "School",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teacher_School_Subject",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    teacher_id = table.Column<Guid>(type: "uuid", nullable: true),
                    school_subject_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher_School_Subject", x => x.id);
                    table.ForeignKey(
                        name: "school_subject_Id",
                        column: x => x.school_subject_id,
                        principalTable: "School_Subject",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "teacher_Id",
                        column: x => x.teacher_id,
                        principalTable: "Teacher",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "School_Calendar",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    time_from = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    time_to = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    room_id = table.Column<Guid>(type: "uuid", nullable: true),
                    school_subject_id = table.Column<Guid>(type: "uuid", nullable: true),
                    school_year_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School_Calendar", x => x.id);
                    table.ForeignKey(
                        name: "FK_School_Calendar_Room_room_id",
                        column: x => x.room_id,
                        principalTable: "Room",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_School_Calendar_School_Subject_school_subject_id",
                        column: x => x.school_subject_id,
                        principalTable: "School_Subject",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_School_Calendar_School_Year_school_year_id",
                        column: x => x.school_year_id,
                        principalTable: "School_Year",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Student_Class",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    room_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Class", x => x.id);
                    table.ForeignKey(
                        name: "FK_Student_Class_Room_room_id",
                        column: x => x.room_id,
                        principalTable: "Room",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                    student_class_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.id);
                    table.ForeignKey(
                        name: "FK_Student_Contact_address_id",
                        column: x => x.address_id,
                        principalTable: "Contact",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "student_class_Id",
                        column: x => x.student_class_id,
                        principalTable: "Student_Class",
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
                    teacher_id = table.Column<Guid>(type: "uuid", nullable: true),
                    parent_id = table.Column<Guid>(type: "uuid", nullable: true),
                    school_id = table.Column<Guid>(type: "uuid", nullable: true),
                    document_type_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.id);
                    table.ForeignKey(
                        name: "FK_Document_Document_Type_document_type_id",
                        column: x => x.document_type_id,
                        principalTable: "Document_Type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "parent_Id",
                        column: x => x.parent_id,
                        principalTable: "Parent",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "school_Id",
                        column: x => x.school_id,
                        principalTable: "School",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "student_Id",
                        column: x => x.student_id,
                        principalTable: "Student",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "teacher_Id",
                        column: x => x.teacher_id,
                        principalTable: "Teacher",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Student_Grade",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    student_id = table.Column<Guid>(type: "uuid", nullable: false),
                    school_subject_id = table.Column<Guid>(type: "uuid", nullable: false),
                    grade = table.Column<decimal>(type: "numeric", nullable: false),
                    date_grade = table.Column<DateOnly>(type: "date", nullable: false),
                    student_class_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Grade", x => x.id);
                    table.ForeignKey(
                        name: "FK_Student_Grade_School_Subject_school_subject_id",
                        column: x => x.school_subject_id,
                        principalTable: "School_Subject",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Grade_Student_Class_student_class_id",
                        column: x => x.student_class_id,
                        principalTable: "Student_Class",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Grade_Student_student_id",
                        column: x => x.student_id,
                        principalTable: "Student",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student_Parent",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    student_id = table.Column<Guid>(type: "uuid", nullable: true),
                    parent_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "School_Enrollment",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    enrollment = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    approved = table.Column<bool>(type: "boolean", nullable: false),
                    final_grade = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    student_id = table.Column<Guid>(type: "uuid", nullable: true),
                    school_year_id = table.Column<Guid>(type: "uuid", nullable: true),
                    document_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School_Enrollment", x => x.id);
                    table.ForeignKey(
                        name: "FK_School_Enrollment_Document_document_id",
                        column: x => x.document_id,
                        principalTable: "Document",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_School_Enrollment_School_Year_school_year_id",
                        column: x => x.school_year_id,
                        principalTable: "School_Year",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_School_Enrollment_Student_student_id",
                        column: x => x.student_id,
                        principalTable: "Student",
                        principalColumn: "id");
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
                    school_enrollment_id = table.Column<Guid>(type: "uuid", nullable: true),
                    document_id = table.Column<Guid>(type: "uuid", nullable: true),
                    fee_type_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    client_school_key = table.Column<Guid>(type: "uuid", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_School_Fee_School_Enrollment_school_enrollment_id",
                        column: x => x.school_enrollment_id,
                        principalTable: "School_Enrollment",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Document_document_type_id",
                table: "Document",
                column: "document_type_id");

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
                name: "IX_Feature_Role_feature_id",
                table: "Feature_Role",
                column: "feature_id");

            migrationBuilder.CreateIndex(
                name: "IX_Feature_Role_role_id",
                table: "Feature_Role",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_Parent_address_id",
                table: "Parent",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_school_id",
                table: "Room",
                column: "school_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_client_id",
                table: "School",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_contact_id",
                table: "School",
                column: "contact_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_Calendar_room_id",
                table: "School_Calendar",
                column: "room_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_Calendar_school_subject_id",
                table: "School_Calendar",
                column: "school_subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_Calendar_school_year_id",
                table: "School_Calendar",
                column: "school_year_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_Enrollment_document_id",
                table: "School_Enrollment",
                column: "document_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_Enrollment_school_year_id",
                table: "School_Enrollment",
                column: "school_year_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_Enrollment_student_id",
                table: "School_Enrollment",
                column: "student_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_Fee_document_id",
                table: "School_Fee",
                column: "document_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_Fee_fee_type_id",
                table: "School_Fee",
                column: "fee_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_School_Fee_school_enrollment_id",
                table: "School_Fee",
                column: "school_enrollment_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_address_id",
                table: "Student",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_student_class_id",
                table: "Student",
                column: "student_class_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Class_room_id",
                table: "Student_Class",
                column: "room_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Grade_school_subject_id",
                table: "Student_Grade",
                column: "school_subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Grade_student_class_id",
                table: "Student_Grade",
                column: "student_class_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Grade_student_id",
                table: "Student_Grade",
                column: "student_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Parent_parent_id",
                table: "Student_Parent",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Parent_student_id",
                table: "Student_Parent",
                column: "student_id");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_address_id",
                table: "Teacher",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_School_Subject_school_subject_id",
                table: "Teacher_School_Subject",
                column: "school_subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_School_Subject_teacher_id",
                table: "Teacher_School_Subject",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "IX_User_access_token_id",
                table: "User",
                column: "access_token_id");

            migrationBuilder.CreateIndex(
                name: "IX_User_client_id",
                table: "User",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Role_role_id",
                table: "User_Role",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Role_user_id",
                table: "User_Role",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feature_Role");

            migrationBuilder.DropTable(
                name: "School_Calendar");

            migrationBuilder.DropTable(
                name: "School_Fee");

            migrationBuilder.DropTable(
                name: "Student_Grade");

            migrationBuilder.DropTable(
                name: "Student_Parent");

            migrationBuilder.DropTable(
                name: "Teacher_School_Subject");

            migrationBuilder.DropTable(
                name: "User_Role");

            migrationBuilder.DropTable(
                name: "Feature");

            migrationBuilder.DropTable(
                name: "Fee_Type");

            migrationBuilder.DropTable(
                name: "School_Enrollment");

            migrationBuilder.DropTable(
                name: "School_Subject");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "School_Year");

            migrationBuilder.DropTable(
                name: "Access_Token");

            migrationBuilder.DropTable(
                name: "Document_Type");

            migrationBuilder.DropTable(
                name: "Parent");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Student_Class");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "School");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
