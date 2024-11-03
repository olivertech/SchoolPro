using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPro.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Fields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Contact_address_id",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "address_id",
                table: "Student",
                newName: "contact_id");

            migrationBuilder.RenameIndex(
                name: "IX_Student_address_id",
                table: "Student",
                newName: "IX_Student_contact_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Contact_contact_id",
                table: "Student",
                column: "contact_id",
                principalTable: "Contact",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Contact_contact_id",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "contact_id",
                table: "Student",
                newName: "address_id");

            migrationBuilder.RenameIndex(
                name: "IX_Student_contact_id",
                table: "Student",
                newName: "IX_Student_address_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Contact_address_id",
                table: "Student",
                column: "address_id",
                principalTable: "Contact",
                principalColumn: "id");
        }
    }
}
